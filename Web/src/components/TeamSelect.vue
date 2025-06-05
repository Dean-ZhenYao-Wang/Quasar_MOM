<template>
  <q-select
    :label="label"
    :options="teamList"
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
import { useTeamStore } from 'src/stores/team'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '所属班组',
  },
  rules: Array,
})

const teamStore = useTeamStore()
const teamList = ref([])
const loading = ref(false)

onMounted(async () => {
  loading.value = true
  const list = await teamStore.selectOptions()
  teamList.value = list
  loading.value = false
})
</script>
