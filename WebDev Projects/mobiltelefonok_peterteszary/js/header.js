function loadHeader() {
  fetch('../main-elements/header.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#header');
      div.innerHTML = html;
    });
}