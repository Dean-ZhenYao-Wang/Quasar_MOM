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
      <template v-slot:body-cell-equipmentLevel="{ row }">
        <template v-if="row.equipmentLevel == 'Enterprise'">
          <div>
            <q-badge color="purple" label="企业" />
          </div>
        </template>
        <template v-else-if="row.equipmentLevel == 'Site'">
          <div>
            <q-badge color="purple" label="工厂" />
          </div>
        </template>
        <template v-else-if="row.equipmentLevel == 'Area'">
          <div>
            <q-badge color="purple" label="车间/部门" />
          </div>
        </template>
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
    <permission-dialog
      v-model:dialogVisible="permissionDialogVisible"
      :oldSelectIds="oldSelectIds"
      :ok="orgSettingPermission"
    ></permission-dialog>
  </q-page>
</template>

<script setup>
import { ref } from 'vue'
import { useOrgStore } from 'src/stores/org'
const orgStore = useOrgStore()

const oldSelectIds = ref([])

const permissionDialogVisible = ref(false)
const orgSettingPermission = async (ids) => {
  await orgStore.SettingPermission({ menuButtonIds: ids, owner: settingOrgDtId.value })
  permissionDialogVisible.value = false
}
const settingOrgDtId = ref(null)
const openPermissionDialog = async (row) => {
  settingOrgDtId.value = row.dtId
  let response = await orgStore.Permission(row.dtId)
  oldSelectIds.value = response.data
  permissionDialogVisible.value = true
}

const table_Config = {
  queryFields: {
    id: {
      type: 'q-input',
      label: '编号',
      props: {
        outlined: true,
      },
    },
    name: {
      type: 'q-input',
      label: '名称',
      props: {
        outlined: true,
      },
    },
    sourceDtId: {
      type: 'OrgSelect',
      label: '所属组织',
      props: {
        clearable: true,
      },
    },
  },
  formFields: {
    dtId: {
      show: false,
      type: 'q-input',
      label: '数据库唯一标识',
    },
    id: {
      type: 'q-input',
      label: '编号',
      rules: [(val) => !!val || '必填字段'],
    },
    name: {
      type: 'q-input',
      label: '名称',
      rules: [(val) => !!val || '必填字段'],
    },
    equipmentLevel: {
      type: 'HierarchyScopeEquipmentLevel',
      label: '类型',
      rules: [(val) => !!val || '必填字段'],
    },
    address: {
      type: 'q-input',
      label: '地址',
    },
    responsibleDtId: {
      type: 'ResponsibleSelect',
      label: '负责人',
      props: {
        clearable: true,
      },
    },
    sourceDtId: {
      type: 'OrgSelect',
      label: '所属组织',
      props: {
        clearable: true,
      },
    },
    active: {
      type: 'q-btn-toggle',
      label: '是否启用',
      props: {
        class: 'my-custom-toggle',
        'no-caps': true,
        rounded: true,
        unelevated: true,
        'toggle-color': 'primary',
        color: 'white',
        'text-color': 'primary',
        options: [
          { label: '启用', value: true },
          { label: '停用', value: false },
        ],
        'option-value': 'value',
        'option-label': 'label',
        'emit-value': true,
        'map-options': true,
        // 'model-value': { label: '停用', value: false },
      },
      rules: [(val) => !!val || '必填字段'],
    },
    description: {
      type: 'q-input',
      label: '备注',
    },
  },
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'id', label: '编号', field: 'id' },
      { name: 'name', label: '名称', field: 'name' },
      { name: 'equipmentLevel', label: '类型', field: 'equipmentLevel' },
      { name: 'address', label: '地址', field: 'address' },
      { name: 'responsibleName', label: '负责人', field: 'responsibleName' },
      { name: 'description', label: '备注', field: 'description' },
      { name: 'sourceName', label: '所属组织', field: 'sourceName' },
      { name: 'fullPath', label: '路径', field: 'fullPath' },
    ],
  },
}

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
  await orgStore.AddOrg(payload)
}
const handleUpdate = async (payload) => {
  await orgStore.UpdateOrg(payload)
}
const handleBatchDelete = async (dtIds) => {
  await batchDelete(dtIds)
}
const handleDelete = async (dtId) => {
  await batchDelete([dtId])
}
const batchDelete = async (dtIds) => {
  await orgStore.DeleteOrg(dtIds)
}
</script>
