import MainLayout from 'layouts/MainLayout.vue'
const routes = [
  {
    path: '/',
    component: () => MainLayout,
    meta: { requiresAuth: true },
    children: [
      { path: '', component: () => import('pages/IndexPage.vue') },
      { path: 'system/menu', component: () => import('pages/Menu/MenuPage.vue') },
      { path: 'org/org', component: () => import('pages/Org/OrgPage.vue') },
    ],
  },
  {
    path: '/login',
    component: () => import('layouts/BlankLayout.vue'),
    meta: { guestOnly: true },
    children: [{ path: '', component: () => import('pages/LoginPage.vue') }],
  },
  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/ErrorNotFound.vue'),
  },
]

export default routes
