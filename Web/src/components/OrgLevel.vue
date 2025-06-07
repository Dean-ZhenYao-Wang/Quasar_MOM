<template>
  <q-select
    :label="label"
    :options="levelList"
    :emit-value="true"
    :map-options="true"
    option-value="value"
    option-label="label"
    :rules="rules"
    v-model="model"
  ></q-select>
</template>

<script setup>
import { ref } from 'vue'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '组织类型',
  },
  rules: Array,
})

const levelList = ref([
  {
    value: 'Enterprise',
    label: '企业',
  },
  {
    value: 'Area',
    label: '区域/部门',
  },
])
</script>
