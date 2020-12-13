<html>
<head>
<title>Consulta9</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
	<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select pe.id_producto,p.descrip,count(pe.id_producto)*100 as Ganancia, count(pe.id_producto) as Cantidad from pedido as pe, producto as p
where pe.id_producto = p.id_producto
group by p.id_producto order by Ganancia DESC limit 1") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Id Producto</td>	
		<td>Descripcion</td>
		<td>Ganancia</td>	
		<td>Cantidad</td>	
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['id_producto']?></td>
			<td><?php echo $reg['descrip']?></td>
			<td><?php echo $reg['Ganancia']?></td>
			<td><?php echo $reg['Cantidad']?></td>
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

