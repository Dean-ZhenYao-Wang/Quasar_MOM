<template>
  <q-select
    :label="label"
    :options="options"
    :emit-value="true"
    :map-options="true"
    option-value="dtId"
    option-label="name"
    :rules="rules"
    :loading="loading"
    v-model="model"
    filled
    use-input
    input-debounce="0"
    @filter="filterFn"
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
const options = ref([])

onMounted(async () => {
  loading.value = true
  const list = await personStore.GetResponsibles()
  personList.value = list.data
  options.value = list.data
  loading.value = false
})

const filterFn = (val, update) => {
  if (val === '') {
    update(() => {
      options.value = personList.value
    })
    return
  }

  update(() => {
    options.value = personList.value.filter((v) => v.name.indexOf(val) > -1)
    console.log(personList.value)
  })
}
</script>
