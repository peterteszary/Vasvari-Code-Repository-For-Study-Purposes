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

</template>

<style scoped>
.counter {
  font-size: 3em;
}
</style>