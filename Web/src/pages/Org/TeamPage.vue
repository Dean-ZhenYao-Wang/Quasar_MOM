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
import { useTeamStore } from 'src/stores/team'
const teamStore = useTeamStore()

const oldSelectIds = ref([])

const permissionDialogVisible = ref(false)
const orgSettingPermission = async (ids) => {
  await teamStore.SettingPermission({ menuButtonIds: ids, owner: settingPositionDtId.value })
  permissionDialogVisible.value = false
  await handleSearch({ page: pagination.value.page, pageSize: pagination.value.rowsPerPage })
}
const settingPositionDtId = ref(null)
const openPermissionDialog = async (row) => {
  settingPositionDtId.value = row.dtId
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
    sourceDtId: {
      type: 'TeamSelect',
      label: '所属班组',
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
      label: '名称',
      rules: [(val) => !!val || '必填字段'],
    },
    responsibleDtId: {
      type: 'ResponsibleSelect',
      label: '负责人',
      props: {
        clearable: true,
      },
      rules: [(val) => !!val || '必填字段'],
    },
    sourceDtId: {
      type: 'TeamSelect',
      label: '所属班组',
      props: {
        clearable: true,
      },
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
      { name: 'responsibleName', label: '负责人', field: 'responsibleName' },
      { name: 'sourceName', label: '所属班组', field: 'sourceName' },
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
  const response = await teamStore.GetPaged(queryParams)
  tableData.value = response
  pagination.value.rowsNumber = response.totalItems
}
const handleCreate = async (payload) => {
  await teamStore.Add(payload)
}
const handleUpdate = async (payload) => {
  await teamStore.Update(payload)
}
const handleBatchDelete = async (dtIds) => {
  await batchDelete(dtIds)
}
const handleDelete = async (dtId) => {
  await batchDelete([dtId])
}
const batchDelete = async (dtIds) => {
  await teamStore.Delete(dtIds)
}
</script>
