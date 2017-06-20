<template>
  <div class="item">
    <h1>{{item.name}} - {{item.price}}</h1>
    <p>{{item.description}}</p>
  </div>
</template>


<script>
import $ from 'jquery'
export default {
  name: 'item',
  mounted(){
    $.get('//localhost:5000/api/menu/' + this.$route.params.id).then(item =>{
      this.item = item
    })
  },
  data(){
    return {
      item: {}
    }
  },
  computed:{},
  methods:{},
  components:{}
}
</script>


<style scoped>

</style>