import { defineBoot } from '#q-app/wrappers'
const components = import.meta.glob('../components/*.vue', { eager: true })
// "async" is optional;
// more info on params: https://v2.quasar.dev/quasar-cli-vite/boot-files
export default defineBoot(({ app }) => {
  for (const path in components) {
    const comp = components[path]
    const componentConfig = comp.default

    if (!componentConfig) continue

    // 优先用组件的 name，否则用文件名
    const name = componentConfig.name || path.split('/').pop()?.replace('.vue', '')

    if (name) {
      app.component(name, componentConfig)
    }
  }
})
