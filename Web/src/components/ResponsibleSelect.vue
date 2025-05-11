<template>
  <q-select
    :label="label"
    :options="personList"
    :emit-value="true"
    :map-options="true"
    option-value="dtId"
    option-label="name"
    :rules="rules"
    :loading="personList.length === 0"
    v-model="model"
  ></q-select>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { usePersonStore } from 'src/stores/person'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '负责人',
  },
  rules: Array,
})

const personStore = usePersonStore()
const personList = ref([])

onMounted(async () => {
  const list = await personStore.GetResponsibles()
  personList.value = list.data
})
</script>
