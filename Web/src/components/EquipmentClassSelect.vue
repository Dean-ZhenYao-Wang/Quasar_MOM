<template>
  <q-select
    :label="label"
    :options="equipmentClassList"
    :emit-value="true"
    :map-options="true"
    option-value="dtId"
    option-label="name"
    :rules="rules"
    :loading="equipmentClassList.length === 0"
    v-model="model"
    filled
    :multiple="multiple"
    :use-chips="multiple"
    :stack-label="multiple"
  ></q-select>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { useEquipmentClassStore } from 'src/stores/equipmentClass'

const model = defineModel()

defineProps({
  label: {
    type: String,
    default: '设备类型',
  },
  rules: Array,
  multiple: {
    type: Boolean,
    default: false,
  },
  useChips: {
    type: Boolean,
    default: false,
  },
  stackLabel: {
    type: Boolean,
    default: false,
  },
})

const equipmentClassStore = useEquipmentClassStore()
const equipmentClassList = ref([])

onMounted(async () => {
  const list = await equipmentClassStore.GetPaged({ page: 1, pageSize: 99999999 })
  equipmentClassList.value = list.data
})
</script>
