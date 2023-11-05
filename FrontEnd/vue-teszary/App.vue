<!-- App.vue -->

<template>
  <div>
    <h1>Hello World!</h1>
    <h1 :class="titleClass">Make me red</h1>
  </div>
</template>

<script setup>
import { reactive, ref } from 'vue';

const counter = reactive({ count: 0 });
const message = ref('Hello World');
const titleClass = ref('title');
</script>

<script type="module">
import { createApp, ref } from 'vue'

createApp({
  setup() {
    const count = ref(0)

    function increment() {
      count.value++
    }

    return {
      count,
      increment
    }
  }
}).mount('#app')
</script>

<div id="app">
  <button @click="increment">count is: {{ count }}</button>
</div>

<style>
.title {
  color: red;
}
</style>
