<template>
  <div class="q-pa-md">
    <!-- 查询条件区域 -->
    <div
      class="row q-col-gutter-md q-mb-md"
      style="display: grid; grid-template-columns: repeat(auto-fill, minmax(300px, 1fr)); gap: 16px"
    >
      <template v-for="(field, name) in config.queryFields || {}" :key="name">
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
        <q-btn
          color="positive"
          @click="showAddDialog"
          v-permit="'add'"
          v-if="config.tableConfig.add == undefined || config.tableConfig.add === true"
          >新增</q-btn
        >
        <q-btn
          color="negative"
          @click="handleBatchDelete"
          v-permit="'delete'"
          v-if="config.tableConfig.delete == undefined || config.tableConfig.delete === true"
          >删除</q-btn
        >
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
      :row-key="config.tableConfig.rowKey"
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
                v-if="config.tableConfig.view == undefined || config.tableConfig.view === true"
              />
              <q-btn
                icon="edit"
                dense
                @click="showEditDialog(props.row)"
                v-permit="route.path + ':edit'"
                v-if="config.tableConfig.edit == undefined || config.tableConfig.edit === true"
              />
              <q-btn
                v-if="config.tableConfig.delete == undefined || config.tableConfig.delete === true"
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
    <q-dialog
      v-model="formDialogVisible"
      persistent
      backdrop-filter="brightness(60%)"
      :maximized="maximizedToggle"
      transition-show="slide-up"
      transition-hide="slide-down"
    >
      <q-card style="min-width: 500px">
        <q-bar>
          <q-space />
          <q-btn
            dense
            flat
            icon="minimize"
            @click="maximizedToggle = false"
            :disable="!maximizedToggle"
          >
            <q-tooltip v-if="maximizedToggle" class="bg-white text-primary">Minimize</q-tooltip>
          </q-btn>
          <q-btn
            dense
            flat
            icon="crop_square"
            @click="maximizedToggle = true"
            :disable="maximizedToggle"
          >
            <q-tooltip v-if="!maximizedToggle" class="bg-white text-primary">Maximize</q-tooltip>
          </q-btn>
          <q-btn dense flat icon="close" v-close-popup>
            <q-tooltip class="bg-white text-primary">Close</q-tooltip>
          </q-btn>
        </q-bar>
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
              <slot name="form-body" :formData="formData" :readonly="viewDialogVisible">
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
                    >
                      <template
                        v-for="(slotConfig, slotName) in field.slots || {}"
                        :key="slotName"
                        #[slotName]
                      >
                        <SlotRenderer :config="slotConfig" />
                      </template>
                    </component>
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
                @click="closeDialog"
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
import { ref, reactive, computed, useTemplateRef, defineComponent, h } from 'vue'
import { useRoute } from 'vue-router'
import { useQuasar } from 'quasar'
import * as Quasar from 'quasar'
import * as PrimeVue from 'primevue'

const route = useRoute()
const maximizedToggle = ref(false)
const quasarForm = useTemplateRef('quasarForm')

// 插槽渲染器组件
const SlotRenderer = defineComponent({
  name: 'SlotRenderer',
  props: {
    config: {
      type: Object,
      required: true,
    },
  },
  setup(props) {
    return () => {
      const { config } = props

      if (config.component) {
        // 如果直接指定了组件
        return h(config.component, config.props || {}, config.content)
      }

      if (config.template) {
        // 解析模板字符串
        const parsed = parseTemplate(config.template)
        if (parsed) {
          return h(parsed.component, parsed.props, {
            default: () => parsed.content,
          })
        }
      }

      return null
    }
  },
})
// 模板解析函数
const parseTemplate = (template) => {
  // 匹配组件标签和内容
  const match = template.match(/<([\w-]+)([^>]*)>(.*?)<\/\1>/s)
  if (match) {
    const [, componentName, attrsString, content] = match

    // 解析属性
    const props = {}
    if (attrsString) {
      const attrMatches = attrsString.match(/(\w+)="([^"]*)"/g)
      if (attrMatches) {
        attrMatches.forEach((attr) => {
          const [, key, value] = attr.match(/(\w+)="([^"]*)"/)
          props[key] = value
        })
      }
    }

    const component = getComponentType(componentName) || componentName

    return {
      component,
      props,
      content: content.trim(),
    }
  }

  return null
}

