<template>
  <q-select
    :label="label"
    :options="teamList"
    :emit-value="true"
    :map-options="true"
    option-value="dtId"
    option-label="id"
    :rules="rules"
    :loading="loading"
    v-model="model"
  ></q-select>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { usePositionStore } from 'src/stores/position'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '所属班组',
  },
  rules: Array,
})

const positionStore = usePositionStore()
const teamList = ref([])
const loading = ref(false)

onMounted(async () => {
  loading.value = true
  const list = await positionStore.selectOptions()
  teamList.value = list
  loading.value = false
})
</script>
