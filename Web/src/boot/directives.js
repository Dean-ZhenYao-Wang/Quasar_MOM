import { defineBoot } from '#q-app/wrappers'
import permissionDirective from 'src/directives/permission'

// "async" is optional;
// more info on params: https://v2.quasar.dev/quasar-cli-vite/boot-files
export default defineBoot(({ app }) => {
  // something to do
  app.directive('permit', permissionDirective)
})
