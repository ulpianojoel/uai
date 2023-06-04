document.addEventListener("DOMContentLoaded", function() {
  var form = document.getElementById("myForm");
  form.addEventListener("submit", function(event) {
    event.preventDefault(); // Evita el envío automático del formulario

    // Realiza las validaciones personalizadas
    var name = document.getElementById("validationDefault01").value;
    var email = document.getElementById("validationDefaultUsername").value;
    var ciudad = document.getElementById("validationDefault03").value;

    if (name === "" || email === "" || ciudad === "") {
      alert("Por favor, completa todos los campos obligatorios.");
    } else if (!validateEmail(email)) {
      alert("Por favor, ingresa un correo electrónico válido.");
    } else {
      // Si todas las validaciones pasan, puedes enviar el formulario
      alert("El formulario se envió correctamente.");
      // aca van las acciones post envio
    }
  });

  function validateEmail(email) {
    // Utiliza una expresión regular para validar el formato del correo electrónico
    var re = /\S+@\S+\.\S+/;
    return re.test(email);
  }
});