<html>
<head>
<title>Consulta1</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
<div id="ContenidoGeneral">
<?php



$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select c.id_cliente, c.nombre, c.apellido_p, c.apellido_m,count(v.id_vehiculo) as NumVehiculos from cliente as c,servicio as s, vehiculo as v
where s.fecha_ingreso between '".$_POST['fechainicio1']. "' and '" .$_POST['fechafinal1']. "' and c.id_cliente = v.id_cliente and s.id_vehiculo = v.id_vehiculo
group by c.nombre order by NumVehiculos DESC LIMIT 1") or
  die("Problemas en la consulta:".mysqli_error($conexion)."Escribe Bien los Datos por Favor");

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Id de Cliente</td>	
		<td>Nombre</td>	
		<td>Apellido Paterno</td>	
		<td>Apellido Materno</td>
		<td>Numero de Vehiculos</td>		
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['id_cliente']?></td>
			<td><?php echo $reg['nombre']?></td>
			<td><?php echo $reg['apellido_p']?></td>
			<td><?php echo $reg['apellido_m']?></td>
			<td><?php echo $reg['NumVehiculos']?></td>
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

