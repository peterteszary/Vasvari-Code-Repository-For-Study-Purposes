const form = document.createElement("form");
document.body.appendChild(form);

// Személyes adatok mezők
const personalDataFieldset = document.createElement("fieldset");
personalDataFieldset.innerHTML = "<legend>Személyes adatok és jelszó megadása:</legend>";
form.appendChild(personalDataFieldset);

const createInput = (type, name, label) => {
  const input = document.createElement("input");
  input.type = type;
  input.name = name;
  input.required = true;

  const inputLabel = document.createElement("label");
  inputLabel.textContent = label;
  inputLabel.appendChild(input);

  return inputLabel;
};

personalDataFieldset.appendChild(createInput("text", "name", "Kitöltő neve*: "));
personalDataFieldset.appendChild(createInput("email", "email", "Kitöltő e-mail címe*: "));
personalDataFieldset.appendChild(createInput("text", "birthdate", "Születési idő*: "));
personalDataFieldset.appendChild(createInput("password", "password", "Jelszó*: "));

// Teszt mezők
const testFieldset = document.createElement("fieldset");
testFieldset.innerHTML = "<legend>Teszt kitöltése:</legend>";
form.appendChild(testFieldset);

const createQuestion = (questionNumber, questionText, options, type) => {
  const questionLabel = document.createElement("label");
  questionLabel.textContent = `${questionNumber}. kérdés: ${questionText}`;
  testFieldset.appendChild(questionLabel);

  options.forEach((option, index) => {
    const input = document.createElement("input");
    input.type = type;
    input.name = `question${questionNumber}`;
    input.value = option;

    const optionLabel = document.createElement("label");
    optionLabel.textContent = option;
    optionLabel.appendChild(input);

    testFieldset.appendChild(optionLabel);
  });
};

createQuestion(1, "Mi a legelterjedtebb webes böngésző?", ["Firefox", "Chrome", "Safari", "Opera"], "radio");
createQuestion(2, "Melyik nyelv használható a weboldalak fejlesztéséhez?", ["HTML", "CSS", "JavaScript", "Python"], "checkbox");
createQuestion(3, "Írd ide a választ:", [], "text");
createQuestion(4, "Írd ide a választ:", [], "textarea");
createQuestion(5, "Válaszd ki a helyes választ:", ["válasz1", "válasz2", "válasz3", "válasz4"], "radio");

// Ellenőrzés gomb
const submitButton = document.createElement("button");
submitButton.textContent = "Ellenőriz";
submitButton.setAttribute("type", "submit");
testFieldset.appendChild(submitButton);

// Eredmény
const result = document.createElement("div");
form.appendChild(result);

// Ellenőrzés gomb eseménykezelője
form.addEventListener("submit", (event) => {
    event.preventDefault();
  
    const score = Array.from(form.elements).reduce((acc, element) => {
      if (element.name.startsWith("question")) {
        if (element.type === "radio" && element.checked && element.value === "Chrome") {
          acc++;
        } else if (element.type === "checkbox" && element.checked && (element.value === "HTML" || element.value === "CSS")) {
          acc++;
        } else if (element.type === "text" && element.value.toLowerCase() === "javascript") {
          acc++;
        } else if (element.type === "textarea" && element.value.toLowerCase().includes("html") && element.value.toLowerCase().includes("css") && element.value.toLowerCase().includes("javascript")) {
          acc++;
        } else if (element.type === "radio" && element.checked && element.value === "válasz1") {
          acc++;
        }
      }
      return acc;
    }, 0);
  
    const scorePercentage = Math.round((score / 5) * 100);
    result.textContent = `Eredmény: ${scorePercentage}%`;
  });
  