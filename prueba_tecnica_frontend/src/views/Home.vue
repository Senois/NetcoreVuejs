<template>
  <div class="home">
    <br/>
    <br/>
    <br/>
    <br/>
    <h1 id="tituloHome" class="display-1">App NetCore/Vue JS</h1>
    <Main />
  </div>
</template>

<script>

import Main from '@/components/Main.vue'

export default {
  name: 'Home',
  components: {
    Main
  }
}
</script>

<style scoped>
/*Centrar titulo del home*/
    #tituloHome{
      text-align: center;
    }
</style>
