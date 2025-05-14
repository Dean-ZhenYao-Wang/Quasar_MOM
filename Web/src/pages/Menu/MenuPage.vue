<template>
  <q-page class="row q-pa-md">
    <!-- 左侧树形菜单 -->
    <div class="col-3 q-pr-md">
      <q-card class="full-height">
        <q-card-section class="bg-primary text-white">
          <div class="row items-center">
            <div class="col text-h6">菜单树</div>
            <div class="col-auto">
              <q-btn icon="add" color="positive" @click="addMenu" v-if="!selectedMenuDtId" />
              <q-btn icon="edit" color="red" flat dense @click="editMenu(selectedMenuDtId)" />
              <q-btn
                icon="delete"
                color="negative"
                flat
                dense
                @click="confirmDeleteMenu(selectedMenuDtId)"
              />
            </div>
          </div>
        </q-card-section>
        <q-card-section>
          <q-tree
            ref="menuTreeComponent"
            :nodes="menuTree"
            node-key="dtId"
            label-key="name"
            selected-color="primary"
            v-model:selected="selectedMenuDtId"
            @update:selected="onMenuSelected"
          />
        </q-card-section>
      </q-card>
    </div>

    <!-- 右侧上下布局 -->
    <div class="col-9">
      <!-- 右上：子菜单列表 -->
      <div class="q-mb-md">
        <q-card>
          <q-card-section class="bg-primary text-white">
            <div class="row items-center">
              <div class="col text-h6">子菜单列表</div>
            </div>
          </q-card-section>
          <q-card-section>
            <form-table
              :config="menu_table_Config"
              v-model:tableData="subMenus"
              :loading="subMenuLoading"
              :selected="onSubMenuSelected"
              :search="onMenuSelected"
              :create="saveMenu"
              :batchDelete="handleBatchDeleteMenu"
            >
              <template v-slot:body-cell-hidden="props">
                <q-td :props="props">
                  {{ props.row.hidden ? '是' : '否' }}
                </q-td>
              </template>
              <template v-slot:body-cell-actions="props">
                <q-td :props="props">
                  <q-btn icon="edit" color="primary" flat dense @click="editMenu(props.row)" />
                  <q-btn
                    icon="delete"
                    color="negative"
                    flat
                    dense
                    @click="confirmDeleteMenu(props.row)"
                  />
                </q-td>
              </template>
            </form-table>
          </q-card-section>
        </q-card>
      </div>

      <!-- 右下：按钮列表 -->
      <div>
        <q-card>
          <q-card-section class="bg-primary text-white">
            <div class="row items-center">
              <div class="col text-h6">按钮权限</div>
              <div class="col-auto">
                <q-btn
                  icon="add"
                  label="添加按钮"
                  color="positive"
                  @click="addButton"
                  v-if="selectedSubMenu != ''"
                />
              </div>
            </div>
          </q-card-section>
          <q-card-section>
            <q-table
              :rows="buttons"
              :columns="buttonColumns"
              row-key="id"
              :loading="buttonsLoading"
            >
              <template v-slot:body-cell-actions="props">
                <q-td :props="props">
                  <q-btn icon="edit" color="primary" flat dense @click="editButton(props.row)" />
                  <q-btn
                    icon="delete"
                    color="negative"
                    flat
                    dense
                    @click="confirmDeleteButton(props.row)"
                  />
                </q-td>
              </template>
            </q-table>
          </q-card-section>
        </q-card>
      </div>
    </div>

    <!-- 添加/编辑子菜单对话框 -->
    <q-dialog v-model="menuDialog" persistent>
      <q-card style="min-width: 400px">
        <q-card-section>
          <div class="text-h6">{{ editingMenu ? '编辑菜单' : '添加菜单' }}</div>
        </q-card-section>
        <q-card-section>
          <q-form @submit="saveMenu(menuForm)">
            <q-input
              v-model="menuForm.id"
              label="菜单编号"
              :rules="[(val) => !!val || '请输入菜单编号']"
            />
            <q-input
              v-model="menuForm.name"
              label="菜单名称"
              :rules="[(val) => !!val || '请输入菜单名称']"
            />
            <q-input v-model="menuForm.path" label="路由路径" />
            <q-input v-model="menuForm.icon" label="图标"></q-input>
            <div class="q-mt-md">
              <q-btn label="取消" color="negative" flat @click="subMenuDialog = false" />
              <q-btn label="保存" type="submit" color="primary" class="q-ml-sm" />
            </div>
          </q-form>
        </q-card-section>
      </q-card>
    </q-dialog>

    <!-- 添加/编辑按钮对话框 -->
    <q-dialog v-model="buttonDialog" persistent>
      <q-card style="min-width: 400px">
        <q-card-section>
          <div class="text-h6">{{ editingButton ? '编辑按钮' : '添加按钮' }}</div>
        </q-card-section>
        <q-card-section>
          <q-form @submit="saveButton">
            <q-input
              v-model="buttonForm.name"
              label="按钮名称"
              :rules="[(val) => !!val || '请输入按钮名称']"
            />
            <q-input
              v-model="buttonForm.id"
              label="权限编码"
              :rules="[(val) => !!val || '请输入权限编码']"
            />
            <q-input v-model="buttonForm.icon" label="图标" />
            <div class="q-mt-md">
              <q-btn label="取消" color="negative" flat @click="buttonDialog = false" />
              <q-btn label="保存" type="submit" color="primary" class="q-ml-sm" />
            </div>
          </q-form>
        </q-card-section>
      </q-card>
    </q-dialog>
  </q-page>
