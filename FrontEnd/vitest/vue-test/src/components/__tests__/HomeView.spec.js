import { describe, it, expect } from 'vitest'

import { mount } from '@vue/test-utils'
import HomeView from '@/views/HomeView.vue'

describe('HomeView', () => {
  it('renders properly', () => {
    const wrapper = mount(HomeView, { props: { msg: 'Hello Vitest' } })
    expect(wrapper.text()).toContain('Home')
  })
  it('Attribute test', () => {
    const kiscica = mount(HomeView)
    expect(kiscica.attributes().type).toBe('text')
  })

})
