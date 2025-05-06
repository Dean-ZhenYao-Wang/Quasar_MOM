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
            :key="tab.key"
            :to="tab.url"
            :label="tab.label"
            exact
          />
        </q-tabs>
        <div style="width: 30px"></div>
        <OverlayBadge value="2">
          <i class="pi pi-bell" style="font-size: 2rem" />
        </OverlayBadge>
        <div style="width: 30px"></div>
        <Avatar icon="pi pi-user" size="large" />
        {{ currentUser.name }}
      </q-toolbar>
    </q-header>

    <q-drawer v-model="leftDrawerOpen" side="left" overlay elevated>
      <q-tree :nodes="menuItems" node-key="key" selected-color="primary">
        <template v-slot:default-header="prop">
          <div class="row items-center" @click="selectedMenu(prop.node)">
            <q-icon :name="prop.node.icon || 'share'" color="orange" size="28px" class="q-mr-sm" />
            <div class="text-weight-bold text-primary">{{ prop.node.label }}</div>
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
export default {
  setup() {
    const currentUser = useCurrentUserStore()
    const leftDrawerOpen = ref(false)
    const rightDrawerOpen = ref(false)
    const openMenus = ref([])
    const tabActive = ref({})
    const isHttpUrl = (str) => {
      return /^https?:\/\//.test(str)
    }
    const router = useRouter()
    const selectedMenu = (menu) => {
      if (menu.url) {
        if (isHttpUrl(menu.url)) {
          window.open(menu.url, '_blank')
        } else {
          if (openMenus.value.length > 0) {
            // 防止重复添加标签页
            if (!openMenus.value.some((t) => t.key === menu.key)) {
              openMenus.value.push(menu)
            }
          } else {
            openMenus.value.push(menu)
          }
          router.push(menu.url)
        }
      }
    }
    const menuItems = ref([])
    const initMenu = () => {
      if (menuItems.value.length > 0) return
      let menus = [
        {
          key: '0',
          label: '系统配置',
          children: [
            {
              key: '0-1',
              label: '菜单',
              icon: 'pi pi-folder-open',
              url: '/system/menu',
            },
          ],
        },
        {
          key: '1',
          label: '基础数据',
          children: [
            {
              key: '1-1',
              label: '组织架构',
              url: '/org/org',
            },
            {
              key: '1-2',
              label: '岗位',
              children: [
                {
                  key: '1-2-1',
                  label: '3rd Level 3',
                },
                {
                  key: '1-2-2',
                  label: '3rd Level 4',
                },
              ],
            },
          ],
        },
        {
          key: '2',
          label: 'Quit',
          icon: 'pi pi-sign-out',
        },
      ]
      // enhanceMenuWithCommands(menus)
      menuItems.value = menus
    }
    initMenu()
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
      // enhanceMenuWithCommands,
      tabActive,
      selectedMenu,
      currentUser,
    }
  },
}
</script>
