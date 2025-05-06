import { defineRouter } from '#q-app/wrappers'
import {
  createRouter,
  createMemoryHistory,
  createWebHistory,
  createWebHashHistory,
} from 'vue-router'
import routes from './routes'
import { useCurrentUserStore } from 'src/stores/currentUser'

/*
 * If not building with SSR mode, you can
 * directly export the Router instantiation;
 *
 * The function below can be async too; either use
 * async/await or return a Promise which resolves
 * with the Router instance.
 */

export default defineRouter(function (/* { store, ssrContext } */) {
  const createHistory = process.env.SERVER
    ? createMemoryHistory
    : process.env.VUE_ROUTER_MODE === 'history'
      ? createWebHistory
      : createWebHashHistory

  const Router = createRouter({
    scrollBehavior: () => ({ left: 0, top: 0 }),
    routes,

    // Leave this as is and make changes in quasar.conf.js instead!
    // quasar.conf.js -> build -> vueRouterMode
    // quasar.conf.js -> build -> publicPath
    history: createHistory(process.env.VUE_ROUTER_BASE),
  })

  const userStore = useCurrentUserStore()
  // 添加路由守卫
  Router.beforeEach((to, from, next) => {
    console.log(userStore)
    const isAuthenticated =
      userStore.jwtToken !== null && userStore.jwtToken != undefined && userStore.jwtToken != '' // 替换为你的认证检查方法
    // 访问登录页时如果已登录则重定向
    if (to.path === '/login' && isAuthenticated) {
      next('/')
      return
    }
    if (to.matched.some((record) => record.meta.requiresAuth)) {
      // 认证检查逻辑
      // 需要认证的非登录页面
      if (to.meta.requiresAuth && !isAuthenticated) {
        next({
          path: '/login',
          query: { redirect: to.fullPath },
        })
        return
      }
    }
    next()
  })

  return Router
})
