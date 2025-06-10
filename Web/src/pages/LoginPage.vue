<template>
  <div class="chat-page">
    <div class="q-pa-md">
      <q-card class="chat-container">
        <q-card-section>
          <div class="text-h6">实时聊天</div>
          <q-chip
            :color="connectionStatus === 'Connected' ? 'positive' : 'negative'"
            text-color="white"
            :label="connectionStatus"
          />
        </q-card-section>

        <q-separator />

        <q-card-section class="chat-messages">
          <div v-for="message in messages" :key="message.id" class="message-item q-mb-sm">
            <q-chat-message
              :text="[message.text]"
              :sent="message.sent"
              :name="message.user"
              :stamp="message.timestamp"
            />
          </div>
        </q-card-section>

        <q-separator />

        <q-card-section>
          <div class="row q-gutter-sm">
            <q-input
              v-model="newMessage"
              filled
              placeholder="输入消息..."
              class="col"
              @keypress.enter="sendMessage"
              :disable="connectionStatus !== 'Connected'"
            />
            <q-btn
              color="primary"
              icon="send"
              @click="sendMessage"
              :disable="!newMessage.trim() || connectionStatus !== 'Connected'"
            />
          </div>
        </q-card-section>
      </q-card>
    </div>
  </div>
</template>

<script>
import { defineComponent, ref, onMounted, onUnmounted, inject } from 'vue'
import { useQuasar } from 'quasar'

export default defineComponent({
  name: 'ChatPage',
  setup() {
    const $q = useQuasar()
    const signalR = inject('signalR')

    const messages = ref([])
    const newMessage = ref('')
    const connectionStatus = ref('Disconnected')
    const currentUser = ref('User1') // 替换为实际用户信息

    // 发送消息
    const sendMessage = async () => {
      if (!newMessage.value.trim() || !signalR.isConnected) return

      try {
        // 调用服务器方法
        await signalR.invoke('SendMessage', currentUser.value, newMessage.value)
        newMessage.value = ''
      } catch (error) {
        console.error('发送消息失败:', error)
        $q.notify({
          color: 'negative',
          message: '发送消息失败',
          icon: 'error',
        })
      }
    }

    // 接收消息的回调
    const onReceiveMessage = (user, message, timestamp) => {
      messages.value.push({
        id: Date.now() + Math.random(),
        user,
        text: message,
        timestamp: new Date(timestamp).toLocaleTimeString(),
        sent: user === currentUser.value,
      })
    }

    // 用户加入回调
    const onUserJoined = (user) => {
      $q.notify({
        color: 'positive',
        message: `${user} 加入了聊天`,
        icon: 'person_add',
      })
    }

    // 用户离开回调
    const onUserLeft = (user) => {
      $q.notify({
        color: 'info',
        message: `${user} 离开了聊天`,
        icon: 'person_remove',
      })
    }

    // 更新连接状态
    const updateConnectionStatus = () => {
      connectionStatus.value = signalR.getConnectionState()
    }

    onMounted(async () => {
      if (signalR) {
        // 设置事件监听
        signalR.on('ReceiveMessage', onReceiveMessage)
        signalR.on('UserJoined', onUserJoined)
        signalR.on('UserLeft', onUserLeft)

        // 监听连接状态变化
        const originalOnReconnecting = signalR.connection?.onreconnecting
        const originalOnReconnected = signalR.connection?.onreconnected
        const originalOnClose = signalR.connection?.onclose

        if (signalR.connection) {
          signalR.connection.onreconnecting(() => {
            updateConnectionStatus()
            if (originalOnReconnecting) originalOnReconnecting()
          })

          signalR.connection.onreconnected(() => {
            updateConnectionStatus()
            if (originalOnReconnected) originalOnReconnected()
          })

          signalR.connection.onclose(() => {
            updateConnectionStatus()
            if (originalOnClose) originalOnClose()
          })
        }

        // 初始化连接状态
        updateConnectionStatus()

        // 加入聊天组
        try {
          if (signalR.isConnected) {
            await signalR.invoke('JoinChat', currentUser.value)
          }
        } catch (error) {
          console.error('加入聊天失败:', error)
        }
      }
    })

    onUnmounted(() => {
      if (signalR) {
        // 清理事件监听
        signalR.off('ReceiveMessage', onReceiveMessage)
        signalR.off('UserJoined', onUserJoined)
        signalR.off('UserLeft', onUserLeft)

        // 离开聊天组
        try {
          if (signalR.isConnected) {
            signalR.invoke('LeaveChat', currentUser.value)
          }
        } catch (error) {
          console.error('离开聊天失败:', error)
        }
      }
    })

    return {
      messages,
      newMessage,
      connectionStatus,
      sendMessage,
    }
  },
})
</script>

<style scoped>
.chat-container {
  max-width: 800px;
  margin: 0 auto;
}

.chat-messages {
  height: 400px;
  overflow-y: auto;
}

.message-item {
  margin-bottom: 8px;
}
</style>
