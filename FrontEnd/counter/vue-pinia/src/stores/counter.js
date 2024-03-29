// import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const useCounterStore = defineStore({
  id: 'counter', 
  state: () => ({
    count: 0
  }),
  getters: {
    parosParatlan () {
    if (this.count % 2 == 0) return 'páros';
    return 'páratlan';
    }
  },
  actions:{
    inc() {
      this.count++
    },
    dec() {
      this.count--;
    }
  } 
  

})
