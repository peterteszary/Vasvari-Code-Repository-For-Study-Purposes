<script setup>
import { onMounted, ref } from 'vue';
import axios from 'axios';

const posts = ref([]);
const comments = ref([]); 

onMounted(() => {
  fetch('http://localhost:3000/posts')
    .then(resp => resp.json())
    .then(json => {
      console.log(json);
      posts.value = json;
    });
});

onMounted(() => {  
  axios.get('http://localhost:3000/comments')
    .then(resp => {
      console.log(resp.data);
      comments.value = resp.data;

    })
     
     
    })

</script>

<template>
  <div>
    <table v-if="posts.length > 0">
      <tr>
        <th>Id</th>
        <th>Title</th>
      </tr>
      <tr v-for="p in posts" :key="p.id">
        <td>{{ p.id }}</td>
        <td>{{ p.title }}</td>
      </tr>
    </table>
    <p v-else>Nincs adat!</p>
    <hr>
    <table v-if="comments.length > 0">
      <tr>
        <th>Id</th>
        <th>Comment</th> <!-- Adjust the property name here -->
      </tr>
      <tr v-for="c in comments" :key="c.id">
        <td>{{ c.id }}</td>
        <td>{{ c.text }}</td> <!-- Adjust the property name here -->
      </tr>
    </table>
    <p v-else>Nincs adat!</p>
  </div>
</template>
