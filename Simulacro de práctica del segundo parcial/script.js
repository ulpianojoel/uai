function calculateDistance() {
    // Obtener las coordenadas de los puntos A y B
    var xa = parseFloat(document.getElementById("xa").value);
    var ya = parseFloat(document.getElementById("ya").value);
    var xb = parseFloat(document.getElementById("xb").value);
    var yb = parseFloat(document.getElementById("yb").value);
  
    // Calcular la distancia en 2D
    var distance2D = Math.sqrt(Math.pow(xb - xa, 2) + Math.pow(yb - ya, 2));
  
    // Mostrar el resultado
    document.getElementById("result").innerHTML = "Distancia en 2D: " + distance2D.toFixed(2);
  
    // Si se ingresaron coordenadas en 3D
    if (!isNaN(xa) && !isNaN(ya) && !isNaN(xb) && !isNaN(yb)) {
      // Calcular las coordenadas del punto A y B en 3D
      var za = parseFloat(document.getElementById("za").value);
      var zb = parseFloat(document.getElementById("zb").value);
  
      // Calcular la distancia en 3D
      var distance3D = Math.sqrt(Math.pow(xb - xa, 2) + Math.pow(yb - ya, 2) + Math.pow(zb - za, 2));
  
      // Mostrar el resultado
      document.getElementById("result").innerHTML += "<br>Distancia en 3D: " + distance3D.toFixed(2);
    }
  }
  