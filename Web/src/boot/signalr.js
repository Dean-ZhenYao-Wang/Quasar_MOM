import { defineBoot } from '#q-app/wrappers'
import signalRService from 'src/services/signalr'
import { getCurrentConfig } from 'src/config/signalr'
import { useCurrentUserStore } from 'src/stores/currentUser'
const userStore = useCurrentUserStore()

// "async" is optional;
// more info on params: https://v2.quasar.dev/quasar-cli-vite/boot-files
export default defineBoot(async ({ app }) => {
  // 获取当前环境的配置
  const config = getCurrentConfig()
  // 如果需要身份验证，动态添加token
  if (config.options.accessTokenFactory) {
    config.options.accessTokenFactory = () => {
      return userStore.jwtToken
    }
  }
  try {
    // 连接到SignalR Hub
    await signalRService.connect(config.hubUrl, config.options)

    // 全局注册SignalR服务
    app.config.globalProperties.$signalR = signalRService
    app.provide('signalR', signalRService)

    console.log('SignalR initialized successfully')
  } catch (error) {
    console.error('Failed to initialize SignalR:', error)
    console.log('Trying fallback configuration...')

    // fallback配置，完全禁用凭据
    const fallbackOptions = {
      skipNegotiation: true,
      transport: 1, // WebSockets only
      withCredentials: false,
    }

    try {
      await signalRService.connect(config.hubUrl, fallbackOptions)
      app.config.globalProperties.$signalR = signalRService
      app.provide('signalR', signalRService)
      console.log('SignalR initialized with fallback configuration')
    } catch (fallbackError) {
      console.error('SignalR fallback initialization failed:', fallbackError)
    }
  }
})
