<template>
  <div class="q-pa-md">
    <!-- 查询条件区域 -->
    <div
      class="row q-col-gutter-md q-mb-md"
      style="display: grid; grid-template-columns: repeat(auto-fill, minmax(300px, 1fr)); gap: 16px"
    >
      <template v-for="(field, name) in config.queryFields" :key="name">
        <component
          :is="getComponentType(field.type)"
          v-model="queryParams[name]"
          v-show="field.show || field.show == undefined"
          class="col"
          v-bind="field.props"
          :label="field.label"
        />
      </template>

      <div class="col-auto row q-col-gutter-sm">
        <q-btn color="primary" @click="handleSearch" v-permit="'select'">查询</q-btn>
        <q-btn color="positive" @click="showAddDialog" v-permit="'add'">新增</q-btn>
        <q-btn color="negative" @click="handleBatchDelete" v-permit="'delete'">删除</q-btn>
      </div>
    </div>

    <!-- 数据表格 -->
    <q-table
      :rows="tableData"
      :columns="columns"
      :loading="loading"
      :selection="config.tableConfig.selection"
      v-model:selected="selectedRows"
      @update:selected="selected"
      v-model:pagination="pagination"
      @request="onTableChange"
    >
      <!-- 仅当父组件提供对应插槽时才生成该列的插槽 -->
      <template v-slot:body-cell="props">
        <template v-if="$slots[`body-cell-${props.col.name}`]">
          <q-td :props="props"> <slot :name="`body-cell-${props.col.name}`" v-bind="props" /></q-td>
        </template>
        <template v-else>
          <q-td :props="props"> {{ props.row[props.col.name] }} </q-td>
        </template>
      </template>

      <!-- 操作列插槽 -->
      <template #body-cell-actions="props">
        <slot name="body-cell-actions" v-bind="props">
          <q-td :props="props">
            <q-btn-group flat>
              <q-btn
                icon="visibility"
                dense
                @click="handleView(props.row)"
                v-permit="route.path + ':view'"
              />
              <q-btn
                icon="edit"
                dense
                @click="showEditDialog(props.row)"
                v-permit="route.path + ':edit'"
              />
              <q-btn
                icon="delete"
                dense
                @click="handleDelete(props.row[config.tableConfig.rowKey])"
                v-permit="route.path + ':delete'"
              />
              <!-- 扩展插槽（允许父组件在此位置添加更多按钮） -->
              <slot name="actions-append" v-bind="props"></slot>
            </q-btn-group>
          </q-td>
        </slot>
      </template>
    </q-table>

    <!-- 表单弹窗 -->
    <q-dialog v-model="formDialogVisible" persistent>
      <q-card style="min-width: 500px">
        <header>
          <slot name="form-header" :title="dialogTitle">
            <q-card-section>
              <div class="text-h6">{{ dialogTitle }}</div>
            </q-card-section>
          </slot>
        </header>
        <main>
          <q-card-section>
            <q-form ref="quasarForm">
              <slot name="form-body" :formData="formData">
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
                      :readonly="viewDialogVisible"
                      v-on="extractListeners(field.props)"
                    />
                  </template>
                </div>
              </slot>
            </q-form>
          </q-card-section>
        </main>
        <footer>
          <slot name="form-footer">
            <q-card-actions align="right">
              <q-btn
                label="取消"
                type="reset"
                color="primary"
                flat
                class="q-ml-sm"
                @click="onReset"
              />
              <q-btn label="提交" type="submit" color="primary" @click="submitForm" />
            </q-card-actions>
          </slot>
        </footer>
      </q-card>
    </q-dialog>
  </div>
</template>

<script setup>
import { ref, reactive, computed, useTemplateRef } from 'vue'
import { useRoute } from 'vue-router'
import { useQuasar, QInput, QSelect, QBtnToggle } from 'quasar'
import * as PrimeVue from 'primevue'
import ResponsibleSelect from './ResponsibleSelect.vue'
import HierarchyScopeEquipmentLevel from './HierarchyScopeEquipmentLevel.vue'
import OrgSelect from './OrgSelect.vue'
import TeamSelect from './TeamSelect.vue'
import PositionSelect from './PositionSelect.vue'
import EnterpriseSelect from './EnterpriseSelect.vue'
const route = useRoute()

const quasarForm = useTemplateRef('quasarForm')

