import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
import { Notify } from 'quasar'

export const useHierarchyScopeStore = defineStore('hierarchyScopeStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async getOrgTable(params) {
      const response = await api.get('/api/v1/HierarchyScope/GetOrgTable', { params })
      return response
    },
    async getEnterpriseTable(params) {
      const response = await api.get('/api/v1/HierarchyScope/GetEnterpriseTable', { params })
      return response
    },
    async getFactoryTable(params) {
      const response = await api.get('/api/v1/HierarchyScope/GetFactoryTable', { params })
      return response
    },
    async getDepartTree(params) {
      const response = await api.get('/api/v1/HierarchyScope/GetDepartTree', { params })
      return response.data
    },
    async AddHierarchyScope(payload) {
      await api
        .post('/api/v1/HierarchyScope/AddHierarchyScope', payload)
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
    async UpdateHierarchyScope(payload) {
      await api
        .put('/api/v1/HierarchyScope/UpdateHierarchyScope ', payload)
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
    async DeleteHierarchyScope(dtIds) {
      await api.delete('/api/v1/HierarchyScope/DeleteHierarchyScope', { data: { DtIds: dtIds } })
    },
    async SettingPermission(payload) {
      await api.post('/api/v1/HierarchyScope/SettingPermission', payload)
    },
    async Permission(dtId) {
      return await api.get('/api/v1/HierarchyScope/Permission?orgDtId=' + dtId)
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useHierarchyScopeStore, import.meta.hot))
}
