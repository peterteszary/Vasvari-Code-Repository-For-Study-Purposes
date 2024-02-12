<script setup>
    import { RouterLink } from 'vue-router';
</script>

<template>
    <nav class="navbar navbar-expand-sm bg-dark navbar-dark d-flex justify-content-center">

        <ul class="navbar-nav ">

            <li class="nav-item">
                <RouterLink to="/" class="nav-link">Feladatok</RouterLink>
            </li>

            <li class="nav-item">
            <RouterLink to="/newtask" class="nav-link">Új feladat</RouterLink>
            </li>
            
        </ul>
    </nav>
</template>