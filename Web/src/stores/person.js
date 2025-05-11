import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'

export const usePersonStore = defineStore('personStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async GetResponsibles() {
      const response = await api.get('/api/v{version}/Person/GetResponsibles')
      return response
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(usePersonStore, import.meta.hot))
}
