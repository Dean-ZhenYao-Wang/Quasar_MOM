import { defineStore, acceptHMRUpdate } from 'pinia'
import { api } from 'boot/axios'

export const useCurrentUserStore = defineStore('currentUserStore', {
  state: () => ({
    name: '',
    email: '',
    photo: '',
    jwt: '',
    roles: [],
  }),
  getters: {
    userName: (state) => state.name,
    photoPath: (state) => state.photo,
    jwtToken: (state) => state.jwt,
  },
  actions: {
    async Login(userName, passWord) {
      const response = await api.post('/api/v1/Account/Authenticate', {
        username: userName,
        password: passWord,
      })
      this.name = response.data.name
      this.photo = response.data.photo
      this.jwt = response.data.jwToken
      this.email = response.data.email
      this.roles = response.data.roles
      return true
    },
    async ChangePassword(current_hashHex, confirm_hashHex) {
      await api.put('/api/v1/Account/ChangePassword', {
        password: current_hashHex,
        confirmPassword: confirm_hashHex,
      })
    },
  },
})

if (import.meta.hot) {
  import.meta.hot.accept(acceptHMRUpdate(useCurrentUserStore, import.meta.hot))
}
