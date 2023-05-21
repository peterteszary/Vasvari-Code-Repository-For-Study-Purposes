
function loadSections() {


  fetch('../sections/hero.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#hero');
      div.innerHTML = html;
    });




  fetch('../sections/cards-section.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#cards-section');
      div.innerHTML = html;
    });



  fetch('../sections/devices-section.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#devices');
      div.innerHTML = html;
    });


}