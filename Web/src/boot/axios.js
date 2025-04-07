import { defineBoot } from '#q-app/wrappers'
import axios from 'axios'

const api = axios.create({ baseURL: process.env.API_BASE_URL })

export default defineBoot(({ app, router }) => {
  // 添加 router 参数
  // 请求拦截器
  api.interceptors.request.use(
    (config) => {
      config.url = config.url
        .replace(/{version}/g, process.env.API_VERSION)
        .replace(/\/v\{version\}/, `/v${process.env.API_VERSION}`)

      // 添加 token 到请求头
      const token = localStorage.getItem('authToken') || sessionStorage.getItem('authToken')
      if (token) {
        config.headers.Authorization = `Bearer ${token}`
      }

      return config
    },
    (error) => {
      const $q = app.config.globalProperties.$q
      $q.notify({
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
        const $q = app.config.globalProperties.$q
        response.data.errors.forEach((element) => {
          $q.notify({
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
      const $q = app.config.globalProperties.$q

      if (error.response?.status === 401) {
        // 清除本地存储的认证信息
        localStorage.removeItem('authToken')
        sessionStorage.removeItem('authToken')

        // 显示通知
        $q.notify({
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
        // console.log('Router instance available:', !!router)
        // console.log('Current route:', router.currentRoute.value)
        // router
        //   .push('/login')
        //   .then(() => {
        //     console.log('Navigation succeeded')
        //   })
        //   .catch((err) => {
        //     console.error('Navigation failed:', err)
        //   })

        return Promise.reject(error)
      }

      // 其他错误处理
      $q.notify({
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
