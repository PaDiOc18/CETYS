<html>
<head>
<title>Consulta7</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
	<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select * from vehiculo where fecha_registro between '".$_POST['fechainicio7']. "' and '" .$_POST['fechafinal7']. "'") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Id Vehiculo</td>	
		<td>Marca</td>
		<td>Modelo</td>	
		<td>Año</td>
		<td>Color</td>
		<td>Fecha de Registro</td>
		<td>Id Cliente</td>		
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['id_vehiculo']?></td>
			<td><?php echo $reg['marca']?></td>
			<td><?php echo $reg['modelo']?></td>
			<td><?php echo $reg['anio']?></td>
			<td><?php echo $reg['color']?></td>
			<td><?php echo $reg['fecha_registro']?></td>
			<td><?php echo $reg['id_cliente']?></td>
		</tr>
	<?php
	}
	?>
</table>
<?php
mysqli_close($conexion);
?>
</div>
</body>
</html>

