import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr'

class SignalRService {
  constructor() {
    this.connection = null
    this.isConnected = false
    this.callbacks = new Map()
  }

  // 初始化连接
  async connect(hubUrl, options = {}) {
    try {
      // 创建连接
      this.connection = new HubConnectionBuilder()
        .withUrl(hubUrl, options)
        .withAutomaticReconnect()
        .configureLogging(LogLevel.Information)
        .build()

      // 设置连接事件
      this.connection.onreconnecting(() => {
        console.log('SignalR reconnecting...')
        this.isConnected = false
      })

      this.connection.onreconnected(() => {
        console.log('SignalR reconnected')
        this.isConnected = true
      })

      this.connection.onclose(() => {
        console.log('SignalR connection closed')
        this.isConnected = false
      })

      // 启动连接
      await this.connection.start()
      this.isConnected = true
      console.log('SignalR Connected')

      return this.connection
    } catch (error) {
      console.error('SignalR Connection Error:', error)
      throw error
    }
  }

  // 断开连接
  async disconnect() {
    if (this.connection) {
      await this.connection.stop()
      this.connection = null
      this.isConnected = false
      this.callbacks.clear()
    }
  }

  // 监听服务器消息
  on(methodName, callback) {
    if (this.connection) {
      this.connection.on(methodName, callback)

      // 保存回调以便后续管理
      if (!this.callbacks.has(methodName)) {
        this.callbacks.set(methodName, [])
      }
      this.callbacks.get(methodName).push(callback)
    }
  }

  // 取消监听
  off(methodName, callback = null) {
    if (this.connection) {
      if (callback) {
        this.connection.off(methodName, callback)

        // 从回调列表中移除
        const callbacks = this.callbacks.get(methodName)
        if (callbacks) {
          const index = callbacks.indexOf(callback)
          if (index > -1) {
            callbacks.splice(index, 1)
          }
        }
      } else {
        this.connection.off(methodName)
        this.callbacks.delete(methodName)
      }
    }
  }

  // 发送消息到服务器
  async invoke(methodName, ...args) {
    if (this.connection && this.isConnected) {
      try {
        return await this.connection.invoke(methodName, ...args)
      } catch (error) {
        console.error(`Error invoking ${methodName}:`, error)
        throw error
      }
    } else {
      throw new Error('SignalR connection is not established')
    }
  }

  // 发送消息到服务器（无返回值）
  async send(methodName, ...args) {
    if (this.connection && this.isConnected) {
      try {
        await this.connection.send(methodName, ...args)
      } catch (error) {
        console.error(`Error sending ${methodName}:`, error)
        throw error
      }
    } else {
      throw new Error('SignalR connection is not established')
    }
  }

  // 获取连接状态
  getConnectionState() {
    return this.connection ? this.connection.state : 'Disconnected'
  }

  // 获取连接ID
  getConnectionId() {
    return this.connection ? this.connection.connectionId : null
  }
}

// 导出单例实例
export default new SignalRService()
