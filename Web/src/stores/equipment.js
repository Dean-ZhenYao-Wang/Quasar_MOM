import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'

export const useEquipmentStore = defineStore('equipmentStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async GetPaged(params) {
      const response = await api.get('/api/v1/Equipment/GetPaged', {
        params,
      })
      return response
    },
    async Add(data) {
      const response = await api.post('/api/v1/Equipment/Add', data)
      return response
    },
    async Update(data) {
      const response = await api.put('/api/v1/Equipment/Update', data)
      return response
    },
    async Delete(dtIds) {
      const response = await api.delete('/api/v1/Equipment/Delete', {
        data: { DtIds: dtIds },
      })
      return response
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useEquipmentStore, import.meta.hot))
}
