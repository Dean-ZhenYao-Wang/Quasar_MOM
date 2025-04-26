const routes = [
  {
    path: '/',
    // component: () => import('layouts/MainLayout.vue'),
    meta: { requiresAuth: true }, // 需要认证
    children: [
      { path: '', component: () => import('pages/IndexPage.vue') },
      { path: '/system/menu', component: () => import('pages/Menu/MenuPage.vue') },
      { path: '/org/org', component: () => import('pages/Org/OrgPage.vue') },
    ],
  },
  {
    path: '/login',
    component: () => import('pages/LoginPage.vue'),
    meta: {
      layout: 'BlankLayout', // 指定空白布局
      guestOnly: true, // 仅允许未登录用户访问
    },
  },
  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/ErrorNotFound.vue'),
  },
]

export default routes
