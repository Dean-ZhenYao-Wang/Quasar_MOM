import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
import { Notify } from 'quasar'

export const usePersonStore = defineStore('personStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async GetResponsibles() {
      const response = await api.get('/api/v1/Person/GetResponsibles')
      return response
    },
    async GetPaged(params) {
      const response = await api.get('/api/v1/Person/GetPaged', { params })
      return response
    },
    async Add(payload) {
      await api
        .post('/api/v1/Person/Add', payload)
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
    async Update(payload) {
      await api
        .put('/api/v1/Person/Update ', payload)
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
    async Delete(dtIds) {
      await api.delete('/api/v1/Person/Delete', { data: { DtIds: dtIds } })
    },
    async SettingPermission(payload) {
      await api.post('/api/v1/Person/SettingPermission', payload)
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(usePersonStore, import.meta.hot))
}
