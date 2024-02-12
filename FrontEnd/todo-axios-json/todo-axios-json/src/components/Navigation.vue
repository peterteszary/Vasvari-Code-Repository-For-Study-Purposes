<script setup>
import { RouterLink } from 'vue-router';
</script>
<template>
    <nav class="navbar navbar-expand-sm bg-dark">
        <ul class="navbar-nav d-flex justify-content-center">
            <li class="nav-item">
                <RouterLink class="nav-link"  to="/">Tasks</RouterLink>
            </li>
            <li class="nav-item">
                <RouterLink class="nav-link" to="/newtask">New Task</RouterLink>
            </li>
        </ul>

    </nav>
</template>