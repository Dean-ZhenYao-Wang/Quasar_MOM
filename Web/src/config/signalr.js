// src/config/signalr.js
import { HttpTransportType } from '@microsoft/signalr'
import { useCurrentUserStore } from 'src/stores/currentUser'

const userStore = useCurrentUserStore()
export const signalRConfig = {
  // 开发环境配置
  development: {
    hubUrl: 'http://localhost:5144/notificationhub',
    options: {
      // 跳过协商以避免某些CORS问题
      skipNegotiation: true,
      // 仅使用WebSockets传输
      transport: HttpTransportType.WebSockets,
      // 禁用凭据以避免CORS问题
      withCredentials: false,
      // 自定义头部
      headers: {},
      // 超时设置
      timeout: 30000,
    },
  },

  // 生产环境配置
  production: {
    hubUrl: 'https://your-api-domain.com/notificationhub',
    options: {
      skipNegotiation: false,
      transport: HttpTransportType.WebSockets | HttpTransportType.ServerSentEvents,
      withCredentials: true,
      accessTokenFactory: () => {
        return userStore.jwtToken
      },
      headers: {
        Authorization: `Bearer ${userStore.jwtToken}`,
      },
    },
  },
}

// 获取当前环境配置
export const getCurrentConfig = () => {
  const isDev = process.env.NODE_ENV === 'development'
  return isDev ? signalRConfig.development : signalRConfig.production
}
