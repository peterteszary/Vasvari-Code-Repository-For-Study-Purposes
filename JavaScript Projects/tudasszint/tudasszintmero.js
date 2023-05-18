// Validálás gomb eseménykezelője
validateButton.addEventListener('click', function (event) {
    event.preventDefault();
  
    // Személyes adatok validálása
    if (!isPersonalDataValid()) {
      return;
    }
  
    // Teszt kitöltése rész megjelenítése
    testSection.style.display = 'block';
  });
  
  // Ellenőrzés gomb eseménykezelője
  checkButton.addEventListener('click', function (event) {
    event.preventDefault();
    
    // Tesztkérdések validálása
    const score = validateTest();
    
    // Eredmények kiírása
    scoreElement.textContent = `Eredmény: ${score}/100 pont`;
  });
  
  // Reset gomb eseménykezelője
  resetButton.addEventListener('click', function (event) {
    event.preventDefault();
    
    // Űrlap visszaállítása
    resetForm();
  });
  
  // Teszt validálása és pontszám kiszámítása
  function validateTest() {
    let score = 0;
  
    // Kérdés 1 validálása
    if (document.querySelector('input[name="question1"]:checked').value === 'Chrome') {
      score += 20;
    }
  
    // Kérdés 2 validálása
    const selectedOptions = Array.from(document.querySelectorAll('input[name="question2"]:checked')).map(option => option.value);
    const correctOptions = ['HTML', 'CSS', 'JavaScript'];
    if (selectedOptions.length === correctOptions.length && correctOptions.every(option => selectedOptions.includes(option))) {
      score += 20;
    }
  
    // Kérdés 3 validálása
    if (document.getElementById('question3').value.toLowerCase() === 'javascript') {
      score += 20;
    }
  
    // Kérdés 4 validálása
    const question4Answer = document.getElementById('question4').value.trim();
    const correctAnswers = ['Junior', 'Medior', 'Senior'];
    const selectedAnswers = question4Answer.split('\n').map(option => option.trim());
    if (selectedAnswers.length === correctAnswers.length && correctAnswers.every(option => selectedAnswers.includes(option))) {
      score += 20;
    }
  
    // Kérdés 5 validálása
    const answerInput = document.getElementById('answerInput').value.trim();
    const answerInputtwo = document.getElementById('answerInputtwo').value.trim();
    if (answerInput.toLowerCase() === 'col' && answerInputtwo.toLowerCase() === 'row') {
      score += 20;
    }
  
    return score;
  }
  
  // Személyes adatok validálása
  function isPersonalDataValid() {
    const nameInput = document.getElementById('nev');
    const emailInput = document.getElementById('email');
    const birthInput = document.getElementById('szuletesiIdo');
    const passwordInput = document.getElementById('jelszo');
  
    if (!nameInput.checkValidity()) {
      nameInput.classList.add('is-invalid');
      return false;
    } else {
      nameInput.classList.remove('is-invalid');
    }
  
    if (!emailInput.checkValidity()) {
      emailInput.classList.add('is-invalid');
      return false;
    } else {
      emailInput.classList.remove('is-invalid');
    }
  
    if (!birthInput.checkValidity()) {
      birthInput.classList.add('is-invalid');
      return false;
    } else {
      birthInput.classList.remove('is-invalid');
    }
  
    if (!passwordInput.checkValidity()) {
      passwordInput.classList.add('is-invalid');
      return false;
    } else {
      passwordInput.classList.remove('is-invalid');
    }
  
    return true;
  }
  
  // Űrlap visszaállítása
  function resetForm() {
    document.getElementById('regForm').reset();
    document.getElementById('testForm').reset();
    testSection.style.display = 'none';
    scoreElement.textContent = '';
  }
  
  // Init
  const validateButton = document.getElementById('validateButton');
  const testSection = document.getElementById('testSection');
  const checkButton = document.getElementById('submitButton');
  const scoreElement = document.getElementById('score');
  const resetButton = document.getElementById('resetButton');
  
  resetForm();
  