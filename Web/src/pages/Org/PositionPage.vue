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
import { usePositionStore } from 'src/stores/position'
const positionStore = usePositionStore()

const oldSelectIds = ref([])

const permissionDialogVisible = ref(false)
const orgSettingPermission = async (ids) => {
  await positionStore.SettingPermission({ menuButtonIds: ids, owner: settingPositionDtId.value })
  permissionDialogVisible.value = false
}
const settingPositionDtId = ref(null)
const openPermissionDialog = async (row) => {
  settingPositionDtId.value = row.dtId
  //let response = await positionStore.Permission(row.dtId)
  oldSelectIds.value = row.permissions
  permissionDialogVisible.value = true
}

const table_Config = {
  queryFields: {
    id: {
      type: 'q-input',
      label: '名称',
      props: {
        outlined: true,
      },
    },
    remark: {
      type: 'q-input',
      label: '备注',
      props: {
        outlined: true,
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
      label: '名称',
      rules: [(val) => !!val || '必填字段'],
    },
    remark: {
      type: 'q-input',
      label: '备注',
    },
  },
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'id', label: '名称', field: 'id' },
      { name: 'remark', label: '备注', field: 'remark' },
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
  const response = await positionStore.GetPaged(queryParams)
  tableData.value = response.data
  pagination.value.rowsNumber = response.totalItems
}
const handleCreate = async (payload) => {
  await positionStore.Add(payload)
}
const handleUpdate = async (payload) => {
  await positionStore.Update(payload)
}
const handleBatchDelete = async (dtIds) => {
  await batchDelete(dtIds)
}
const handleDelete = async (dtId) => {
  await batchDelete([dtId])
}
const batchDelete = async (dtIds) => {
  await positionStore.Delete(dtIds)
}
</script>
