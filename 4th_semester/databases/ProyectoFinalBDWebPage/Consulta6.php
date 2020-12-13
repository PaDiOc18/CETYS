<html>
<head>
<title>Consulta6</title>
</head>
	<link rel="Stylesheet" type="text/css" href="./styles/index.css">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<body>
	<div id="ContenidoGeneral">
<?php
$conexion=mysqli_connect("localhost","root","","tallerestrellitafugaz") or
    die("Problemas con la conexión");

$registros=mysqli_query($conexion,"select d.nombre_depart as NombreDepartamento, pro.descrip as ProductoDescripcion, count(pro.descrip) as Cantidad, d.id_departamento as DepartamentoId  from producto as pro, pedido as pe, departamento as d
where pe.id_producto = pro.id_producto and pro.id_departamento = d.id_departamento
group by pro.id_producto order by d.id_departamento") or
  die("Problemas en la consulta:".mysqli_error($conexion));

?>
<table border="2" id="Yabasta">
	<tr bgcolor="#BDBDBD">
		<td>Producto Descripcion</td>	
		<td>Cantidad</td>
		<td>Departamento Id</td>	
		<td>Nombre Departamento</td>		
	</tr>
	<?php
    while ($reg=mysqli_fetch_array($registros))
	{
	?>
		<tr>
			<td><?php echo $reg['ProductoDescripcion']?></td>
			<td><?php echo $reg['Cantidad']?></td>
			<td><?php echo $reg['DepartamentoId']?></td>
			<td><?php echo $reg['NombreDepartamento']?></td>
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

