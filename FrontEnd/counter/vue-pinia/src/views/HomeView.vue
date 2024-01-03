<script setup>
import { useCounterStore } from '@/stores/counter';

const storeCounter = useCounterStore();
</script>

<template>
  <div class="counter">
    {{ storeCounter.count }}
  </div>

 <div class="buttons">
  <button @click="storeCounter.dec">-</button>
  <button @click="storeCounter.inc">+</button>
 </div>
<hr>
<div>
  <p>Ez a szám: {{ storeCounter.parosParatlan }}</p>
</div>
</template>

<style scoped>
.counter {
  font-size: 3em;
}
</style>