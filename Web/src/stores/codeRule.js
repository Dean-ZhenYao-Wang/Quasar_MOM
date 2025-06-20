import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'
import { Notify } from 'quasar'

export const useCodeRuleStore = defineStore('codeRuleStore', {
  state: () => ({}),
  getters: {},
  actions: {
    async GetPaged(params) {
      const response = await api.get('/api/v1/CodingRule/GetPaged', { params })
      return response
    },
    async RegisterRule(payload) {
      await api
        .post('/api/v1/CodingRule/RegisterRule', payload)
        .then(() => {
          Notify.create({
            message: '操作成功',
            color: 'positive',
          })
        })
        .catch(() => {
          Notify.create({
            message: '操作失败',
            color: 'positive',
          })
        })
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useCodeRuleStore, import.meta.hot))
}
