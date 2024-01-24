<script setup>
import { onMounted, ref } from 'vue';
const posts = ref();


onMounted(() => {
  fetch('http://localhost:3000/posts')
  .then(resp => resp.json())
  .then(json => {
    console.log(json);
    posts.value = json;
  })
})
</script>

<template>
 
</template>
