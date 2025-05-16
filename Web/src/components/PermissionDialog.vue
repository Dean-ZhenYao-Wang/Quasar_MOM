<template>
  <q-dialog v-model="dialogVisible" @hide="dialogClose">
    <!-- 左侧树形菜单 -->
    <div class="col-3 q-pr-md">
      <q-card class="full-height">
        <q-card-section class="bg-primary text-white">
          <div class="row items-center">
            <div class="col text-h6">菜单</div>
          </div>
        </q-card-section>
        <q-card-section>
          <q-tree
            :nodes="menuTree"
            v-model:ticked="ticked"
            @update:ticked="tickedTarget"
            node-key="id"
            label-key="name"
            v-model:selected="selectedMenuDtId"
            tick-strategy="strict"
            default-expand-all
          />
        </q-card-section>
      </q-card>
    </div>

    <!-- 右侧 -->
    <div class="col-9">
      <!-- 按钮列表 -->
      <div class="q-mb-md">
        <q-card>
          <q-card-section class="bg-primary text-white">
            <div class="row items-center">
              <div class="col text-h6">按钮</div>
            </div>
          </q-card-section>
          <q-card-section>
            <q-table
              :rows="buttons"
              :columns="buttonColumns"
              row-key="id"
              :loading="buttonsLoading"
              selection="multiple"
              v-model:selected="selectedButtonRows"
            >
            </q-table>
          </q-card-section>
        </q-card>
      </div>
      <button hover-class="button-hover" @click="ok">确定</button>
    </div>
  </q-dialog>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { useMenuStore } from 'src/stores/menu'
const props = defineProps({
  oldSelectIds: {
    type: Array,
    default: () => [],
  },
  ok: Function,
})
const dialogVisible = defineModel('dialogVisible', { default: false })
const emit = defineEmits(['update:modelValue'])
const dialogClose = () => {
  ticked.value = []
  selectedButtonRows.value = []
  emit('update:modelValue', false)
}
const menuStore = useMenuStore()
// 菜单树数据
const menuTree = ref([])
//按钮数据
const buttons = ref([])
const buttonsLoading = ref(false)
const selectedButtonRows = ref([])
// 按钮表格列定义
const buttonColumns = [
  { name: 'name', label: '按钮名称', field: 'name', align: 'left' },
  { name: 'code', label: '权限编码', field: 'code', align: 'left' },
  { name: 'icon', label: '图标', field: 'icon', align: 'left' },
]
// 选择菜单时加载按钮
//已选择的菜单
const ticked = ref([])
const oldSelectButtonIds = ref([])
const tickedTarget = async (target) => {
  if (target.length > 0) {
    //取最后一个
    await menuStore.getButtons(target[target.length - 1])
    buttons.value = menuStore.buttons
    buttons.value.forEach((x) => {
      if (ticked.value.findIndex(x.id) > -1) {
        selectedButtonRows.value.push(x)
        oldSelectButtonIds.value.push(x.id)
      }
    })
  } else {
    buttons.value = []
  }
}
const ok = async () => {
  let B = selectedButtonRows.value.map((item) => item.id)
  let aNotInB = oldSelectButtonIds.value.filter((item) => !B.includes(item)) //需要删除的
  let bNotInA = B.filter((item) => !oldSelectButtonIds.value.includes(item)) //需要添加的

  ticked.value = ticked.value.filter((item) => !aNotInB.includes(item))

  if (props.ok) await props.ok([...ticked.value, ...bNotInA])
}
const getMenuTree = async () => {
  await menuStore.getMenuTree()
  menuTree.value = menuStore.menuTree
}
onMounted(async () => {
  await getMenuTree()
  ticked.value = { ...props.oldSelectIds }
})
</script>