</template>

<script>
import { ref, onMounted } from 'vue'
import { useQuasar } from 'quasar'
import { useMenuStore } from 'src/stores/menu'

export default {
  setup() {
    const menu_table_Config = {
      queryFields: {
        id: {
          type: 'q-input',
          label: '编号',
          props: {
            outlined: true,
          },
        },
        name: {
          type: 'q-input',
          label: '名称',
          props: {
            outlined: true,
          },
        },
      },
      formFields: {
        dtId: {
          show: false,
          type: 'q-input',
          label: '数据库唯一标识',
        },
        id: {
          type: 'q-input',
          label: '编号',
          rules: [(val) => !!val || '必填字段'],
        },
        name: {
          type: 'q-input',
          label: '名称',
          rules: [(val) => !!val || '必填字段'],
        },
        path: {
          type: 'q-input',
          label: '路径',
          rules: [(val) => !!val || '必填字段'],
        },
        icon: {
          type: 'q-input',
          label: '图标',
        },
      },
      tableConfig: {
        rowKey: 'dtId',
        selection: 'multiple',
        columns: [
          { name: 'id', label: '菜单编号', field: 'id', align: 'left' },
          { name: 'name', label: '菜单名称', field: 'name', align: 'left' },
          { name: 'path', label: '路由路径', field: 'path', align: 'left' },
          { name: 'icon', label: '图标', field: 'icon', align: 'left' },
        ],
      },
    }
    const $q = useQuasar()
    const menuStore = useMenuStore()
    const menuTreeComponent = ref(null)
    // 菜单树数据
    const menuTree = ref([])

    const selectedMenuDtId = ref('')
    const subMenus = ref([])
    const subMenuLoading = ref(false)
    const selectedSubMenu = ref('')
    const buttons = ref([])
    const buttonsLoading = ref(false)

    // 按钮表格列定义
    const buttonColumns = [
      { name: 'name', label: '按钮名称', field: 'name', align: 'left' },
      { name: 'code', label: '权限编码', field: 'code', align: 'left' },
      { name: 'icon', label: '图标', field: 'icon', align: 'left' },
      { name: 'actions', label: '操作', align: 'center' },
    ]

    // 菜单对话框相关
    const menuDialog = ref(false)
    const editingMenu = ref(false)
    const menuForm = ref({
      id: '',
      name: '',
      path: '',
      icon: '',
      parentMenuDtId: '',
      depth: 0,
      hidden: false,
    })

    // 按钮对话框相关
    const buttonDialog = ref(false)
    const editingButton = ref(false)
    const buttonForm = ref({
      name: '',
      code: '',
      icon: '',
    })

    // 选择菜单时加载子菜单
    const onMenuSelected = async (queryParams) => {
      if (!selectedMenuDtId.value) return
      subMenuLoading.value = true
      await menuStore.getChildMenus(
        selectedMenuDtId.value,
        queryParams?.id ? queryParams.id : '',
        queryParams?.name ? queryParams.name : '',
      )
      subMenus.value = menuStore.childMenus
      subMenuLoading.value = false
      selectedSubMenu.value = ''
      buttons.value = []
    }

    // 选择子菜单时加载按钮
    const onSubMenuSelected = async (rows) => {
      if (rows.length === 0) {
        buttons.value = []
        return
      }

      buttonsLoading.value = true
      selectedSubMenu.value = rows[0].dtId
      await menuStore.getButtons(rows[0].dtId)
      buttons.value = menuStore.buttons
      buttonsLoading.value = false
    }

    //添加菜单
    const addMenu = () => {
      menuForm.value = {
        id: '',
        name: '',
        path: '',
        icon: '',
        parentMenuDtId: null,
        depth: 0,
        hidden: false,
      }
      editingMenu.value = false
      menuDialog.value = true
    }

    // 编辑菜单
    const editMenu = (row) => {
      if (row.name) menuForm.value = { ...row }
      else menuForm.value = { ...menuTreeComponent.value.getNodeByKey(selectedMenuDtId.value) }
      editingMenu.value = true
      menuDialog.value = true
    }

    // 保存菜单
    const saveMenu = async (payload) => {
      menuForm.value = { ...payload }
      menuForm.value.parentMenuDtId = selectedMenuDtId.value
      menuForm.value.depth =
        selectedMenuDtId.value == null
          ? 0
          : menuTreeComponent.value.getNodeByKey(selectedMenuDtId.value).depth + 1
      menuForm.value.hidden = false

      if (menuForm.value.dtId) {
        await menuStore.updateMenu(menuForm.value)
        //if (menuForm.value.parentMenuDtId != null) await onMenuSelected(selectedMenu.value) // 刷新数据
        await getMenuTree()
      } else {
        await menuStore.addMenu(menuForm.value)
        //if (menuForm.value.parentMenuDtId != null) await onMenuSelected(selectedMenu.value) // 刷新数据
        await getMenuTree()
      }
      menuDialog.value = false
    }

    // 确认删除菜单
    const confirmDeleteMenu = async (row) => {
      $q.dialog({
        title: '确认删除',
        message: `确定要删除菜单 "${row.name || menuTreeComponent.value.getNodeByKey(selectedMenuDtId.value).name}" 吗？`,
        cancel: true,
        persistent: true,
      }).onOk(async () => {
        await menuStore.deleteMenu(row)
        if (row.name) await onMenuSelected() // 刷新数据
        await getMenuTree()
      })
    }
    //确认批量删除菜单
    const handleBatchDeleteMenu = async (dtIds) => {
      $q.dialog({
        title: '确认删除',
        message: `确定要删除这几个菜单吗？`,
        cancel: true,
        persistent: true,
      }).onOk(async () => {
        await menuStore.deleteMenus(dtIds)
        await onMenuSelected() // 刷新数据
        await getMenuTree()
      })
    }

    // 添加按钮
    const addButton = () => {
      buttonForm.value = {
        name: '',
        id: '',
        icon: '',
        menuDtId: selectedSubMenu.value,
      }
      editingButton.value = false
      buttonDialog.value = true
    }

    // 编辑按钮
    const editButton = (row) => {
      buttonForm.value = { ...row }
      editingButton.value = true
      buttonDialog.value = true
    }

    // 保存按钮
    const saveButton = async () => {
      if (buttonForm.value.dtId) {
        await menuStore.updateButton(buttonForm.value)
        buttonDialog.value = false
        onSubMenuSelected([{ dtId: selectedSubMenu.value }]) // 刷新数据
      } else {
        await menuStore.addButton(buttonForm.value)
        buttonDialog.value = false
        onSubMenuSelected([{ dtId: selectedSubMenu.value }]) // 刷新数据
      }
    }

    // 确认删除按钮
    const confirmDeleteButton = (row) => {
      $q.dialog({
        title: '确认删除',
        message: `确定要删除按钮 "${row.name}" 吗？`,
        cancel: true,
        persistent: true,
      }).onOk(async () => {
        await menuStore.deleteButton(row)
        onSubMenuSelected([{ dtId: selectedSubMenu.value }]) // 刷新数据
      })
    }

    const getMenuTree = async () => {
      await menuStore.getMenuTree()
      menuTree.value = menuStore.menuTree
    }
    onMounted(async () => {
      await getMenuTree()
      // 初始化时选中第一个菜单
      if (menuTree.value.length > 0) {
        selectedMenuDtId.value = menuTree.value[0].dtId
        onMenuSelected()
      }
    })

    return {
      menuTree,
      selectedMenuDtId,
      subMenus,
      subMenuLoading,
      selectedSubMenu,
      buttons,
      buttonsLoading,
      buttonColumns,
      menuDialog,
      editingMenu,
      menuForm,
      buttonDialog,
      editingButton,
      buttonForm,
      menuTreeComponent,
      getMenuTree,
      onMenuSelected,
      onSubMenuSelected,
      addMenu,
      editMenu,
      saveMenu,
      confirmDeleteMenu,
      addButton,
      editButton,
      saveButton,
      confirmDeleteButton,
      menu_table_Config,
      handleBatchDeleteMenu,
    }
  },
}
</script>

<style scoped>
.full-height {
  height: calc(100vh - 100px);
}
</style>
