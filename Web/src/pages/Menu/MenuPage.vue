<template>
  <q-page class="row q-pa-md">
    <!-- 左侧树形菜单 -->
    <div class="col-3 q-pr-md">
      <q-card class="full-height">
        <q-card-section class="bg-primary text-white">
          <div class="row items-center">
            <div class="col text-h6">菜单树</div>
            <div class="col-auto">
              <q-btn icon="add" label="添加菜单" color="positive" @click="addMenu" />
              <q-btn icon="edit" color="red" flat dense @click="editSubMenu(selectedMenu)" />
              <q-btn
                icon="delete"
                color="negative"
                flat
                dense
                @click="confirmDeleteSubMenu(selectedMenu)"
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
            v-model:selected="selectedMenu"
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
              <div class="col-auto">
                <q-btn
                  icon="add"
                  label="添加子菜单"
                  color="positive"
                  @click="addSubMenu"
                  v-if="selectedMenu"
                />
              </div>
            </div>
          </q-card-section>
          <q-card-section>
            <q-table
              :rows="subMenus"
              :columns="subMenuColumns"
              row-key="dtId"
              :loading="subMenuLoading"
              v-model:selected="selectedSubMenu"
              @update:selected="onSubMenuSelected"
              selection="single"
            >
              <template v-slot:body-cell-hidden="props">
                <q-td :props="props">
                  {{ props.row.hidden ? '是' : '否' }}
                </q-td>
              </template>
              <template v-slot:body-cell-actions="props">
                <q-td :props="props">
                  <q-btn icon="edit" color="primary" flat dense @click="editSubMenu(props.row)" />
                  <q-btn
                    icon="delete"
                    color="negative"
                    flat
                    dense
                    @click="confirmDeleteSubMenu(props.row)"
                  />
                </q-td>
              </template>
            </q-table>
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
                  v-if="selectedSubMenu"
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
    <q-dialog v-model="subMenuDialog" persistent>
      <q-card style="min-width: 400px">
        <q-card-section>
          <div class="text-h6">{{ editingSubMenu ? '编辑子菜单' : '添加子菜单' }}</div>
        </q-card-section>
        <q-card-section>
          <q-form @submit="saveSubMenu">
            <q-input
              v-model="subMenuForm.id"
              label="菜单编号"
              :rules="[(val) => !!val || '请输入菜单编号']"
            />
            <q-input
              v-model="subMenuForm.name"
              label="菜单名称"
              :rules="[(val) => !!val || '请输入菜单名称']"
            />
            <q-input
              v-model="subMenuForm.path"
              label="路由路径"
              :rules="[(val) => !!val || '请输入路由路径']"
            />
            <q-input v-model="subMenuForm.icon" label="图标"></q-input>
            <q-toggle v-model="subMenuForm.hidden" label="是否不可见" />
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
import { api } from 'boot/axios'

