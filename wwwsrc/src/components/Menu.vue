<template>
  <div class="menu">
    <h1>Hello Menu</h1>
    <ul>
      <li v-for="(item, i) in menu">
        <router-link :to="{
          name: 'Item',
          params: { id:i }
        }">
          {{item.name}} - ${{item.price}}
        </router-link>
      </li>
    </ul>
  </div>
</template>


<script>
import $ from 'jquery'
export default {
  name: 'menu',
  mounted(){
    // LETS TALK TO PORT 5000
    $.get('//localhost:5000/api/menu').then(data =>{
      this.menu = data
    })
  },
  data(){
    return {
      menu: []
    }
  },
  computed:{},
  methods:{},
  components:{}
}
</script>


<style scoped>

</style>