<html>
<head>
<title>Consulta4</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
	<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select d.id_departamento, d.nombre_depart, s.falla_en_repa, count(s.falla_en_repa) as NumRepHechas from departamento as d, servicio as s
where d.id_departamento = ".$_POST['numDepa4']." and d.id_departamento = s.id_departamento
group by falla_en_repa limit 4") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table id="Yabasta" border="2">
	<tr bgcolor="#BDBDBD">
		<td>Id Departamento</td>	
		<td>Nombre Departamento</td>	
		<td>Falla en Reparacion</td>
		<td>Numero Rep Hechas</td>		
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['id_departamento']?></td>
			<td><?php echo $reg['nombre_depart']?></td>
			<td><?php echo $reg['falla_en_repa']?></td>
			<td><?php echo $reg['NumRepHechas']?></td>
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

