<template>
    <div class="row">
        <div class="col-md-3">

        </div>
         <div class="col-md-6">
             <br/>
              <form>
                  <label><b>Nombre:</b></label>  
                  <input type="text" placeholder="Nombre" v-model="name" class="form-control" />
                  <label>Apellido:</label>  
                  <input type="text" placeholder="Apellido" v-model="lastName" class="form-control" />
                  <label>Tipo permiso:</label>  
                  <input type="text" placeholder="Tipo permiso" v-model="permitType" class="form-control" />
                  <label>Fecha:</label>  
                  <input type="Date" class="form-control" v-model="permitDate" /><br/>
                  <center><button class="btn btn-primary" v-on:click="UpdatePermit()">Actualizar</button></center>
             </form>
        </div>
         <div class="col-md-3">

        </div>     
    </div>
</template>
<script>

export default {
     name: 'Edit-permit',
    props: {

    },  
    data(){
        return {
      
        }
    },
    methods:{
        UpdatePermit(permit){
             PermitService.update(permit);         
        }
    },
    computed:{

    } 
}
</script>
<style scoped>

</style>