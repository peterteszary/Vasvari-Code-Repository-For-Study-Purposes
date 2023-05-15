fetch('../json/menu.json')
  .then(response => response.json())
  .then(data => {
    const menu = document.querySelector('#menu');
    data.menu.forEach(item => {
      const li = document.createElement('li');
      li.classList.add('nav-item');
      const a = document.createElement('a');
      a.classList.add('nav-link');
      a.href = item.link;
      a.textContent = item.text;
      li.appendChild(a);
      if (item.subMenu) {
        const ul = document.createElement('ul');
        ul.classList.add('dropdown-menu');
        item.subMenu.forEach(subItem => {
          const subLi = document.createElement('li');
          const subA = document.createElement('a');
          subA.classList.add('dropdown-item');
          subA.href = subItem.link;
          subA.textContent = subItem.text;
          subLi.appendChild(subA);
          ul.appendChild(subLi);
        });
        li.classList.add('dropdown');
        a.classList.add('dropdown-toggle');
        a.setAttribute('data-bs-toggle', 'dropdown');
        li.appendChild(ul);
      }
      menu.appendChild(li);
    });
  });