const toPascalCase = (str) => {
  return str
    .split('-')
    .map((s) => s.charAt(0).toUpperCase() + s.slice(1))
    .join('')
}

const getComponentType = (type) => {
  const componentMap = toPascalCase(type)
  return Quasar[componentMap] || PrimeVue[componentMap] || window[type] || type
}
const props = defineProps({
  config: {
    type: Object,
    required: true,
    validator: (value) => {
      const allowedKeys = ['queryFields', 'formFields', 'tableConfig']
      return Object.keys(value).every((key) => allowedKeys.includes(key))
    },
  },
  search: Function,
  create: Function,
  update: Function,
  delete: Function,
  batchDelete: Function,
  selected: Function,
  showAddDialogBefore: Function,
  showEditDialogBefore: Function,
  hideDialog: Function,
})

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
const formData = reactive({})
const formDialogVisible = ref(false)
const viewDialogVisible = ref(false)
const currentEditId = ref(null)
const dialogTitle = computed(() =>
  currentEditId.value ? (viewDialogVisible.value ? '查看' : '编辑') : '新增',
)

const extractListeners = (props) => {
  const listeners = {}
  if (!props) return listeners

  for (const key in props) {
    if (key.startsWith('on') && typeof props[key] === 'function') {
      const eventName = key.slice(2).toLowerCase()
      listeners[eventName] = props[key]
    }
  }
  return listeners
}

const showAddDialog = async () => {
  // 先清空 formData，确保是干净的状态
  Object.keys(formData).forEach((key) => delete formData[key])

  if (props.showAddDialogBefore) await props.showAddDialogBefore(formData)

  // 通用初始化逻辑
  if (props.config.formFields) {
    Object.keys(props.config.formFields).forEach((name) => {
      const field = props.config.formFields[name]
      // 仅设置默认值
      if (formData[name] === undefined && field.defaultValue !== undefined) {
        formData[name] = field.defaultValue
      }
    })
  }

  formDialogVisible.value = true
  viewDialogVisible.value = false
}

const showEditDialog = async (row) => {
  Object.keys(formData).forEach((key) => delete formData[key])

  if (props.showEditDialogBefore) await props.showEditDialogBefore(row)
  currentEditId.value = row[props.config.tableConfig.rowKey]
  Object.assign(formData, row)

  formDialogVisible.value = true
  viewDialogVisible.value = false
}

const handleView = (row) => {
  Object.assign(formData, row)
  formDialogVisible.value = true
  viewDialogVisible.value = true
}

const handleSearch = async () => {
  await fetchData()
}

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

const submitForm = async () => {
  try {
    const valid = await quasarForm.value.validate()
    if (!valid) return

    // 触发父组件事件
    const payload = { ...formData }
    currentEditId.value ? await props.update(payload) : await props.create(payload)

    await closeDialog()
    await fetchData()
  } catch (error) {
    handleError(error)
  }
}

const closeDialog = async () => {
  onReset()
  // 关闭对话框
  formDialogVisible.value = false
  viewDialogVisible.value = false
  // 触发父组件的清理回调
  if (props.hideDialog) await props.hideDialog()
}

const onReset = async () => {
  Object.keys(formData).forEach((key) => delete formData[key])
  // 重置编辑状态
  currentEditId.value = null
}

const handleDelete = async (id) => {
  try {
    await props.delete(id)
    await fetchData()
  } catch (error) {
    handleError(error)
  }
}

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
const queryParams = reactive({})

const initQueryParams = () => {
  if (props.config.queryFields)
    Object.keys(props.config.queryFields).forEach((key) => {
      queryParams[key] = props.config.queryFields[key].defaultValue || null
    })
}
initQueryParams()

const onTableChange = async (newPagination) => {
  Object.assign(pagination.value, newPagination.pagination)
  await fetchData()
}

const handleError = (error) => {
  const message = error.response?.data?.message || '请求失败'
  showNotify('negative', message)
}

const showNotify = (type, message) => {
  $q.notify({ type, message })
}

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
