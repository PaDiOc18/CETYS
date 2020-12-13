<html>
<head>
<title>Consulta8</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
		<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select v.cantidad_final, c.id_cliente, c.nombre, c.apellido_p, c.apellido_m from venta as v, servicio as s, cliente as c, vehiculo as ve
where v.id_servicio = s.id_servicio and s.id_vehiculo = ve.id_vehiculo and ve.id_cliente = c.id_cliente
order by v.cantidad_final DESC LIMIT 1") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Cantidad Final</td>	
		<td>Id Cliente</td>
		<td>Nombre</td>	
		<td>Apellido Paterno</td>
		<td>Apellido Materno</td>
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['cantidad_final']?></td>
			<td><?php echo $reg['id_cliente']?></td>
			<td><?php echo $reg['nombre']?></td>
			<td><?php echo $reg['apellido_p']?></td>
			<td><?php echo $reg['apellido_m']?></td>
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

