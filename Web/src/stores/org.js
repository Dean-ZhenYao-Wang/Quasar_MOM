import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
import { Notify } from 'quasar'

export const useOrgStore = defineStore('orgStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async getOrgTable(params) {
      const response = await api.get('/api/v1/Org/GetOrgTable', { params })
      return response
    },
    async getDepartTree(params) {
      const response = await api.get('/api/v1/Org/GetDepartTree', { params })
      return response.data
    },
    async AddOrg(payload) {
      await api
        .post('/api/v1/Org/AddOrg', payload)
        .then(() => {
          Notify.create({
            message: '添加成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '添加失败',
            color: 'positive',
          })
        })
    },
    async UpdateOrg(payload) {
      await api
        .put('/api/v1/Org/UpdateOrg ', payload)
        .then(() => {
          Notify.create({
            message: '修改成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '修改失败',
            color: 'positive',
          })
        })
    },
    async DeleteOrg(dtIds) {
      await api.delete('/api/v1/Org/DeleteOrg', { data: { DtIds: dtIds } })
    },
    async SettingPermission(payload) {
      await api.post('/api/v1/Org/SettingPermission', payload)
    },
    async Permission(dtId) {
      return await api.get('/api/v1/Org/Permission?orgDtId=' + dtId)
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useOrgStore, import.meta.hot))
}
