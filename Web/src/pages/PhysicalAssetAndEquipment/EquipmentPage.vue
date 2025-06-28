<template>
  <q-page padding>
    <form-table
      :config="equipment_config"
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
import { useEquipmentStore } from 'src/stores/equipment'

const equipment_config = {
  queryFields: {
    id: {
      type: 'q-input',
      label: '设备编号',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    name: {
      type: 'q-input',
      label: '名称',
      props: {
        outlined: true,
        clearable: true,
      },
    },
    equipmentLevel: {
      type: 'HierarchyScopeEquipmentLevel',
      label: '设备层级',
      props: {
        clearable: true,
      },
    },
    hierarchyScopeRelDtId: {
      type: 'OrgSelect',
      label: '层次范围',
      props: {
        clearable: true,
      },
    },
    definedByDtId: {
      type: 'EquipmentClassSelect',
      label: '类型',
      props: {
        clearable: true,
      },
    },
    status: {
      type: 'EquipmentStatusSelect',
      label: '状态',
      props: {
        clearable: true,
      },
    },
  },
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'id', align: 'left', label: '设备编号', field: 'id', sortable: true },
      { name: 'name', align: 'left', label: '名称', field: 'name', sortable: true },
      {
        name: 'equipmentLevel',
        align: 'left',
        label: '设备层级',
        field: 'equipmentLevel',
        sortable: true,
      },
      {
        name: 'definedByName',
        align: 'left',
        label: '所属设备类型',
        field: 'definedByName',
      },
      {
        name: 'hierarchyScope',
        align: 'left',
        label: '层次范围',
        field: 'hierarchyScope',
        sortable: true,
      },
      {
        name: 'responsibleName',
        align: 'center',
        label: '负责人',
        field: 'responsibleName',
      },
      {
        name: 'status',
        align: 'center',
        label: '状态',
        field: 'status',
      },
      {
        name: 'enabledTime',
        align: 'center',
        label: '启用时间',
        field: 'enabledTime',
      },
      {
        name: 'supplier',
        align: 'left',
        label: '供应商',
        field: 'supplier',
      },
      {
        name: 'specification',
        align: 'center',
        label: '规格',
        field: 'specification',
      },
      {
        name: 'factoryNumber',
        align: 'center',
        label: '出厂编号',
        field: 'factoryNumber',
      },
      { name: 'description', align: 'left', label: '说明', field: 'description', sortable: true },
    ],
  },
  formFields: {
    dtId: {
      show: false,
      type: 'q-input',
    },
    id: {
      type: 'q-input',
      label: '设备编号',
      rules: [(val) => !!val || '必填字段'],
    },
    name: {
      type: 'q-input',
      label: '名称*',
      rules: [(val) => !!val || '必填字段'],
    },
    description: {
      type: 'q-input',
      label: '说明',
      props: {
        filled: true,
        autogrow: true,
      },
    },
    equipmentLevel: {
      type: 'HierarchyScopeEquipmentLevel',
      label: '设备层级',
    },
    definedByDtId: {
      type: 'EquipmentClassSelect',
      lable: '所属设备类',
      props: {
        multiple: true,
        useChips: true,
        stackLabel: true,
      },
    },
    hierarchyScopeRelDtId: {
      type: 'OrgSelect',
      label: '层次范围',
      props: {
        clearable: true,
      },
    },
    responsibleDtId: {
      type: 'ResponsibleSelect',
      label: '责任人',
      props: {
        clearable: true,
      },
    },
    status: {
      type: 'EquipmentStatusSelect',
      label: '状态',
    },
    supplier: {
      type: 'q-input',
      label: '供应商',
    },
    specification: {
      type: 'q-input',
      label: '规格',
    },
    factoryNumber: {
      type: 'q-input',
      label: '出厂编号',
    },
  },
}
const pagination = ref({
  page: 1,
  rowsPerPage: 10,
  rowsNumber: 0,
})
const tableData = ref([])

const equipmentStore = useEquipmentStore()
const handleSearch = async (queryParams) => {
  const response = await equipmentStore.GetPaged(queryParams)
  tableData.value = response.data
  pagination.value.rowsNumber = response.totalItems
}
const handleCreate = async (payload) => {
  await equipmentStore.Add(payload)
}
const handleUpdate = async (payload) => {
  await equipmentStore.Update(payload)
}
const handleBatchDelete = async (dtIds) => {
  await batchDelete(dtIds)
}
const handleDelete = async (dtId) => {
  await batchDelete([dtId])
}
const batchDelete = async (dtIds) => {
  await equipmentStore.Delete(dtIds)
}
</script>
