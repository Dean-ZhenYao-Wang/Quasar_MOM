<template>
  <q-select
    :label="label"
    :options="personList"
    :emit-value="true"
    :map-options="true"
    option-value="dtId"
    option-label="name"
    :rules="rules"
    :loading="loading"
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
const loading = ref(false)

onMounted(async () => {
  loading.value = true
  const list = await personStore.GetResponsibles()
  personList.value = list.data
  loading.value = false
})
</script>
