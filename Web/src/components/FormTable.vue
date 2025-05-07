<template>
  <div class="q-pa-md">
    <!-- 查询条件区域 -->
    <div class="row q-col-gutter-md q-mb-md">
      <template v-for="(field, name) in config.queryFields" :key="name">
        <component
          :is="getComponentType(field.type)"
          v-model="queryParams[name]"
          class="col"
          v-bind="field.props"
          :label="field.label"
        />
      </template>

      <div class="col-auto row q-col-gutter-sm">
        <q-btn color="primary" @click="handleSearch">查询</q-btn>
        <q-btn color="positive" @click="showAddDialog">新增</q-btn>
        <q-btn color="negative" @click="handleBatchDelete">删除</q-btn>
      </div>
    </div>

    <!-- 数据表格 -->
    <q-table
      :rows="tableData"
      :columns="columns"
      row-key="id"
      selection="multiple"
      v-model:selected="selectedRows"
      v-model:pagination="pagination"
      @request="onTableChange"
    >
      <slot></slot>
      <!-- 操作列插槽 -->
      <template #body-cell-actions="props">
        <q-td :props="props">
          <q-btn-group flat>
            <q-btn icon="visibility" dense @click="handleView(props.row)" />
            <q-btn icon="edit" dense @click="showEditDialog(props.row)" />
            <q-btn icon="delete" dense @click="handleDelete(props.row.id)" />
            <slot name="action-buttons" :row="props.row"></slot>
          </q-btn-group>
        </q-td>
      </template>
    </q-table>

    <!-- 表单弹窗 -->
    <q-dialog v-model="formDialogVisible" persistent>
      <q-card style="min-width: 500px">
        <q-card-section>
          <div class="text-h6">{{ dialogTitle }}表单</div>
        </q-card-section>

        <q-card-section>
          <q-form>
            <div class="row q-col-gutter-md">
              <template v-for="(field, name) in config.formFields" :key="name">
                <component
                  :is="getComponentType(field.type)"
                  v-model="formData[name]"
                  class="col-12"
                  v-show="field.show || field.show == undefined"
                  v-bind="field.props"
                  :label="field.label"
                  :rules="field.rules"
                />
              </template>
            </div>
          </q-form>
        </q-card-section>

        <q-card-actions align="right">
          <q-btn flat label="取消" v-close-popup />
          <q-btn color="primary" label="提交" @click="submitForm" />
        </q-card-actions>
      </q-card>
    </q-dialog>
  </div>
</template>

<script setup>
import { ref, reactive, computed, watchEffect } from 'vue'
import { useQuasar, QInput, QSelect } from 'quasar'
import * as PrimeVue from 'primevue'

const getComponentType = (type) => {
  const componentMap = {
    'q-input': QInput,
    'q-select': QSelect,
  }
  return componentMap[type] || PrimeVue[type] || type
}
const props = defineProps({
  config: {
    type: Object,
    required: true,
    validator: (value) => {
      return ['queryFields', 'formFields', 'tableColumns'].every((key) => key in value)
    },
  },
})

const emit = defineEmits(['search', 'create', 'update', 'delete', 'batch-delete'])

// 移除原有的axios相关代码
// 保持表格数据相关状态
const tableData = ref([])
const selectedRows = ref([])
const pagination = reactive({
  page: 1,
  rowsPerPage: 10,
  rowsNumber: 0,
})

const showAddDialog = () => {
  console.log(formData)
  formDialogVisible.value = true
}
// 修改后的获取数据方法
const fetchData = async () => {
  try {
    const params = {
      ...queryParams,
      page: pagination.page,
      pageSize: pagination.rowsPerPage,
    }

    // 触发搜索事件并等待父组件处理
    const result = await emit('search', {
      queryParams: params,
      pagination,
    })

    // 父组件需要返回处理后的数据
    if (result) {
      tableData.value = result.items
      pagination.rowsNumber = result.total
    }
  } catch (error) {
    handleError(error)
  }
}

// 修改后的表单提交方法
const submitForm = async () => {
  try {
    const payload = {
      data: { ...formData },
      id: currentEditId.value,
    }

    // 根据编辑/新增状态触发不同事件
    const result = currentEditId.value
      ? await emit('update', payload)
      : await emit('create', payload)

    if (result) {
      formDialogVisible.value = false
      await fetchData()
      showNotify('success', '操作成功')
    }
  } catch (error) {
    handleError(error)
  }
}

// 修改后的删除处理
const handleDelete = async (id) => {
  try {
    const success = await emit('delete', { id })
    if (success) {
      await fetchData()
      showNotify('success', '删除成功')
    }
  } catch (error) {
    handleError(error)
  }
}

// 新增批量删除处理
const handleBatchDelete = async () => {
  if (selectedRows.value.length === 0) {
    showNotify('warning', '请选择要删除的记录')
    return
  }

  try {
    const ids = selectedRows.value.map((item) => item.id)
    const success = await emit('batch-delete', { ids })
    if (success) {
      await fetchData()
      showNotify('success', '批量删除成功')
    }
  } catch (error) {
    handleError(error)
  }
}
const $q = useQuasar()
// 查询参数
const queryParams = reactive({})
const initQueryParams = () => {
  Object.keys(props.config.queryFields).forEach((key) => {
    queryParams[key] = props.config.queryFields[key].defaultValue || null
  })
}
initQueryParams()

// 表单数据
const formData = reactive({})
const formDialogVisible = ref(false)
const currentEditId = ref(null)
const dialogTitle = computed(() => (currentEditId.value ? '编辑' : '新增'))

// 处理分页变化
const onTableChange = async (newPagination) => {
  Object.assign(pagination, newPagination)
  await fetchData()
}

// 错误统一处理
const handleError = (error) => {
  const message = error.response?.data?.message || '请求失败'
  showNotify('negative', message)
}

// 显示通知
const showNotify = (type, message) => {
  $q.notify({ type, message })
}

// 暴露方法给父组件
defineExpose({
  refresh: fetchData,
})

// 初始化列配置
const columns = computed(() => [
  ...props.config.tableColumns,
  {
    name: 'actions',
    label: '操作',
    align: 'center',
    sortable: false,
    classes: 'fixed-column',
  },
])

// 自动获取初始数据
watchEffect(() => {
  fetchData()
})
</script>

<style scoped>
.fixed-column {
  position: sticky;
  right: 0;
  background: white;
  z-index: 1;
}
</style>
