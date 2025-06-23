<template>
  <q-page padding>
    <form-table
      :config="equipmentClass_config"
      v-model:tableData="tableData"
      v-model:pagination="pagination"
      :search="handleSearch"
      :create="handleCreate"
      :update="handleUpdate"
      :batchDelete="handleBatchDelete"
      :delete="handleDelete"
    >
    </form-table>
  </q-page>
</template>

<script setup>
import { ref } from 'vue'
import { usePhysicalAssetAndEquipmentStore } from 'src/stores/physicalAssetAndEquipmentStore'

const equipmentClass_config = {
  queryFields: {
    name: {
      type: 'q-input',
      label: '名称',
      props: {
        outlined: true,
      },
    },
    description: {
      type: 'q-input',
      label: '描述',
      props: {
        outlined: true,
      },
    },
    equipmentLevel: {
      type: 'HierarchyScopeEquipmentLevel',
      label: '设备层级',
    },
    sourceDtId: {
      type: 'OrgSelect',
      label: '层次范围',
      props: {
        clearable: true,
      },
    },
  },
  tableConfig: {
    rowKey: 'dtId',
    delete: false,
    selection: 'multiple',
    columns: [
      { name: 'id', align: 'left', label: '序号', field: 'id', sortable: true },
      { name: 'name', align: 'left', label: '类型', field: 'name', sortable: true },
      { name: 'description', align: 'left', label: '说明', field: 'description', sortable: true },
      {
        name: 'equipmentLevel',
        align: 'left',
        label: '设备层级',
        field: 'equipmentLevel',
        sortable: true,
      },
      {
        name: 'hierarchyScope',
        align: 'left',
        label: '层次范围',
        field: 'hierarchyScope',
        sortable: true,
      },
    ],
  },
  formFields: {
    dtId: {
      show: false,
      type: 'q-input',
    },
    name: {
      type: 'q-input',
      label: '类型*',
      rules: [(val) => !!val || '必填字段'],
    },
    description: {
      type: 'q-input',
      label: '说明',
      props: {
        type: 'textarea',
      },
    },
    equipmentLevel: {
      type: 'HierarchyScopeEquipmentLevel',
      label: '设备层级',
    },
    sourceDtId: {
      type: 'OrgSelect',
      label: '层次范围',
      props: {
        clearable: true,
      },
    },
  },
}
const pagination = ref({
  page: 1,
  rowsPerPage: 10,
  rowsNumber: 0,
})
const tableData = ref([])

const physicalAssetAndEquipmentStore = usePhysicalAssetAndEquipmentStore()
const handleSearch = async (queryParams) => {
  const response = await physicalAssetAndEquipmentStore.GetPagedEquipmentClass(queryParams)
  console.log('search')
  tableData.value = response.data
  pagination.value.rowsNumber = response.totalItems
}
const handleCreate = async (payload) => {
  await physicalAssetAndEquipmentStore.AddEquipmentClass(payload)
}
const handleUpdate = async (payload) => {
  await physicalAssetAndEquipmentStore.UpdateEquipmentClass(payload)
}
const handleBatchDelete = async (dtIds) => {
  await batchDelete(dtIds)
}
const handleDelete = async (dtId) => {
  await batchDelete([dtId])
}
const batchDelete = async (dtIds) => {
  await physicalAssetAndEquipmentStore.DeleteEquipmentClass(dtIds)
}
</script>
