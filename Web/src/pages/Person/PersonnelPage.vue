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
      <template v-slot:body-cell-workStatus="{ row }">
        <template v-if="row.workStatus == 'Employed'">
          <div>
            <q-badge color="purple" label="在职" />
          </div>
        </template>
        <template v-else-if="row.workStatus == 'Vacation'">
          <div>
            <q-badge color="purple" label="休假" />
          </div>
        </template>
        <template v-if="row.workStatus == 'Dimission'">
          <div>
            <q-badge color="purple" label="离职" />
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
import { usePersonStore } from 'src/stores/person'
const personStore = usePersonStore()

const oldSelectIds = ref([])

const permissionDialogVisible = ref(false)
const orgSettingPermission = async (ids) => {
  await personStore.SettingPermission({
    menuButtonIds: ids,
    oldMenuButtonIds: oldSelectIds.value,
    owner: settingPersonnelDtId.value,
  })
  permissionDialogVisible.value = false
  await handleSearch({ page: pagination.value.page, pageSize: pagination.value.rowsPerPage })
}
const settingPersonnelDtId = ref(null)
const openPermissionDialog = async (row) => {
  settingPersonnelDtId.value = row.dtId
  oldSelectIds.value = row.permissions
  permissionDialogVisible.value = true
}

const table_Config = {
  queryFields: {
    id: {
      type: 'q-input',
      label: '工号',
      props: {
        outlined: true,
      },
    },
    name: {
      type: 'q-input',
      label: '姓名',
      props: {
        outlined: true,
      },
    },
    workStatus: {
      type: 'q-select',
      label: '状态',
      props: {
        outlined: true,
        clearable: true,
        options: [
          {
            label: '在职',
            value: 'Employed',
          },
          {
            label: '休假',
            value: 'Vacation',
          },
          {
            label: '离职',
            value: 'Dimission',
          },
        ],
        'option-value': 'value',
        'option-label': 'label',
        'emit-value': true,
        'map-options': true,
      },
    },
    email: {
      type: 'q-input',
      label: '邮箱',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    phoneNumber: {
      type: 'q-input',
      label: '手机号',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    teamOfGroupDtId: {
      type: 'TeamSelect',
      label: '班组',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    positionDtId: {
      type: 'PositionSelect',
      label: '职位',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    orgDtId: {
      type: 'OrgSelect',
      label: '组织',
      props: {
        outlined: true,
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
      label: '工号',
      props: {
        outlined: true,
      },
      rules: [(val) => !!val || '必填字段'],
    },
    name: {
      type: 'q-input',
      label: '姓名',
      props: {
        outlined: true,
      },
      rules: [(val) => !!val || '必填字段'],
    },
    workStatus: {
      type: 'q-select',
      label: '状态',
      props: {
        outlined: true,
        clearable: true,
        options: [
          {
            label: '在职',
            value: 'Employed',
          },
          {
            label: '休假',
            value: 'Vacation',
          },
          {
            label: '离职',
            value: 'Dimission',
          },
        ],
        'option-value': 'value',
        'option-label': 'label',
        'emit-value': true,
        'map-options': true,
      },
      defaultValue: {
        label: '在职',
        value: 'Employed',
      },
      rules: [(val) => !!val || '必填字段'],
    },
    email: {
      type: 'q-input',
      label: '邮箱',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    phoneNumber: {
      type: 'q-input',
      label: '手机号',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    teamDtId: {
      type: 'TeamSelect',
      label: '班组',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    positionDtId_List: {
      type: 'PositionSelect',
      label: '职位',
      props: {
        outlined: true,
        clearable: true,
        multiple: true,
      },
      rules: [(val) => !!val || '必填字段'],
    },
    orgDtId: {
      type: 'OrgSelect',
      label: '组织',
      props: {
        outlined: true,
        clearable: true,
      },
      rules: [(val) => !!val || '必填字段'],
    },
  },
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'id', label: '工号', field: 'id' },
      { name: 'name', label: '姓名', field: 'name' },
      { name: 'workStatus', label: '状态', field: 'workStatus' },
      { name: 'email', label: '邮箱', field: 'email' },
      { name: 'phoneNumber', label: '手机号', field: 'phoneNumber' },
      { name: 'orgName', label: '组织', field: 'orgName' },
      { name: 'teamName', label: '班组', field: 'teamName' },
      { name: 'position', label: '职位', field: 'position' },
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
  const response = await personStore.GetPaged(queryParams)
  tableData.value = response
  pagination.value.rowsNumber = response.totalItems
}
const handleCreate = async (payload) => {
  await personStore.Add(payload)
}
const handleUpdate = async (payload) => {
  await personStore.Update(payload)
}
const handleBatchDelete = async (dtIds) => {
  await batchDelete(dtIds)
}
const handleDelete = async (dtId) => {
  await batchDelete([dtId])
}
const batchDelete = async (dtIds) => {
  await personStore.Delete(dtIds)
}
</script>
