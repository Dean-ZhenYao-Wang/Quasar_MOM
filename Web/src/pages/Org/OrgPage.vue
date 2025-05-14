<template>
  <q-page padding>
    <form-table
      :config="table_Config"
      v-model:tableData="tableData"
      v-model:pagination="pagination"
      :search="handleSearch"
      :create="handleCreate"
      :batchDelete="handleBatchDelete"
      :delete="handleDelete"
    ></form-table>
  </q-page>
</template>

<script setup>
import { ref, onMounted, onBeforeMount } from 'vue'
import { useOrgStore } from 'src/stores/org'
const orgStore = useOrgStore()
const orgNodes = ref([])
onBeforeMount(async () => {
  orgNodes.value = await orgStore.getDepartTree()
})

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
        rules: [(val) => !!val || '必填字段'],
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
    ],
  },
}

const nodes = ref([])
onMounted(() => {
  nodes.value = [
    {
      key: '0',
      data: {
        name: 'Applications',
        size: '100kb',
        type: 'Folder',
      },
      children: [
        {
          key: '0-0',
          data: {
            name: 'Vue',
            size: '25kb',
            type: 'Folder',
          },
          children: [
            {
              key: '0-0-0',
              data: {
                name: 'vue.app',
                size: '10kb',
                type: 'Application',
              },
            },
            {
              key: '0-0-1',
              data: {
                name: 'native.app',
                size: '10kb',
                type: 'Application',
              },
            },
            {
              key: '0-0-2',
              data: {
                name: 'mobile.app',
                size: '5kb',
                type: 'Application',
              },
            },
          ],
        },
        {
          key: '0-1',
          data: {
            name: 'editor.app',
            size: '25kb',
            type: 'Application',
          },
        },
        {
          key: '0-2',
          data: {
            name: 'settings.app',
            size: '50kb',
            type: 'Application',
          },
        },
      ],
    },
    {
      key: '1',
      data: {
        name: 'Cloud',
        size: '20kb',
        type: 'Folder',
      },
      children: [
        {
          key: '1-0',
          data: {
            name: 'backup-1.zip',
            size: '10kb',
            type: 'Zip',
          },
        },
        {
          key: '1-1',
          data: {
            name: 'backup-2.zip',
            size: '10kb',
            type: 'Zip',
          },
        },
      ],
    },
    {
      key: '2',
      data: {
        name: 'Desktop',
        size: '150kb',
        type: 'Folder',
      },
      children: [
        {
          key: '2-0',
          data: {
            name: 'note-meeting.txt',
            size: '50kb',
            type: 'Text',
          },
        },
        {
          key: '2-1',
          data: {
            name: 'note-todo.txt',
            size: '100kb',
            type: 'Text',
          },
        },
      ],
    },
    {
      key: '3',
      data: {
        name: 'Documents',
        size: '75kb',
        type: 'Folder',
      },
      children: [
        {
          key: '3-0',
          data: {
            name: 'Work',
            size: '55kb',
            type: 'Folder',
          },
          children: [
            {
              key: '3-0-0',
              data: {
                name: 'Expenses.doc',
                size: '30kb',
                type: 'Document',
              },
            },
            {
              key: '3-0-1',
              data: {
                name: 'Resume.doc',
                size: '25kb',
                type: 'Resume',
              },
            },
          ],
        },
        {
          key: '3-1',
          data: {
            name: 'Home',
            size: '20kb',
            type: 'Folder',
          },
          children: [
            {
              key: '3-1-0',
              data: {
                name: 'Invoices',
                size: '20kb',
                type: 'Text',
              },
            },
          ],
        },
      ],
    },
    {
      key: '4',
      data: {
        name: 'Downloads',
        size: '25kb',
        type: 'Folder',
      },
      children: [
        {
          key: '4-0',
          data: {
            name: 'Spanish',
            size: '10kb',
            type: 'Folder',
          },
          children: [
            {
              key: '4-0-0',
              data: {
                name: 'tutorial-a1.txt',
                size: '5kb',
                type: 'Text',
              },
            },
            {
              key: '4-0-1',
              data: {
                name: 'tutorial-a2.txt',
                size: '5kb',
                type: 'Text',
              },
            },
          ],
        },
        {
          key: '4-1',
          data: {
            name: 'Travel',
            size: '15kb',
            type: 'Text',
          },
          children: [
            {
              key: '4-1-0',
              data: {
                name: 'Hotel.pdf',
                size: '10kb',
                type: 'PDF',
              },
            },
            {
              key: '4-1-1',
              data: {
                name: 'Flight.pdf',
                size: '5kb',
                type: 'PDF',
              },
            },
          ],
        },
      ],
    },
    {
      key: '5',
      data: {
        name: 'Main',
        size: '50kb',
        type: 'Folder',
      },
      children: [
        {
          key: '5-0',
          data: {
            name: 'bin',
            size: '50kb',
            type: 'Link',
          },
        },
        {
          key: '5-1',
          data: {
            name: 'etc',
            size: '100kb',
            type: 'Link',
          },
        },
        {
          key: '5-2',
          data: {
            name: 'var',
            size: '100kb',
            type: 'Link',
          },
        },
      ],
    },
    {
      key: '6',
      data: {
        name: 'Other',
        size: '5kb',
        type: 'Folder',
      },
      children: [
        {
          key: '6-0',
          data: {
            name: 'todo.txt',
            size: '3kb',
            type: 'Text',
          },
        },
        {
          key: '6-1',
          data: {
            name: 'logo.png',
            size: '2kb',
            type: 'Picture',
          },
        },
      ],
    },
    {
      key: '7',
      data: {
        name: 'Pictures',
        size: '150kb',
        type: 'Folder',
      },
      children: [
        {
          key: '7-0',
          data: {
            name: 'barcelona.jpg',
            size: '90kb',
            type: 'Picture',
          },
        },
        {
          key: '7-1',
          data: {
            name: 'primevue.png',
            size: '30kb',
            type: 'Picture',
          },
        },
        {
          key: '7-2',
          data: {
            name: 'prime.jpg',
            size: '30kb',
            type: 'Picture',
          },
        },
      ],
    },
    {
      key: '8',
      data: {
        name: 'Videos',
        size: '1500kb',
        type: 'Folder',
      },
      children: [
        {
          key: '8-0',
          data: {
            name: 'primefaces.mkv',
            size: '1000kb',
            type: 'Video',
          },
        },
        {
          key: '8-1',
          data: {
            name: 'intro.avi',
            size: '500kb',
            type: 'Video',
          },
        },
      ],
    },
  ]
})

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