const getComponentType = (type) => {
  const componentMap = {
    'q-input': QInput,
    'q-select': QSelect,
    'q-btn-toggle': QBtnToggle,
    ResponsibleSelect: ResponsibleSelect,
    HierarchyScopeEquipmentLevel: HierarchyScopeEquipmentLevel,
    OrgSelect: OrgSelect,
    TeamSelect: TeamSelect,
    PositionSelect: PositionSelect,
    EnterpriseSelect: EnterpriseSelect,
  }
  return componentMap[type] || PrimeVue[type] || type
}
const props = defineProps({
  config: {
    type: Object,
    required: true,
    validator: (value) => {
      return ['queryFields', 'formFields', 'tableConfig'].every((key) => key in value)
    },
  },
  search: Function,
  create: Function,
  update: Function,
  delete: Function,
  batchDelete: Function,
  selected: Function,
})

// 移除原有的axios相关代码
// 保持表格数据相关状态
const selectedRows = ref([])
const tableData = defineModel('tableData', { default: [] })
const pagination = defineModel('pagination', {
  default: {
    page: 1,
    rowsPerPage: 10,
    rowsNumber: 0,
  },
})
const loading = ref(false)
// 表单数据
const formData = reactive({})
const formDialogVisible = ref(false)
const viewDialogVisible = ref(false)
const currentEditId = ref(null)
const dialogTitle = computed(() =>
  currentEditId.value ? (viewDialogVisible.value ? '查看' : '编辑') : '新增',
)
const extractListeners = (props) => {
  const listeners = {}
  for (const key in props) {
    if (key.startsWith('on') && typeof props[key] === 'function') {
      // 示例：提取事件名（onFilter => filter）
      const eventName = key.slice(2).toLowerCase()
      listeners[eventName] = props[key]
    }
  }
  return listeners
}

const showAddDialog = () => {
  formDialogVisible.value = true
}
const showEditDialog = (row) => {
  currentEditId.value = row[props.config.tableConfig.rowKey]
  Object.assign(formData, row)
  showAddDialog()
}
const handleView = (row) => {
  Object.assign(formData, row)
  formDialogVisible.value = true
  viewDialogVisible.value = true
}
const handleSearch = async () => {
  await fetchData()
}
// 修改后的获取数据方法
const fetchData = async () => {
  try {
    loading.value = true
    const params = {
      ...queryParams,
      page: pagination.value.page,
      pageSize: pagination.value.rowsPerPage,
    }

    // 触发搜索事件并等待父组件处理
    if (props.search) await props.search(params)
    loading.value = false
  } catch (error) {
    handleError(error)
  }
}

// 修改后的表单提交方法
const submitForm = async () => {
  try {
    const payload = { ...formData }
    quasarForm.value.validate().then(async (res) => {
      console.log('rrr')
      console.log(res)
      if (!res) return
      // 根据编辑/新增状态触发不同事件
      currentEditId.value ? await props.update(payload) : await props.create(payload)
      onReset()
      await fetchData()
    })
  } catch (error) {
    handleError(error)
  }
}

const onReset = () => {
  // 清空表单数据（保留响应式）
  Object.keys(formData).forEach((key) => delete formData[key])
  // 重置编辑状态
  currentEditId.value = null
  // 关闭对话框
  formDialogVisible.value = false
  viewDialogVisible.value = false
}

// 删除处理
const handleDelete = async (id) => {
  try {
    await props.delete(id)
    await fetchData()
  } catch (error) {
    handleError(error)
  }
}

// 批量删除处理
const handleBatchDelete = async () => {
  if (selectedRows.value.length === 0) {
    showNotify('warning', '请选择要删除的记录')
    return
  }

  try {
    const ids = selectedRows.value.map((item) => item[props.config.tableConfig.rowKey])
    await props.batchDelete(ids)
    selectedRows.value = []
    await fetchData()
  } catch (error) {
    handleError(error)
  }
}
const $q = useQuasar()
// 查询参数
const queryParams = reactive({})
const initQueryParams = () => {
  if (props.config.queryFields)
    Object.keys(props.config.queryFields).forEach((key) => {
      queryParams[key] = props.config.queryFields[key].defaultValue || null
    })
}
initQueryParams()

// 处理分页变化
const onTableChange = async (newPagination) => {
  Object.assign(pagination.value, newPagination.pagination)
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

// 初始化列配置
const columns = computed(() => [
  ...props.config.tableConfig.columns,
  {
    name: 'actions',
    label: '操作',
    align: 'center',
    sortable: false,
    classes: 'fixed-column',
  },
])

// 自动获取初始数据
fetchData()
</script>

<style scoped>
.fixed-column {
  position: sticky;
  right: 0;
  background: white;
  z-index: 1;
}
</style>
