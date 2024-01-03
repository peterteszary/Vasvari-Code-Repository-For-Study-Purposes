// import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const useCounterStore = defineStore({
  id: 'counter', 
  state: () => ({
    count: 0
  }),
  getters: {},
  actions:{
    inc() {
      this.count++
    },
    dec() {
      this.count--;
    }
  } 
  

})
