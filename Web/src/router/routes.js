import MainLayout from 'layouts/MainLayout.vue'
const routes = [
  {
    path: '/',
    component: () => MainLayout,
    meta: { requiresAuth: true },
    children: [
      { path: '', component: () => import('pages/IndexPage.vue') },
      {
        path: 'system',
        children: [
          { path: 'menu', component: () => import('pages/System/Menu/MenuPage.vue') },
          {
            path: 'numberrules',
            component: () => import('pages/System/NumBerrules/NumBerrulesPage.vue'),
          },
        ],
      },
      {
        path: 'org',
        children: [
          { path: 'org', component: () => import('pages/Org/OrgPage.vue') },
          { path: 'position', component: () => import('pages/Org/PositionPage.vue') },
          { path: 'team', component: () => import('pages/Org/TeamPage.vue') },
        ],
      },
      {
        path: 'personnel',
        component: () => import('pages/Person/PersonnelPage.vue'),
      },
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
