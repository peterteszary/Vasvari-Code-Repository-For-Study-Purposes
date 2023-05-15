function loadSections() {
fetch('../sections/cards.html')
  .then(response => response.text())
  .then(html => {
    const div = document.querySelector('#cards');
    div.innerHTML = html;
  });


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
}