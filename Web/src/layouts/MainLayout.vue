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
        <q-btn dense flat round icon="menu" @click="toggleRightDrawer" />
      </q-toolbar>

      <q-tabs align="left">
        <q-route-tab to="/page1" label="Page One" />
        <q-route-tab to="/page2" label="Page Two" />
        <q-route-tab to="/page3" label="Page Three" />
      </q-tabs>
    </q-header>

    <q-drawer v-model="leftDrawerOpen" side="left" overlay elevated>
      <Menu :model="menuItems" />
    </q-drawer>

    <q-drawer v-model="rightDrawerOpen" side="right" overlay elevated>
      <!-- drawer content -->
    </q-drawer>

    <q-page-container>
      <router-view />
    </q-page-container>
  </q-layout>
</template>

<script>
import { ref } from 'vue'
import { useRouter } from 'vue-router'
export default {
  setup() {
    const leftDrawerOpen = ref(false)
    const rightDrawerOpen = ref(false)
    const router = useRouter()
    // 菜单配置
    const menuItems = ref([
      {
        label: '系统配置',
        items: [
          {
            label: '菜单',
            icon: 'pi pi-folder-open',
            command: () => {
              router.push('/system/menu')
            },
          },
        ],
      },
      {
        label: '基础数据',
        items: [
          {
            label: '组织架构',
            command: () => {
              router.push('/org/org')
            },
          },
          { label: '岗位', items: [{ label: '3rd Level 3' }, { label: '3rd Level 4' }] },
        ],
      },
      { separator: true },
      { label: 'Quit', icon: 'pi pi-sign-out' },
    ])
    return {
      leftDrawerOpen,
      toggleLeftDrawer() {
        leftDrawerOpen.value = !leftDrawerOpen.value
      },

      rightDrawerOpen,
      toggleRightDrawer() {
        rightDrawerOpen.value = !rightDrawerOpen.value
      },
      menuItems,
    }
  },
}
</script>
