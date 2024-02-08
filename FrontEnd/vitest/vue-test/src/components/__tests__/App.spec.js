import { describe, it, expect } from 'vitest'

import { mount } from '@vue/test-utils'
import Navigation from '@/components/Navigation.vue'
import App from '@/App.vue';

describe('App', () => {
  it('Navigáció komponens keresése', () => {
    const wrapper = mount(App)
    const comp = weapper.findComponent('Navigation')
    expect(comp.exsist()).toBe(true)

})
)