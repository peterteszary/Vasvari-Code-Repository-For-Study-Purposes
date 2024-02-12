<script setup>
    import axios from 'axios';
    import { onMounted, ref } from 'vue';
    const todo = ref();
    onMounted( () => {
        axios.get('http://localhost:3000/todo')
        .then(resp => {
            todo.value = resp.data
        })
    })
</script>

<template>
  
</template>
