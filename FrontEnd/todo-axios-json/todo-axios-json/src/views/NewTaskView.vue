
<template>
    <form class="w-75 mx-auto" @submit.prevent ="saveTask()">
        <input v-model="task" class="form-control mt-3" type="text" placeholder="Új feladat">
        <input v-model="date" class="form-control mt-3" type="date">
        <input class="btn btn-success w-100 mt-3" type="submit" value="Rögzít">

    </form>
    <h3 class="text-danger text-center pt-5" v-if="error">Minden mezőt tölts ki!</h3>
</template>

<script setup>
import axios from 'axios';
import {ref} from 'vue';
const task = ref("");
const date = ref("");
const error = ref(false);

const saveTask = () => {
    console.log(task.value, date.value);
    if (task.value.trim() < 3 || date.value.trim().length != 10 ) {
        error.value = true;
    }
    else { //Az adatok küldése is itt történik.
        error.value = false;
        let shadowCopy = [];
        let nextId = null;
        axios.get("http://localhost:3000/todos")
        .then(resp => {
            shadowCopy = resp.data;
            nextId = String(Number(shadowCopy[(shadowCopy.length - 1)].id) + 1);
            let data = {
                id : nextId,
                task : tasl.value,
                deadline : date.value
            }
            axios.post("http://localhost:3000/todos", JSON.stringify(data)) 
        });
        
        
          
    }
}
</script>