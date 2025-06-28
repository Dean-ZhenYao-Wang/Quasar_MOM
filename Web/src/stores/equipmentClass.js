import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
// import { Notify } from 'quasar'

export const useEquipmentClassStore = defineStore('equipmentClassStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async GetPaged(params) {
      const response = await api.get('/api/v1/EquipmentClass/GetPaged', {
        params,
      })
      return response
    },
    async IncludesRelations(dtId) {
      const response = await api.get('/api/v1/EquipmentClass/' + dtId + '/IncludesRelations')
      return response
    },
    async IsMadeUpOf(dtId) {
      const response = await api.get('/api/v1/EquipmentClass/' + dtId + '/IsMadeUpOf')
      return response
    },
    async Add(data) {
      const response = await api.post('/api/v1/EquipmentClass/Add', data)
      return response
    },
    async Update(data) {
      const response = await api.put('/api/v1/EquipmentClass/Update', data)
      return response
    },
    async Delete(dtIds) {
      const response = await api.delete('/api/v1/EquipmentClass/Delete', {
        data: { DtIds: dtIds },
      })
      return response
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useEquipmentClassStore, import.meta.hot))
}
