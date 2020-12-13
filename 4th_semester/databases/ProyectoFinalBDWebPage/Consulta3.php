<html>
<head>
<title>Consulta3</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
	<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select m.nombre as Nombre, m.apellido_p as ApellidoP, m.apellido_m as ApellidoM, m.id_mecanico as Id_Mecanico, sum(v.cantidad_final) as GananciaTotal from mecanico as m, servicio as s, venta as v
where v.fecha_venta between '".$_POST['fechainicio3']. "' and '" .$_POST['fechafinal3']. "' and m.id_mecanico = s.id_mecanicoResp and s.id_servicio = v.id_servicio 
group by m.id_mecanico order by GananciaTotal DESC limit 1") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Nombre</td>	
		<td>Apellido Paterno</td>	
		<td>Apellido Materno</td>
		<td>Id Mecanico</td>
		<td>Ganancia Total</td>			
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['Nombre']?></td>
			<td><?php echo $reg['ApellidoP']?></td>
			<td><?php echo $reg['ApellidoM']?></td>
			<td><?php echo $reg['Id_Mecanico']?></td>
			<td><?php echo $reg['GananciaTotal']?></td>
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

