// Személyes adatok validálása gomb
var validateButton = document.createElement("button");
validateButton.innerHTML = "Validálás";
validateButton.className = "btn btn-primary";
validateButton.addEventListener("click", function () {
  validatePersonalData();
});

var personalInfoSection = document.querySelector("#regForm fieldset");
personalInfoSection.appendChild(validateButton);

// Reset gomb
var resetButton = document.createElement("button");
resetButton.innerHTML = "Reset";
resetButton.className = "btn btn-secondary";
resetButton.addEventListener("click", function () {
  resetForm();
});
personalInfoSection.appendChild(resetButton);

// Teszt validálása gomb
var validateTestButton = document.createElement("button");
validateTestButton.innerHTML = "Ellenőrzés";
validateTestButton.className = "btn btn-primary";
validateTestButton.addEventListener("click", function () {
  validateTest();
});

var testSection = document.querySelector("#testForm fieldset");
testSection.appendChild(validateTestButton);

// Személyes adatok validálása
function validatePersonalData() {
  var name = document.getElementById("nev").value;
  var email = document.getElementById("email").value;
  var birthDate = document.getElementById("szuletesiIdo").value;
  var password = document.getElementById("jelszo").value;

  if (name !== "" && email !== "" && birthDate !== "" && password !== "") {
    document.getElementById("testSection").style.display = "block";
  } else {
    document.getElementById("testSection").style.display = "none";
  }
}

// Teszt validálása
function validateTest() {
  var question1 = document.querySelector('input[name="question1"]:checked');
  var question2 = document.querySelectorAll('input[name="question2"]:checked');
  var question3 = document.getElementById("question3").value;
  var question4 = document.getElementById("question4").value;
  var answerInput = document.getElementById("answerInput").value;
  var answerInputtwo = document.getElementById("answerInputtwo").value;

  var score = calculateScore();

  if (question1 !== null && question2.length > 0 && question3 !== "" && question4 !== "" && answerInput !== "" && answerInputtwo !== "") {
    document.getElementById("score").innerHTML = "Pontszám: " + score + "/100";
  } else {
    document.getElementById("score").innerHTML = "Kérlek, töltsd ki az összes kérdést!";
  }
}

// Pontszám kiszámítása
function calculateScore() {
  var score = 0;

  // Logika a pontszámításhoz
  // Mindegyik kérdésre 20 pontot adunk, tehát a maximális pontszám 100

  var question1 = document.querySelector('input[name="question1"]:checked');
  var question2 = document.querySelectorAll('input[name="question2"]:checked');
  var question3 = document.getElementById("question3").value;
  var question4 = document.getElementById("question4").value;
  var answerInput = document.getElementById("answerInput").value;
  var answerInputtwo = document.getElementById("answerInputtwo").value;

  if (question1 !== null && question1.value === "valasz1") {
    score += 20;
  }

  if (question2.length === 2) {
    score += 20;
  }

  if (question3 === "valasz3") {
    score += 20;
  }

  if (question4 === "valasz4") {
    score += 20;
  }

  if (answerInput === "valasz5") {
    score += 20;
  }

  if (answerInputtwo === "valasz6") {
    score += 20;
  }

  return score;
}

// Űrlap visszaállítása
function resetForm() {
  document.getElementById("regForm").reset();
  document.getElementById("testForm").reset();
  document.getElementById("testSection").style.display = "none";
  document.getElementById("score").innerHTML = "";
}

// Űrlap validáció
var regForm = document.getElementById("regForm");
var testForm = document.getElementById("testForm");

regForm.addEventListener("input", function () {
  checkFormValidity();
});

testForm.addEventListener("input", function () {
  checkFormValidity();
});

function checkFormValidity() {
  var validRegForm = regForm.checkValidity();
  var validTestForm = testForm.checkValidity();

  if (validRegForm) {
    document.getElementById("personalInfoSection").style.display = "none";
    document.getElementById("testSection").style.display = "block";
  } else {
    document.getElementById("personalInfoSection").style.display = "block";
    document.getElementById("testSection").style.display = "none";
  }

  if (validTestForm) {
    document.getElementById("submitButton").disabled = false;
  } else {
    document.getElementById("submitButton").disabled = true;
  }
}
