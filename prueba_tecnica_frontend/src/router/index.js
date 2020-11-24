import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import Permit from '../views/Permit.vue'
import CreatePermit from '../views/Create.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/Permiso',
    name: 'Permiso',
    component: Permit
  },
  {
    path: '/Create',
    name: 'Crear permiso',
    component: CreatePermit
  },
  {
    path: '/Edit',
    name: 'Editar permiso',
    component: CreatePermit
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
