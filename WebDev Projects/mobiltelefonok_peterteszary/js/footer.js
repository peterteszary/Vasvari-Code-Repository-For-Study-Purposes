function loadFooter() {
  fetch('../main-elements/footer.html')
    .then(response => response.text())
    .then(html => {
      const div = document.querySelector('#footer');
      div.innerHTML = html;
    });
}