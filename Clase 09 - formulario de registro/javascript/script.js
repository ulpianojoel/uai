document.getElementById("myForm").addEventListener("submit", function(event) {
  event.preventDefault();

  var fullName = document.getElementById("validationDefault01").value + " " + document.getElementById("validationDefault02").value;
  var username = document.getElementById("validationDefaultUsername").value;
  var city = document.getElementById("validationDefault03").value;
  var district = document.getElementById("validationDefault04").value;
  var postalCode = document.getElementById("validationDefault05").value;
  var email = document.getElementById("email").value;
  var password = document.getElementById("password").value;
  var age = document.getElementById("age").value;
  var phone = document.getElementById("phone").value;
  var address = document.getElementById("address").value;
  var dni = document.getElementById("dni").value;

  var fullNameRegex = /^[a-zA-Z]{2,}\s[a-zA-Z]{2,}$/;
  var usernameRegex = /^\S+$/;
  var cityRegex = /^[a-zA-Z]{3,}$/;
  var postalCodeRegex = /^[a-zA-Z0-9]{3,}$/;
  var emailRegex = /\S+@\S+\.\S+/;
  var passwordRegex = /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$/;
  var ageRegex = /^\d+$/;
  var phoneRegex = /^\d{7,}$/;
  var addressRegex = /^[a-zA-Z0-9]+\s[a-zA-Z0-9\s]*[a-zA-Z0-9]$/;
  var dniRegex = /^\d{7,8}$/;

  if (!fullNameRegex.test(fullName)) {
    alert("Ingresa un nombre completo válido (más de 6 letras y al menos un espacio).");
  } else if (!usernameRegex.test(username)) {
    alert("Ingresa un nombre de usuario válido.");
  } else if (!cityRegex.test(city)) {
    alert("Selecciona una ciudad válida.");
  } else if (!postalCodeRegex.test(postalCode)) {
    alert("Ingresa un código postal válido (al menos 3 caracteres alfanuméricos).");
  } else if (!emailRegex.test(email)) {
    alert("Ingresa un email válido.");
  } else if (!passwordRegex.test(password)) {
    alert("Ingresa una contraseña válida (al menos 8 caracteres con letras y números).");
  } else if (!ageRegex.test(age) || parseInt(age) < 18) {
    alert("Ingresa una edad válida (mayor o igual a 18).");
  } else if (!phoneRegex.test(phone)) {
    alert("Ingresa un número de teléfono válido (al menos 7 dígitos).");
  } else if (!addressRegex.test(address)) {
    alert("Ingresa una dirección válida (al menos 5 caracteres con letras, números y un espacio en el medio).");
  } else if (!dniRegex.test(dni)) {
    alert("Ingresa un número de DNI válido (7 u 8 dígitos).");
  } else {
    alert("Formulario enviado correctamente!");
    document.getElementById("myForm").reset();
  }
});