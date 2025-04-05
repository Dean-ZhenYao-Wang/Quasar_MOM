import { defineBoot } from '#q-app/wrappers'
import axios from 'axios'
// Be careful when using SSR for cross-request state pollution
// due to creating a Singleton instance here;
// If any client changes this (global) instance, it might be a
// good idea to move this instance creation inside of the
// "export default () => {}" function below (which runs individually
// for each client)
const api = axios.create({ baseURL: process.env.API_BASE_URL })

export default defineBoot(({ app }) => {
  // 请求拦截器
  api.interceptors.request.use(
    (config) => {
      config.url = config.url
        .replace(/{version}/g, process.env.API_VERSION)
        .replace(/\/v\{version\}/, `/v${process.env.API_VERSION}`)
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
  // 响应拦截器 - 版本失效处理
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
      $q.notify({
        color: 'negative',
        message: error.response?.data?.message || '请求失败',
        icon: 'report_problem',
      })
      return Promise.reject(error)
    },
  )

  // for use inside Vue files (Options API) through this.$axios and this.$api

  app.config.globalProperties.$axios = axios
  // ^ ^ ^ this will allow you to use this.$axios (for Vue Options API form)
  //       so you won't necessarily have to import axios in each vue file

  app.config.globalProperties.$api = api
  // ^ ^ ^ this will allow you to use this.$api (for Vue Options API form)
  //       so you can easily perform requests against your app's API
})

export { axios, api }
