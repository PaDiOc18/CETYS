<html>
<head>
<title>Consulta5</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
	<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select s.id_departamento, d.nombre_depart, count(nombre_depart) as TrabajosHechos from departamento as d, servicio as s 
where s.fecha_ingreso between '".$_POST['fechainicio5']. "' and '" .$_POST['fechafinal5']. "' and s.id_departamento = d.id_departamento
group by d.id_departamento order by TrabajosHechos DESC limit 1") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Id Departamento</td>	
		<td>Nombre Departamento</td>
		<td>Trabajos Realizados</td>		
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['id_departamento']?></td>
			<td><?php echo $reg['nombre_depart']?></td>
			<td><?php echo $reg['TrabajosHechos']?></td>
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

