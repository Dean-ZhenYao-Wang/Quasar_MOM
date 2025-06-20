import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
import { Notify } from 'quasar'

export const useMenuStore = defineStore('menuStore', {
  state: () => ({
    menuTree: [],
    childMenus: [],
    buttons: [],
  }),
  getters: {},
  actions: {
    async getMenuTree() {
      const response = await api.get('/api/v1/Menu/GetMenuTree')
      this.menuTree = response.data
    },
    async getChildMenus(dtId, id, name) {
      const response = await api.get(
        `/api/v1/Menu/GetMenuList?ParentMenuDtId=${dtId}&Id=${id}&Name=${name}`,
      )
      this.childMenus = response.data
    },
    async getButtonList(dtId) {
      const response = await api.get(`/api/v1/Menu/GetButtonList/${dtId}`)
      this.buttons = response.data
    },
    async buttonList(dtId) {
      const response = await api.get(`/api/v1/Menu/ButtonList/${dtId}`)
      this.buttons = response.data
    },
    async updateMenu(menuForm) {
      await api
        .put('/api/v1/Menu/UpdateMenu', menuForm)
        .then(() => {
          Notify.create({
            message: '菜单更新成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '菜单更新失败',
            color: 'positive',
          })
        })
    },
    async addMenu(menuForm) {
      await api
        .post('/api/v1/Menu/AddMenu', menuForm)
        .then(() => {
          Notify.create({
            message: '菜单添加成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '菜单添加失败',
            color: 'positive',
          })
        })
    },
    async deleteMenu(menu) {
      await api
        .delete('/api/v1/Menu/DeleteMenu', { data: { dtIds: [menu.dtId || menu] } })
        .then(() => {
          Notify.create({
            message: '菜单删除成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '菜单删除失败',
            color: 'positive',
          })
        })
    },
    async deleteMenus(dtIds) {
      await api
        .delete('/api/v1/Menu/DeleteMenu', { data: { dtIds: dtIds } })
        .then(() => {
          Notify.create({
            message: '菜单删除成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '菜单删除失败',
            color: 'positive',
          })
        })
    },
    async updateButton(buttonForm) {
      await api
        .put('/api/v1/Menu/UpdateButton', buttonForm)
        .then(() => {
          Notify.create({
            message: '按钮更新成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '按钮更新失败',
            color: 'positive',
          })
        })
    },
    async addButton(buttonForm) {
      await api
        .post('/api/v1/Menu/AddButton', buttonForm)
        .then(() => {
          Notify.create({
            message: '按钮添加成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '按钮添加失败',
            color: 'positive',
          })
        })
    },
    async deleteButton(button) {
      await api
        .delete('/api/v1/Menu/DeleteButton', { data: { dtIds: [button.dtId || button] } })
        .then(() => {
          Notify.create({
            message: '按钮删除成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '按钮删除失败',
            color: 'positive',
          })
        })
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useMenuStore, import.meta.hot))
}
