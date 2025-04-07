<template>
  <div class="login-container flex flex-center">
    <q-card class="login-card">
      <q-card-section>
        <h5 class="text-h5 q-my-md">系统登录</h5>

        <q-form @submit="handleLogin">
          <q-input
            v-model="username"
            label="用户名"
            outlined
            ref="usernameInput"
            lazy-rules
            :rules="[
              (val) => !!val || '必须填写用户名',
              (val) => val.length >= 4 || '用户名至少4位',
            ]"
          />

          <q-input
            v-model="password"
            label="密码"
            outlined
            :type="showPassword ? 'text' : 'password'"
            lazy-rules
            :rules="[
              (val) => !!val || '必须填写密码',
              (val) => val.length >= 6 || '密码至少6位',
              (val) => /[A-Z]/.test(val) || '需包含大写字母',
              (val) => /\d/.test(val) || '需包含数字',
            ]"
          >
            <template v-slot:append>
              <q-icon
                :name="showPassword ? 'visibility_off' : 'visibility'"
                @click="showPassword = !showPassword"
                class="cursor-pointer"
              />
            </template>
          </q-input>

          <q-btn
            label="登录"
            type="submit"
            color="primary"
            class="full-width q-mt-md"
            :loading="submitting"
            :disable="submitting"
          />
        </q-form>
      </q-card-section>
    </q-card>
  </div>
</template>

<script>
import { debounce } from 'quasar'

export default {
  data() {
    return {
      username: '',
      password: '',
      showPassword: false,
      submitting: false,
    }
  },
  mounted() {
    this.$nextTick(() => {
      this.$refs.usernameInput.focus()
    })
  },
  beforeUnmount() {
    this.password = ''
  },
  methods: {
    handleLogin: debounce(
      async function () {
        if (this.submitting) return

        try {
          this.submitting = true

          // 将字符串转换为ArrayBuffer
          const msgBuffer = new TextEncoder().encode(this.password)
          let hashHex = ''
          // 使用SubtleCrypto API进行SHA-1哈希处理
          window.crypto.subtle
            .digest('SHA-1', msgBuffer)
            .then(async (hashBuffer) => {
              // 将ArrayBuffer转换为十六进制字符串
              const hashArray = Array.from(new Uint8Array(hashBuffer))
              hashHex = hashArray.map((b) => b.toString(16).padStart(2, '0')).join('')

              const response = await this.$api.post('/api/v{version}/Account/Authenticate', {
                username: this.username,
                password: hashHex.toUpperCase(),
              })
              // 安全存储token
              localStorage.setItem('authToken', response.data.jwToken)
              const redirect = this.$route.query.redirect || '/'
              this.$router.push(redirect)
            })
            .catch((err) =>
              this.$q.notify({
                type: 'negative',
                message: err,
                position: 'top',
                timeout: 2000,
              }),
            )
        } finally {
          this.submitting = false
        }
      },
      500,
      true,
    ),
  },
}
</script>

<style lang="scss" scoped>
:deep(.q-field__label) {
  color: rgba($primary, 0.7);
  transition: all 0.3s ease;

  .body--dark & {
    color: rgba($light, 0.6) !important;
  }
}

.login-card {
  width: 100%;
  max-width: 400px;
  transition: transform 0.3s ease;

  &:hover {
    transform: translateY(-5px);
  }

  @media (max-width: $breakpoint-xs) {
    width: 95%;
    margin: 0 10px;

    :deep(.text-h5) {
      font-size: 1.25rem;
    }
  }
}
</style>
