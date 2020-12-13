<html>
<head>
<title>Consulta10</title>
</head>
<link rel="Stylesheet" type="text/css" href="./styles/index.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
	<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select m.id_mecanico,m.nombre, m.apellido_p, m.apellido_m, count(g.aplicada) as GarantiasAplicadas from mecanico as m, garantia as g,venta as v, servicio as s 
where g.id_venta = v.id_venta and v.id_servicio = s.id_servicio and s.id_mecanicoResp = m.id_mecanico and g.aplicada = 1
group by m.id_mecanico order by GarantiasAplicadas DESC limit 1") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Id de Mecánico</td>	
		<td>Nombre</td>	
		<td>Apellido Paterno</td>
		<td>Apellido Materno</td>
		<td>Num Garantias Aplicadas</td>	
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['id_mecanico']?></td>
			<td><?php echo $reg['nombre']?></td>
			<td><?php echo $reg['apellido_p']?></td>
			<td><?php echo $reg['apellido_m']?></td>
			<td><?php echo $reg['GarantiasAplicadas']?></td>
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

