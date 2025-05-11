import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
import { Notify } from 'quasar'

export const useOrgStore = defineStore('orgStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async getOrgTable(params) {
      const response = await api.get('/api/v{version}/Org/GetOrgTable', { params })
      return response
    },
    async getDepartTree(params) {
      const response = await api.get('/api/v{version}/Org/GetDepartTree', { params })
      return response.data
    },
    async AddOrg(menuForm) {
      await api
        .post('/api/v{version}/Org/AddOrg', menuForm)
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
    async DeleteOrg(dtIds) {
      console.log(dtIds)
      await api.delete('/api/v{version}/Org/DeleteOrg', { data: { DtIds: dtIds } })
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useOrgStore, import.meta.hot))
}
