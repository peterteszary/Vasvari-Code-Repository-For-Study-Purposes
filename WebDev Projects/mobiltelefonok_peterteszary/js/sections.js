
function loadSections() {


  fetch('../sections/hero.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#hero');
      div.innerHTML = html;
    });


  fetch('../sections/three-columns.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#three-columns');
      div.innerHTML = html;
    });


  fetch('../sections/cards.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#cards');
      div.innerHTML = html;
    });


  fetch('../sections/cards-second.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#cards-second');
      div.innerHTML = html;
    });

  fetch('../sections/cards-third.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#cards-third');
      div.innerHTML = html;
    });

    fetch('../sections/devices-section.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#devices');
      div.innerHTML = html;
    });


}