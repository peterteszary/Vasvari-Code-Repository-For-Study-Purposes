// Teszt eredmények kezelése
let score = 0;

// Személyes adatok validálása és teszt megjelenítése
document.getElementById('validateButton').addEventListener('click', function () {
  const vezeteknev = document.getElementById('vezeteknev').value;
  const keresztnev = document.getElementById('keresztnev').value;
  const email = document.getElementById('email').value;
  const szuletesiIdo = document.getElementById('szuletesiIdo').value;
  const jelszo = document.getElementById('jelszo').value;

  // Adatok ellenőrzése
  if (vezeteknev === '' || keresztnev === '' || email === '' || szuletesiIdo === '' || jelszo === '') {
    alert('Kérjük, töltse ki az összes személyes adatot!');
    return;
  }

  // Jelszó ellenőrzése
  if (jelszo !== 'jelszo') {
    alert('Hibás jelszó!');
    return;
  }

  // Teszt megjelenítése
  document.getElementById('testSection').style.display = 'block';
});

// Teszt eredményének ellenőrzése
document.getElementById('checkButton').addEventListener('click', function () {
  const question1 = document.querySelector('input[name="question1"]:checked');
  const question2 = document.querySelectorAll('input[name="question2[]"]:checked');
  const question3 = document.getElementById('question3');
  const question4 = document.querySelectorAll('input[name="question4[]"]:checked');
  const question5 = document.querySelector('input[name="question5"]:checked');

  // Pontszám számítása
  score = 0;

  //Első kérdés

  if (question1 && question1.value === 'Chrome') {
    score += 20;
  }

  //Második kérdés

  if (question2.length === 3) {
    let isHTML = false;
    let isCSS = false;
    let isJavaScript = false;

    for (let i = 0; i < question2.length; i++) {
      if (question2[i].value === 'HTML') {
        isHTML = true;
      } else if (question2[i].value === 'CSS') {
        isCSS = true;
      } else if (question2[i].value === 'JavaScript') {
        isJavaScript = true;
      }
    }

    //Harmadik kérdés

    if (isHTML && isCSS && isJavaScript) {
      score += 20;
    }
  }

  if (question3 && question3.value === 'JavaScript') {
    score += 20;
  }

  //Negyedik kérdés

  if (question4.length === 3) {
    let isJunior = false;
    let isMedior = false;
    let isSenior = false;

    for (let i = 0; i < question4.length; i++) {
      if (question4[i].value === 'Junior') {
        isJunior = true;
      } else if (question4[i].value === 'Medior') {
        isMedior = true;
      } else if (question4[i].value === 'Senior') {
        isSenior = true;
      }
    }

    if (isJunior && isMedior && isSenior) {
      score += 20;
    }
  }

  //Ötödik kérdés  
    //th, tr, row, col
  if (question5.length === 5) {
    let isth = false;
    let istr = false;
    let isrow = false;
    let iscol = false;

    for (let i = 0; i < question5.length; i++) {
      if (question5[i].value === 'th') {
        isth = true;
      } else if (question5[i].value === 'tr') {
        istr = true;
      } else if (question5[i].value === 'row') {
        isrow = false;
      } else if (question5[i].value === 'col') {
      isrow = false;
    }
  }

    if (isth && istr) {
      score += 20;
    }
  }

  /* if (question5 && question5.value === 'row') {
    score += 20;
  } */

  // Eredmény megjelenítése
  document.getElementById('score').textContent = `Pontszám: ${score}`;
  document.getElementById('resultSection').style.display = 'block';
});

// Reset gombok kezelése
document.getElementById('resetButton').addEventListener('click', function () {
  document.getElementById('regForm').reset();
});

document.getElementById('resetResultButton').addEventListener('click', function () {
  document.getElementById('testForm').reset();
  document.getElementById('resultSection').style.display = 'none';
  score = 0;
});
