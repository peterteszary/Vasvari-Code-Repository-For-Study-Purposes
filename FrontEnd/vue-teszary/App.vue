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

<style>
.title {
  color: red;
}
</style>
