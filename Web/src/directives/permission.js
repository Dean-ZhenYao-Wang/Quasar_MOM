import { useCurrentUserStore } from 'src/stores/currentUser'
const store = useCurrentUserStore()
export default {
  mounted(el, binding) {
    const { value } = binding
    const permissions = store.roles || []
    const superPermission = '*:*:*' // 超级管理员通配符
    if (!(permissions.includes(superPermission) || permissions.some((p) => p == value))) {
      el.parentNode?.removeChild(el)
    }
  },
}
