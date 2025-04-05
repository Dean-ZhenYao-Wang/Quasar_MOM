<template>
  <component :is="currentLayout">
    <router-view v-slot="{ Component }">
      <transition name="fade" mode="out-in">
        <component :is="Component" />
      </transition>
    </router-view>
  </component>
</template>

<script>
import { computed } from 'vue'
import { useRoute } from 'vue-router'
import MainLayout from 'layouts/MainLayout.vue'
import BlankLayout from 'layouts/BlankLayout.vue'

export default {
  setup() {
    const route = useRoute()

    const currentLayout = computed(() => {
      const layoutMeta = route.meta.layout
      return layoutMeta === 'BlankLayout' ? BlankLayout : MainLayout
    })

    return { currentLayout }
  },
}
</script>

<style lang="scss">
// 过渡动画
.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.2s;
}

.fade-enter-from,
.fade-leave-to {
  opacity: 0;
}

// 登录页样式
.login-card {
  width: 90%;
  max-width: 400px;
  margin: 2rem auto;
  padding: 2rem;

  @media (min-width: $breakpoint-sm-min) {
    margin-top: 5rem;
  }

  .q-field {
    margin-bottom: 1.5rem;
  }
}
</style>