export default {
  setup() {
    const $q = useQuasar()
    const menuTreeComponent = ref(null)
    // 菜单树数据
    const menuTree = ref([])

    const selectedMenu = ref([])
    const subMenus = ref([])
    const subMenuLoading = ref(false)
    const selectedSubMenu = ref([])
    const buttons = ref([])
    const buttonsLoading = ref(false)

    // 子菜单表格列定义
    const subMenuColumns = [
      { name: 'id', label: '菜单编号', field: 'id', align: 'left' },
      { name: 'name', label: '菜单名称', field: 'name', align: 'left' },
      { name: 'path', label: '路由路径', field: 'path', align: 'left' },
      { name: 'icon', label: '图标', field: 'icon', align: 'left' },
      { name: 'hidden', label: '是否不可见', field: 'visible', align: 'center' },
      { name: 'actions', label: '操作', align: 'center' },
    ]

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
    const onMenuSelected = async (dtId) => {
      if (!dtId) return
      subMenuLoading.value = true
      const childMenus = await api.get(`/api/v{version}/Menu/GetMenuList?ParentMenuDtId=${dtId}`)
      subMenus.value = childMenus.data
      subMenuLoading.value = false
      selectedSubMenu.value = []
      buttons.value = []
    }

    // 选择子菜单时加载按钮
    const onSubMenuSelected = (rows) => {
      if (rows.length === 0) {
        buttons.value = []
        return
      }

      buttonsLoading.value = true

      api.get(`/api/v{version}/Menu/GetButtonList?menuDtId=${rows[0].dtId}`).then((res) => {
        buttons.value = res.data
        buttonsLoading.value = false
      })
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
    // 添加子菜单
    const addSubMenu = () => {
      menuForm.value = {
        id: '',
        name: '',
        path: '',
        icon: '',
        parentMenuDtId: selectedMenu.value,
        depth: menuTreeComponent.value.getNodeByKey(selectedMenu.value).depth + 1,
        hidden: false,
      }
      editingMenu.value = false
      menuDialog.value = true
    }

    // 编辑菜单
    const editMenu = (row) => {
      if (row.name) menuForm.value = { ...row }
      else menuForm.value = { ...menuTreeComponent.value.getNodeByKey(selectedMenu.value) }
      editingMenu.value = true
      menuDialog.value = true
    }

    // 保存菜单
    const saveMenu = () => {
      if (menuForm.value.dtId) {
        // 这里应该是调用API保存数据
        api
          .put('/api/v{version}/Menu/UpdateMenu', menuForm.value)
          .then(() => {
            $q.notify({
              message: '菜单更新成功',
              color: 'positive',
            })
            menuDialog.value = false
            if (menuForm.value.parentMenuDtId != null) onMenuSelected(selectedMenu.value) // 刷新数据
            getMenuTree()
          })
          .catch(() => {
            $q.notify({
              message: '子菜单更新失败',
              color: 'positive',
            })
          })
      } else {
        api
          .post('/api/v{version}/Menu/AddMenu', menuForm.value)
          .then(() => {
            $q.notify({
              message: '菜单添加成功',
              color: 'positive',
            })
            menuDialog.value = false
            if (menuForm.value.parentMenuDtId != null)
              onMenuSelected(selectedMenu.value) // 刷新数据
            else getMenuTree()
          })
          .catch(() => {
            $q.notify({
              message: '菜单添加失败',
              color: 'positive',
            })
          })
      }
    }

    // 确认删除菜单
    const confirmDeleteMenu = (row) => {
      $q.dialog({
        title: '确认删除',
        message: `确定要删除菜单 "${row.name || menuTreeComponent.value.getNodeByKey(selectedMenu.value).name}" 吗？`,
        cancel: true,
        persistent: true,
      }).onOk(() => {
        api
          .delete('/api/v{version}/Menu/DeleteMenu', { data: { dtIds: [row.dtId || row] } })
          .then(() => {
            $q.notify({
              message: '菜单删除成功',
              color: 'positive',
            })
            if (row.name)
              onMenuSelected(selectedMenu.value) // 刷新数据
            else getMenuTree()
          })
          .catch(() => {
            $q.notify({
              message: '菜单删除失败',
              color: 'positive',
            })
          })
      })
    }

    // 添加按钮
    const addButton = () => {
      buttonForm.value = {
        name: '',
        id: '',
        icon: '',
        menuDtId: selectedSubMenu.value[0].dtId,
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
    const saveButton = () => {
      if (menuForm.value.dtId) {
        // 这里应该是调用API保存数据
        api
          .put('/api/v{version}/Menu/UpdateMenu', menuForm.value)
          .then(() => {
            $q.notify({
              message: '菜单更新成功',
              color: 'positive',
            })
            menuDialog.value = false
            if (menuForm.value.parentMenuDtId != null) onMenuSelected(selectedMenu.value) // 刷新数据
            getMenuTree()
          })
          .catch(() => {
            $q.notify({
              message: '子菜单更新失败',
              color: 'positive',
            })
          })
      } else {
        api
          .post('/api/v{version}/Menu/AddButton', buttonForm.value)
          .then(() => {
            $q.notify({
              message: '按钮添加成功',
              color: 'positive',
            })
            buttonDialog.value = false
            onSubMenuSelected(selectedSubMenu.value) // 刷新数据
          })
          .catch(() => {
            $q.notify({
              message: '按钮添加失败',
              color: 'positive',
            })
          })
      }
    }

    // 确认删除按钮
    const confirmDeleteButton = (row) => {
      $q.dialog({
        title: '确认删除',
        message: `确定要删除按钮 "${row.name}" 吗？`,
        cancel: true,
        persistent: true,
      }).onOk(() => {
        // 这里应该是调用API删除数据
        $q.notify({
          message: '按钮删除成功',
          color: 'positive',
        })
        onSubMenuSelected([selectedSubMenu.value]) // 刷新数据
      })
    }

    const getMenuTree = async () => {
      const response = await api.get('/api/v{version}/Menu/GetMenuTree')
      menuTree.value = response.data
    }
    onMounted(async () => {
      await getMenuTree()
      // 初始化时选中第一个菜单
      if (menuTree.value.length > 0) {
        selectedMenu.value = menuTree.value[0].dtId
        onMenuSelected(selectedMenu.value)
      }
    })

    return {
      menuTree,
      selectedMenu,
      subMenus,
      subMenuLoading,
      subMenuColumns,
      selectedSubMenu,
      buttons,
      buttonsLoading,
      buttonColumns,
      subMenuDialog: menuDialog,
      editingSubMenu: editingMenu,
      subMenuForm: menuForm,
      buttonDialog,
      editingButton,
      buttonForm,
      menuTreeComponent,
      getMenuTree,
      onMenuSelected,
      onSubMenuSelected,
      addSubMenu,
      addMenu,
      editSubMenu: editMenu,
      saveSubMenu: saveMenu,
      confirmDeleteSubMenu: confirmDeleteMenu,
      addButton,
      editButton,
      saveButton,
      confirmDeleteButton,
    }
  },
}
</script>

<style scoped>
.full-height {
  height: calc(100vh - 100px);
}
</style>
