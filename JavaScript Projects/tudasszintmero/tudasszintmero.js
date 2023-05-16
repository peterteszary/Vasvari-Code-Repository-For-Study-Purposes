// Űrlap ellenőrzése
function validateForm() {
  var name = document.getElementById("nev").value;
  var email = document.getElementById("email").value;
  var birthDate = document.getElementById("szuletesiIdo").value;
var password = document.getElementById("jelszo").value;

var question1 = document.querySelector('input[name="question1"]:checked');
var question2 = document.querySelectorAll('input[name="question2"]:checked');
var question3 = document.getElementById("question3").value;
var question4 = document.getElementById("question4").value;
var answerInput = document.getElementById("answerInput").value;
var answerInputtwo = document.getElementById("answerInputtwo").value;

var score = 0;

// Személyes adatok ellenőrzése
if (name !== "" && email !== "" && birthDate !== "" && password !== "") {
// Teszt megjelenítése
document.getElementById("testForm").style.display = "block";
// Teszt ellenőrzése
if (question1 !== null && question2.length > 0 && question3 !== "" && question4 !== "" && answerInput !== "" && answerInputtwo !== "") {
  score = calculateScore();
  document.getElementById("score").innerHTML = "Pontszám: " + score + "/100";
} else {
  document.getElementById("score").innerHTML = "Kérlek, töltsd ki az összes kérdést!";
}
} else {
  document.getElementById("score").innerHTML = "Kérlek, add meg a személyes adatokat!";
  }
  }
  
  // Pontszám kiszámítása
  function calculateScore() {
  var score = 0;
  
  // 1. kérdés
  var question1Answer = document.querySelector('input[name="question1"]:checked').value;
  if (question1Answer === "Chrome") {
  score += 20;
  }
  
  // 2. kérdés
  var question2Answers = document.querySelectorAll('input[name="question2"]:checked');
  if (question2Answers.length === 3) {
  score += 20;
  }
  
  // 3. kérdés
  var question3Answer = document.getElementById("question3").value;
  if (question3Answer.toLowerCase() === "javascript") {
  score += 20;
  }
  
  // 4. kérdés
  var question4Answer = document.getElementById("question4").value;
  if (question4Answer.toLowerCase().includes("senior") && question4Answer.toLowerCase().includes("medior") && question4Answer.toLowerCase().includes("junior")) {
  score += 20;
  }
  
  // 5. kérdés
  var answerInput = document.getElementById("answerInput").value;
  var answerInputtwo = document.getElementById("answerInputtwo").value;
  if (answerInput.toLowerCase() === "col" && answerInputtwo.toLowerCase() === "row") {
  score += 20;
  }
  
  return score;
  }
  
  // Űrlap validáció
  var regForm = document.getElementById("regForm");
  var testForm = document.getElementById("testForm");
  
  regForm.addEventListener("input", function() {
  checkFormValidity();
  });
  
  testForm.addEventListener("input", function() {
  checkFormValidity();
  });
  
  function checkFormValidity() {
  var name = document.getElementById("nev").value;
  var email = document.getElementById("email").value;
  var birthDate = document.getElementById("szuletesiIdo").value;
  var password = document.getElementById("jelszo").value;
  
  var submitButton = document.getElementById("submitButton");
  
  if (name !== "" && email !== "" && birthDate !== "" && password !== "") {
  submitButton.style.display = "block";
  } else {
  submitButton
  
  .style.display = "none";
  }
  }
  
  // Űrlap beküldése
  var submitButton = document.getElementById("submitButton");
  submitButton.addEventListener("click", function(event) {
  event.preventDefault();
  validateForm();
  });