<script setup>
 import axios from 'axios'
 import { onMounted, ref } from 'vue';
 const todos = ref([]);

 onMounted( () => {
  axios.get('http://localhost:3000/todos')
  .then(resp => {
    todos.value = resp.data
    console.log(todos.value)
  })
 })
 const deleteTask = (id) => {
  //console.log("Törlés id alapján",id);
  todos.value = todos.value.filter(x => x.id != id)
  axios.delete('http://localhost:3000/todos/'+id)
  .then(resp => console.log(resp))
 }
</script>

<template>
  <div class="container">
    <h4 v-if="todos.length == 0">Nincs feladat</h4>
    <table v-else class="table">
      <tr>
        <th>Feladat</th>
        <th>Határidő</th>
        <th>Művelet</th>
      </tr>
      <tr v-for="t in todos">
        <td>{{ t.task }}</td>
        <td>{{ t.deadline }}</td>
        <td><span class="btn btn-danger" @click="deleteTask(t.id)">❌</span></td>
      </tr>
    </table>
  </div>
</template>
