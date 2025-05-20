import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
import { Notify } from 'quasar'

export const useTeamStore = defineStore('teamStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async selectOptions() {
      const response = await api.get('/api/v1/Team/SelectOptions')
      return response.data
    },
    async GetPaged(params) {
      const response = await api.get('/api/v1/Team/GetPaged', { params })
      return response.data
    },
    async Add(payload) {
      await api
        .post('/api/v1/Team/Add', payload)
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
        .post('/api/v1/Team/Update ', payload)
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
      await api.delete('/api/v1/Team/Delete', { data: { DtIds: dtIds } })
    },
    async SettingPermission(payload) {
      await api.post('/api/v1/Team/SettingPermission', payload)
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useTeamStore, import.meta.hot))
}
