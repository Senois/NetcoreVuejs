<template>
  <div class="home">
    <br/>
    <br/>
    <br/>
    <br/>
    <h3 id="tituloCreate">CREACION DE PERMISOS</h3>
    <br/>
    <br/>
    <CreatePermit />
  </div>
</template>

<script>

import CreatePermit from '@/components/Create-permit.vue'

export default {
  name: 'Crear',
  components: {
    CreatePermit
  }
}
</script>

<style scoped>
/*Centrar titulo*/
    #tituloCreate{
      text-align: center;
    }
</style>
