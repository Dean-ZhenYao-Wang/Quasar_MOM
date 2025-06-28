<template>
  <q-select
    :label="label"
    :options="options"
    :emit-value="true"
    :map-options="true"
    option-value="value"
    option-label="label"
    :rules="rules"
    v-model="model"
    filled
    use-input
    input-debounce="0"
    @filter="filterFn"
  >
    <template v-slot:option="scope">
      <q-item v-bind="scope.itemProps">
        <q-item-section>
          <q-item-label>{{ scope.opt.label }}</q-item-label>
          <q-item-label caption>{{ scope.opt.description }}</q-item-label>
        </q-item-section>
      </q-item>
    </template>
  </q-select>
</template>

<script setup>
import { ref } from 'vue'

const model = defineModel()

defineProps({
  label: {
    typeo: String,
    default: '设备角色层次',
  },
  rules: Array,
})

const levelList = [
  {
    value: 'Enterprise',
    label: '企业',
  },
  {
    value: 'Site',
    label: '场所/工厂',
  },
  {
    value: 'Area',
    label: '区域/车间/部门',
  },
  {
    value: 'Work_Center',
    label: '工作中心/CellGroup',
  },
  {
    value: 'Work_Unit',
    label: '工作单元/Cell',
  },
  {
    value: 'Process_Cell',
    label: '生产工艺段',
    description: '用于批生产',
  },
  {
    value: 'Unit',
    label: '单元',
    description: '用于批生产的设备/用于连续生产的设备',
  },
  {
    value: 'Production_Line',
    label: '产线',
    description: '用于重复或离散生产',
  },
  {
    value: 'Production_Unit',
    label: '工段/工位',
    description: '用于重复或离散生产的设备或位置',
  },
  {
    value: 'Work_Cell',
    label: '生产单元：',
    description: '用于连续生产',
  },
  {
    value: 'Storage_Zone',
    label: '存储区：',
    description: '用于存储或运输',
  },
  {
    value: 'Storage_Unit',
    label: '存储单元',
    description: '用于存储或运输的设备',
  },
]

const options = ref(levelList)

const filterFn = (val, update) => {
  if (val === '') {
    update(() => {
      options.value = levelList
    })
    return
  }

  update(() => {
    options.value = levelList.filter((v) => v.label.indexOf(val) > -1)
  })
}
</script>
