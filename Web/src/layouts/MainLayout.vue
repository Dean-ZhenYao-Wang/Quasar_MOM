<template>
  <q-layout view="hHh lpR fFf">
    <q-header elevated class="bg-primary text-white" height-hint="98">
      <q-toolbar>
        <q-btn dense flat round icon="menu" @click="toggleLeftDrawer" />

        <q-toolbar-title>
          <q-avatar>
            <img src="https://cdn.quasar.dev/logo-v2/svg/logo-mono-white.svg" />
          </q-avatar>
          Title
        </q-toolbar-title>
        <q-tabs align="left" inline-label shrink stretch>
          <q-route-tab
            v-for="tab in openMenus"
            :key="tab.dtId"
            :to="tab.path"
            :label="tab.name"
            exact
          />
        </q-tabs>
        <div style="width: 30px"></div>
        <OverlayBadge value="2">
          <i class="pi pi-bell" style="font-size: 2rem" />
        </OverlayBadge>
        <div style="width: 30px"></div>
        <Avatar icon="pi pi-user" size="large" :image="currentUser.photo" />
        <q-btn color="primary" :label="currentUser.name">
          <i class="pi pi-angle-down"></i>
          <q-menu>
            <q-list dense style="min-width: 100px">
              <q-item clickable v-close-popup>
                <q-item-section @click="editPassWord">修改密码</q-item-section>
              </q-item>
              <q-item clickable v-close-popup>
                <q-item-section @click="logOut">退出</q-item-section>
              </q-item>
            </q-list>
          </q-menu>
        </q-btn>
        <q-dialog v-model="editPassWordDialog">
          <q-card>
            <q-card-section class="row items-center q-pb-none">
              <div class="text-h6">修改密码</div>
              <q-space />
              <q-btn icon="close" flat round dense v-close-popup />
            </q-card-section>

            <q-card-section>
              <!-- 密码输入框 -->
              <q-input label="当前密码" v-model="currentPassword" type="password" required />
              <q-input label="新密码" v-model="newPasswords" type="password" required />
              <q-input label="确认新密码" v-model="confirmPassword" type="password" required />
            </q-card-section>
            <q-card-actions>
              <q-btn label="取消" color="negative" @click="closePasswordDialog" />
              <q-btn label="保存" color="positive" @click="updatePassword" />
            </q-card-actions>
          </q-card>
        </q-dialog>
      </q-toolbar>
    </q-header>
    <q-drawer v-model="leftDrawerOpen" side="left" overlay elevated>
      <q-tree :nodes="menuItems" node-key="dtId" selected-color="primary">
        <template v-slot:default-header="prop">
          <div class="row items-center" @click="selectedMenu(prop.node)">
            <q-icon :name="prop.node.icon || 'share'" color="orange" size="28px" class="q-mr-sm" />
            <div class="text-weight-bold text-primary">{{ prop.node.name }}</div>
          </div>
        </template>
      </q-tree>
    </q-drawer>

    <q-page-container>
      <router-view v-slot="{ Component }">
        <keep-alive>
          <component :is="Component" />
        </keep-alive>
      </router-view>
    </q-page-container>
  </q-layout>
</template>

<script>
import { ref } from 'vue'
import { useRouter } from 'vue-router'
import { useCurrentUserStore } from 'src/stores/currentUser'
import { useMenuStore } from 'src/stores/menu'
import { debounce, useQuasar } from 'quasar'
export default {
  setup() {
    const currentUser = useCurrentUserStore()
    const editPassWordDialog = ref(false)
    const currentPassword = ref('')
    const confirmPassword = ref('')
    const newPasswords = ref('')
    const submitting = ref(false)
    const leftDrawerOpen = ref(false)
    const rightDrawerOpen = ref(false)
    const openMenus = ref([])
    const tabActive = ref({})
    const isHttpUrl = (str) => {
      return /^https?:\/\//.test(str)
    }
    const router = useRouter()
    const selectedMenu = (menu) => {
      if (menu.path) {
        leftDrawerOpen.value = !leftDrawerOpen.value
        if (isHttpUrl(menu.path)) {
          window.open(menu.path, '_blank')
        } else {
          if (openMenus.value.length > 0) {
            // 防止重复添加标签页
            if (!openMenus.value.some((t) => t.dtId === menu.dtId)) {
              openMenus.value.push(menu)
            }
          } else {
            openMenus.value.push(menu)
          }
          router.push(menu.path)
        }
      }
    }
    const menuItems = ref([])
    const initMenu = async () => {
      const menuStore = useMenuStore()
      if (menuItems.value.length > 0) return
      await menuStore.getMenuTree()
      menuItems.value = menuStore.menuTree
    }
    initMenu()
    const editPassWord = () => {
      editPassWordDialog.value = !editPassWordDialog.value
    }
    const logOut = () => {
      currentUser.jwt = ''
      router.push('/login')
    }
    const closePasswordDialog = () => {
      editPassWordDialog.value = !editPassWordDialog.value
      // 重置表单数据
      currentPassword.value = ''
      newPasswords.value = ''
      confirmPassword.value = ''
    }

    const $q = useQuasar()
    const updatePassword = debounce(
      async function () {
        if (newPasswords.value !== confirmPassword.value) {
          $q.notify({
            message: '两次输入的密码不一致，请重新输入。',
            color: 'negative',
            multiLine: true,
          })
          return
        }

        // 将字符串转换为ArrayBuffer
        const msgBuffer = new TextEncoder().encode(currentPassword.value)
        window.crypto.subtle
          .digest('SHA-1', msgBuffer)
          .then(async (hashBuffer) => {
            // 将ArrayBuffer转换为十六进制字符串
            const hashArray = Array.from(new Uint8Array(hashBuffer))
            const hashHex = hashArray.map((b) => b.toString(16).padStart(2, '0')).join('')
            const current_hashHex = hashHex.toUpperCase()

            const confirm_msgBuffer = new TextEncoder().encode(confirmPassword.value)

            window.crypto.subtle
              .digest('SHA-1', confirm_msgBuffer)
              .then(async (confirm_hashBuffer) => {
                // 将ArrayBuffer转换为十六进制字符串
                const confirm_hashArray = Array.from(new Uint8Array(confirm_hashBuffer))
                const confirm_hashHex_s = confirm_hashArray
                  .map((b) => b.toString(16).padStart(2, '0'))
                  .join('')
                const confirm_hashHex = confirm_hashHex_s.toUpperCase()
                $q.notify({
                  type: 'success',
                  message: '密码修改成功',
                  position: 'top',
                  timeout: 2000,
                }),
                  await currentUser.ChangePassword(current_hashHex, confirm_hashHex)
                logOut()
              })
              .catch((err) =>
                $q.notify({
                  type: 'negative',
                  message: err,
                  position: 'top',
                  timeout: 2000,
                }),
              )
          })
          .catch((err) =>
            $q.notify({
              type: 'negative',
              message: err,
              position: 'top',
              timeout: 2000,
            }),
          )
      },
      500,
      true,
    )
    return {
      leftDrawerOpen,
      toggleLeftDrawer() {
        leftDrawerOpen.value = !leftDrawerOpen.value
      },

      rightDrawerOpen,
      toggleRightDrawer() {
        rightDrawerOpen.value = !rightDrawerOpen.value
      },
      openMenus,
      menuItems,
      tabActive,
      selectedMenu,
      currentUser,
      editPassWord,
      logOut,
      editPassWordDialog,
      submitting,
      updatePassword,
      currentPassword,
      confirmPassword,
      newPasswords,
      closePasswordDialog,
    }
  },
}
</script>
