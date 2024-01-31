<script setup>
import { RouterLink, RouterView } from 'vue-router'
import Shop from './components/Shop.vue'
import Home from './components/Home.vue'
import Cart from './components/Cart.vue'
import Checkout from './components/Checkout.vue'


</script>

<template>
  <header>
    <img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="25" height="25" />

    <div class="wrapper">

      <nav>
        <RouterLink to="/home">Home</RouterLink>
        <RouterLink to="/shop">Shop</RouterLink>
        <RouterLink to="/cart">Cart</RouterLink>
        <RouterLink to="/checkout">Checkout</RouterLink>
      </nav>
    </div>
  </header>

  <RouterView />
</template>

<style scoped>
header {
  position: fixed;
  top: 0;
  width: 100%;
  line-height: 1.5;
  max-height: 20px;
}

.logo {
  display: block;

  /* margin: 0 auto 2rem; */
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 0rem;
}


nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    /* display: flex;
    place-items: flex-start;
    flex-wrap: wrap; */
    display: block;
    width: 100%;
    padding-top: 5px;
    padding-bottom: 5px;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;
    width: 100%;
    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>
