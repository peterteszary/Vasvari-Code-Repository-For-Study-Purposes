<template>
 <h2>About</h2>
 <p>{{ storeCounter.count }}</p>
</template>

<script setup>
import { useCounterStore } from '@/stores/counter';
const storeCounter = useCounterStore();
</script>

<style>

</style>
