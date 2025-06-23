import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
// import { Notify } from 'quasar'

export const usePhysicalAssetAndEquipmentStore = defineStore(
  'physicalAssetAndEquipmentStoreStore',
  {
    state: () => ({}),
    getters: {},
    actions: {
      async GetPagedEquipmentClass(params) {
        const response = await api.get('/api/v1/EquipmentClass/GetPagedEquipmentClass', {
          params,
        })
        return response
      },
    },
  },
)

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(usePhysicalAssetAndEquipmentStore, import.meta.hot))
}
