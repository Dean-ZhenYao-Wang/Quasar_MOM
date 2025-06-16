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
      <template #form-header="dialogTitle">
        <q-card-section>
          <div class="text-h6">{{ dialogTitle }}编码规则</div>
        </q-card-section>
      </template>
      <template #form-body="formData">
        <div class="row q-col-gutter-md">
          <q-input label="规则编码" v-model="formData.Id" />
          <q-input label="规则名称" v-model="formData.Name" />
          <q-input label="描述" v-model="formData.Description" />
          <q-select
            label="规则编码适用于"
            v-model="formData.ModelTypeName"
            :options="modelTypeNameOptions"
          ></q-select>
          <q-input label="分隔符" v-model="formData.Separator" />
          <q-toggle label="是否激活" v-model="formData.IsActive" />
        </div>
        <!-- 规则段区域 -->
        <q-separator />
        规则段1 规则段2
        <!-- 预览区域 -->
        <q-separator />
        <div class="text-subtitle2 q-mt-md">编号预览:</div>
        <q-card flat bordered class="q-pa-sm bg-grey-1">
          <div class="text-body2">previewNumber</div>
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

const table_Config = {
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'Id', align: 'left', label: '规则编码', field: 'Id', sortable: true },
      { name: 'Name', align: 'left', label: '规则名称', field: 'Name', sortable: true },
      { name: 'Description', align: 'left', label: '描述', field: 'Description' },
      {
        name: 'ModelTypeName',
        align: 'left',
        label: '适用于',
        field: 'ModelTypeName',
      },
      { name: 'Separator', align: 'left', label: '分隔符', field: 'Separator' },
      { name: 'IsActive', align: 'left', label: '是否激活', field: 'IsActive' },
    ],
  },
}

const modelTypeNameOptions = ref([
  {
    label: '人员',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.Personnel.Person',
  },
  {
    label: '人员类',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass',
  },
  {
    label: '设备角色层次',
    value: 'MOM.Domain.isa95.CommonObjectModels.HierarchyScope',
  },
  {
    label: '设备',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment',
  },
  {
    label: '设备类',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass',
  },
  {
    label: '资产',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset',
  },
  {
    label: '资产类',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass',
  },
])

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
