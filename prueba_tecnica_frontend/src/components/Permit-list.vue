<template>
    <div class="row">
        <div class="col-md-3">
            <br/>
            <br/>
            <br/>
            <router-link to="/Create" class="btn btn-default">Crear permiso</router-link>
        </div>
         <div class="col-md-6">
             <br/>
             <br/>
             <h3 id="idh1">LISTADO PERMISOS</h3>
             <b/>
             <table class="table table-striped">
                 <tr>
                    <th>ID</th>    
                    <th>NOMBRE</th>    
                    <th>APELLIDO</th>    
                    <th>TIPO PERMISO</th>    
                    <th>FECHA PERMISO</th>   
                    <th></th>    
                    <th></th> 
                 </tr>  
                  <tr v-for="permit in permitList" :key="permit.id">
                    <td>{{permit.name}}</td>
                    <td>{{permit.lastname}}</td>
                    <td>{{permit.permitType}}</td>
                    <td>{{permit.permitDate}}</td>
                    <td class="btn btn-warning">Editar</td>
                    <td class="btn btn-danger" v-on:click="DeletePermit(permit.id)">Eliminar</td>
                </tr> 
             </table>   
        </div>
         <div class="col-md-3">

        </div>     
    </div>
</template>
<script>

import PermitService from '../services/PermitService'

export default {
     name: 'Permit-list',
    props: {
        permitList: []
    },  
    data(){
        return {
      
        }
    },
    methods:{
        GetAllPermits(){
             PermitService.getAll()
                .then(response => {
                    this.permitList = response.data;
                    console.log(response.data);
                })
                .catch(e => {
                    console.log(e);
                });
        },
        DeletePermit(id){
            PermitService.delete(id);
        }
    },
    computed:{

    },
    mounted(){
        this.GetAllPermits();
    } 
}
</script>
<style scoped>
 #idh1{
     text-align: center;
 }
</style>