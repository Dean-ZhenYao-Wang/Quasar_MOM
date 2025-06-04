<template>
  <q-select
    :label="label"
    :options="orgList"
    :emit-value="true"
    :map-options="true"
    option-value="dtId"
    option-label="name"
    :rules="rules"
    :loading="orgList.length === 0"
    v-model="model"
  ></q-select>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { useOrgStore } from 'src/stores/org'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '所属组织',
  },
  rules: Array,
})

const orgStore = useOrgStore()
const orgList = ref([])

onMounted(async () => {
  const list = await orgStore.getOrgTable({ page: 1, pageSize: 99999999 })
  orgList.value = list.data.map((item) => ({
    ...item,
    name: item.name + '(' + item.fullPath + ')',
  }))
})
</script>
