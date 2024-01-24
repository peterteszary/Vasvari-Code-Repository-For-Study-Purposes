<script setup>
import { onMounted, ref } from 'vue';
const title = ref("");
const send = () => {
  console.log=(title.value)
  fetch()
}
</script>

<template>
  <input v-model = "title" type="text" placeholder="Mi az új cím?">
  <button @click="send">Küldés</button>
</template>

<style>

</style>
