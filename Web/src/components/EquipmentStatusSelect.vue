<template>
  <q-select
    :label="label"
    :options="statusList"
    :emit-value="true"
    :map-options="true"
    option-value="value"
    option-label="label"
    :rules="rules"
    :loading="statusList.length === 0"
    v-model="model"
    filled
  ></q-select>
</template>

<script setup>
import { ref } from 'vue'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '设备状态',
  },
  rules: Array,
})
const statusList = ref([
  {
    label: '启用',
    value: '启用',
  },
  {
    label: '维修',
    value: '维修',
  },
  {
    label: '故障',
    value: '故障',
  },
  {
    label: '停用',
    value: '停用',
  },
  {
    label: '报废',
    value: '报废',
  },
])
</script>
