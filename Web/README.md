# Quasar App (web)

A Quasar Project

## Install the dependencies

```bash
yarn
# or
npm install
```

### Start the app in development mode (hot-code reloading, error reporting, etc.)

```bash
quasar dev
```

### Lint the files

```bash
yarn lint
# or
npm run lint
```

### Format the files

```bash
yarn format
# or
npm run format
```

### Build the app for production

```bash
quasar build
```

### Customize the configuration

See [Configuring quasar.config.js](https://v2.quasar.dev/quasar-cli-vite/quasar-config-js).

菜单的按钮，使用FormTable默认操作列的的三个按钮的，需要在菜单管理中配置三个按钮的，只要用就必须配置，三个按钮的编号是固定的
查看
v-permit="route.path + ':view'"
修改
v-permit="route.path + ':edit'"
删除
v-permit="route.path + ':delete'"

菜单的按钮，使用FormTable查询顶栏的的三个按钮的，需要在菜单管理中配置三个按钮的，只要用就必须配置，三个按钮的编号是固定的
查询
select
新增
add
删除
delete
