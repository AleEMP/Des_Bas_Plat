<?php

$conexion = new mysqli('localhost', 'root', '', 'formulario');

if ($conexion->connect_errno) {
    die('Error en la conexión: ' . $conexion->connect_error);
}

// Verificamos si se han enviado los datos del formulario
if (isset($_POST['nombre']) && isset($_POST['apellidos']) && isset($_POST['fecha_nacimiento']) && isset($_POST['ocupacion']) && isset($_POST['contacto']) && isset($_POST['email']) && isset($_POST['nacionalidad']) && isset($_POST['nivel_ingles']) && isset($_POST['lenguajes'])) {
    
    // Asignamos los valores a las variables
$nombre = $_POST["nombre"];
$apellidos = $_POST["apellidos"];
$fecha_nacimiento = $_POST["fecha_nacimiento"];
$ocupacion = $_POST["ocupacion"];
$contacto = $_POST["contacto"];
$email = $_POST["email"];
$nacionalidad = $_POST["nacionalidad"];
$nivel_ingles = $_POST["nivel_ingles"];
$lenguajes = implode(", ", $_POST["lenguajes"]);
$aptitudes = $_POST["aptitudes"];
$habilidades = implode(", ", $_POST["habilidades"]);
$perfil = $_POST["perfil"];

$sql = "INSERT INTO registros (nombre, apellidos, fecha_nacimiento, ocupacion, contacto, email, nacionalidad, nivel_ingles, lenguajes, aptitudes, habilidades, perfil) 
        VALUES ('$nombre', '$apellidos', '$fecha_nacimiento', '$ocupacion', '$contacto', '$email', '$nacionalidad', '$nivel_ingles', '$lenguajes', '$aptitudes', '$habilidades', '$perfil')";

if (!$conexion->query($sql)) {
  die('Error al insertar los datos: ' . $conexion->error);
}

echo "Los datos se guardaron correctamente";
} else {
echo "No se enviaron los datos del formulario";
}

$conexion->close();

?>