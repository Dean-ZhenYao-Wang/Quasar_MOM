import { defineBoot } from '#q-app/wrappers'
import axios from 'axios'
import { useCurrentUserStore } from 'src/stores/currentUser'
import { Notify } from 'quasar'

const api = axios.create({ baseURL: process.env.API_BASE_URL })

export default defineBoot(({ app, router }) => {
  const userStore = useCurrentUserStore()
  // 初始化用户信息
  userStore.initFromLocalStorage()
  // 添加 router 参数
  // 请求拦截器
  api.interceptors.request.use(
    (config) => {
      // 添加 token 到请求头
      const token = userStore.jwtToken
      if (token) {
        config.headers.Authorization = `Bearer ${token}`
      }

      return config
    },
    (error) => {
      Notify.create({
        type: 'negative',
        message: error,
        position: 'top',
        timeout: 2000,
      })
      return Promise.reject(error)
    },
  )

  // 响应拦截器
  api.interceptors.response.use(
    (response) => {
      if (!response.data.success) {
        response.data.errors.forEach((element) => {
          Notify.create({
            type: 'negative',
            message: element.description,
            caption: process.env.DEV ? `状态码: ${element.errorCode}` : '',
            position: 'top',
            timeout: 2000,
          })
        })
        return Promise.reject(response.data)
      }
      return response.data
    },
    (error) => {
      if (error.response?.status === 401) {
        // 清除本地存储的认证信息
        userStore.jwtToken = ''

        // 显示通知
        Notify.create({
          type: 'negative',
          message: '登录已过期，请重新登录',
          position: 'top',
          timeout: 2000,
        })

        // 跳转到登录页面
        router.push({
          path: '/login',
          query: { redirect: router.currentRoute.value.fullPath },
        })

        return Promise.reject(error)
      }

      // 其他错误处理
      Notify.create({
        color: 'negative',
        message: error.response?.data?.message || '请求失败',
        icon: 'report_problem',
      })

      return Promise.reject(error)
    },
  )

  app.config.globalProperties.$axios = axios
  app.config.globalProperties.$api = api
})

export { axios, api }
