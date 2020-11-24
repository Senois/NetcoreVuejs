<template>
  <div class="home">
    <br/>
    <br/>
    <br/>
    <br/>
    <h3 id="tituloCreate">EDICION DE PERMISOS</h3>
    <br/>
    <br/>
    <CreatePermit />
  </div>
</template>

<script>

import EditPermit from '@/components/Edit-permit.vue'

export default {
  name: 'Editar',
  components: {
    EditPermit
  }
}
</script>

<style scoped>
/*Centrar titulo*/
    #tituloCreate{
      text-align: center;
    }
</style>
