<template>
  <q-select
    filled
    use-input
    :label="label"
    :options="filterList"
    :emit-value="true"
    :map-options="true"
    option-value="dtId"
    option-label="name"
    :rules="rules"
    :loading="filterList.length === 0"
    v-model="model"
    @filter="filterFn"
  ></q-select>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { useHierarchyScopeStore } from 'src/stores/hierarchyScope'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '所属组织',
  },
  rules: Array,
})

const orgStore = useHierarchyScopeStore()
const orgList = ref([])
const filterList = ref([])

const filterFn = (val, update) => {
  if (val === '') {
    update(() => {
      filterList.value = orgList.value

      // here you have access to "ref" which
      // is the Vue reference of the QSelect
    })
    return
  }

  update(() => {
    filterList.value = orgList.value.filter((v) => v.nickName.indexOf(val) > -1)
  })
}

onMounted(async () => {
  const list = await orgStore.getOrgTable({ page: 1, pageSize: 99999999 })
  orgList.value = list.data.map((item) => ({
    ...item,
    nickName: item.name,
    name: item.name + '(' + item.fullPath + ')',
  }))
  filterList.value = [...orgList.value]
})
</script>
