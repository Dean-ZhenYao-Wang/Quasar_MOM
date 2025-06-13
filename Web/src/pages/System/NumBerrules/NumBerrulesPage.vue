<template>
  <q-page padding>
    <form-table
      :config="table_Config"
      v-model:tableData="tableData"
      v-model:pagination="pagination"
      :search="handleSearch"
      :create="handleCreate"
      :update="handleUpdate"
      :batchDelete="handleBatchDelete"
      :delete="handleDelete"
    >
      <template #from>
        <q-input
          v-model="formData.ruleCode"
          label="规则编码 *"
          :rules="[(val) => !!val || '请输入规则编码']"
          :disable="isEdit"
        />

        <q-input
          v-model="formData.ruleName"
          label="规则名称 *"
          :rules="[(val) => !!val || '请输入规则名称']"
        />

        <q-input v-model="formData.description" label="描述" type="textarea" rows="2" />

        <q-input
          v-model="formData.prefix"
          label="前缀模板 *"
          :rules="[(val) => !!val || '请输入前缀模板']"
          hint="支持变量: {YYYY}, {YY}, {MM}, {DD}, {HH}, {mm}"
        />

        <div class="row q-gutter-md">
          <q-input
            v-model.number="formData.sequenceLength"
            label="序号长度"
            type="number"
            min="1"
            max="10"
            class="col"
          />

          <q-input
            v-model.number="formData.startSequence"
            label="起始序号"
            type="number"
            min="0"
            class="col"
          />

          <q-input
            v-model.number="formData.maxSequence"
            label="最大序号"
            type="number"
            min="1"
            class="col"
          />
        </div>

        <q-select
          v-model="formData.resetType"
          :options="resetTypeOptions"
          label="重置类型"
          emit-value
          map-options
        />

        <q-toggle v-model="formData.isActive" label="是否启用" color="positive" />

        <!-- 预览区域 -->
        <q-separator />
        <div class="text-subtitle2 q-mt-md">编号预览:</div>
        <q-card flat bordered class="q-pa-sm bg-grey-1">
          <div class="text-body2">{{ previewNumber }}</div>
        </q-card>
      </template>
      <template #actions-append="{ row }">
        <q-btn
          label="配置权限"
          @click="() => openPermissionDialog(row)"
          dense
          v-permit="orgPermission"
        />
      </template>
    </form-table>
    <!-- 测试生成对话框 -->
    <!-- <q-dialog v-model="showTestDialog">
      <q-card style="min-width: 400px">
        <q-card-section>
          <div class="text-h6">测试生成编号</div>
        </q-card-section>

        <q-card-section>
          <div class="text-body1">规则: {{ testRule?.ruleName }}</div>
          <q-input v-model="testBusinessKey" label="业务关键字 (可选)" class="q-mt-md" />
        </q-card-section>

        <q-card-actions align="right">
          <q-btn flat label="取消" @click="showTestDialog = false" />
          <q-btn color="primary" label="生成" @click="generateTestNumber" />
        </q-card-actions>
      </q-card>
    </q-dialog> -->
  </q-page>
</template>

<script setup>
import { ref } from 'vue'
import { useHierarchyScopeStore } from 'src/stores/hierarchyScope'
const orgStore = useHierarchyScopeStore()

// 表单数据
const formData = ref({
  id: null,
  ruleCode: '',
  ruleName: '',
  description: '',
  prefix: '',
  sequenceLength: 4,
  startSequence: 1,
  maxSequence: 9999,
  currentSequence: 0,
  resetType: 0,
  isActive: true,
})

const table_Config = {
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'ruleCode', align: 'left', label: '规则编码', field: 'ruleCode', sortable: true },
      { name: 'ruleName', align: 'left', label: '规则名称', field: 'ruleName', sortable: true },
      { name: 'prefix', align: 'left', label: '前缀模板', field: 'prefix' },
      { name: 'sequenceLength', align: 'center', label: '序号长度', field: 'sequenceLength' },
      { name: 'currentSequence', align: 'center', label: '当前序号', field: 'currentSequence' },
      { name: 'resetType', align: 'center', label: '重置类型', field: 'resetType' },
      { name: 'isActive', align: 'center', label: '状态', field: 'isActive' },
      { name: 'actions', align: 'center', label: '操作', field: 'actions' },
    ],
  },
}

// 重置类型选项
const resetTypeOptions = [
  { label: '不重置', value: 0 },
  { label: '每日重置', value: 1 },
  { label: '每月重置', value: 2 },
  { label: '每年重置', value: 3 },
]

const tableData = ref([])
const pagination = ref({
  page: 1,
  rowsPerPage: 10,
  rowsNumber: 0,
})
const handleSearch = async (queryParams) => {
  const response = await orgStore.getOrgTable(queryParams)
  tableData.value = response.data
  pagination.value.rowsNumber = response.totalItems
}
const handleCreate = async (payload) => {
  await orgStore.AddHierarchyScope(payload)
}
const handleUpdate = async (payload) => {
  await orgStore.UpdateHierarchyScope(payload)
}
const handleBatchDelete = async (dtIds) => {
  await batchDelete(dtIds)
}
const handleDelete = async (dtId) => {
  await batchDelete([dtId])
}
const batchDelete = async (dtIds) => {
  await orgStore.DeleteHierarchyScope(dtIds)
}
</script>
