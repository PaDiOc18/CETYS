use tallerestrellitafugaz;
/*Consultas*/

/*Mostrar información del cliente con mayor frecuencia en reparaciones que se la haya atendido en un periodo de tiempo determinado. */
select c.id_cliente, c.nombre, c.apellido_p, c.apellido_m,count(v.id_vehiculo) as NumVehiculos from cliente as c,servicio as s, vehiculo as v
where s.fecha_ingreso between '2020-01-01' and '2020-01-31' and c.id_cliente = v.id_cliente and s.id_vehiculo = v.id_vehiculo
group by c.nombre order by NumVehiculos DESC LIMIT 1;

/*select y.Nombre,y.ApellidoP,y.ApellidoM, max(y.NumVehiculos) as NumVehiculos from (select c.nombre as Nombre, c.apellido_p as ApellidoP, c.apellido_m as ApellidoM,count(v.id_vehiculo) as NumVehiculos from cliente as c,servicio as s, vehiculo as v
where s.fecha_ingreso between '2020-01-01' and '2020-06-31' and c.id_cliente = v.id_cliente and s.id_vehiculo = v.id_vehiculo
group by c.nombre,c.apellido_p,c.apellido_m) y;*/

/*Mostrar las ventas obtenidas con respecto al servicio de solo diagnósticos. */
select sum(costo) as GananciaDiagnosticos from diagnostico;

/*Mostrar al empleado que mayor ganancia obtuvo en un rango de fechas determinado. */
select m.nombre as Nombre, m.apellido_p as ApellidoP, m.apellido_m as ApellidoM, m.id_mecanico as Id_Mecanico, sum(v.cantidad_final) as GananciaTotal from mecanico as m, servicio as s, venta as v
where v.fecha_venta between '2019-06-01' and '2019-12-31' and m.id_mecanico = s.id_mecanicoResp and s.id_servicio = v.id_servicio 
group by m.id_mecanico order by GananciaTotal DESC limit 1;

/*Mostrar las reparaciones más concurrentes en base a un departamento especifico. cambiar d.id_departamento*/ /*El hack aquí*/
select d.id_departamento, d.nombre_depart, s.falla_en_repa, count(s.falla_en_repa) as NumRepHechas from departamento as d, servicio as s
where d.id_departamento = 4 and d.id_departamento = s.id_departamento
group by falla_en_repa order by NumRepHechas DESC limit 10;

/*Mostrar el departamento con mayor afluencia(cantidad de reparaciones) en un rango de fechas determinado. */
select s.id_departamento, d.nombre_depart, count(nombre_depart) as TrabajosHechos from departamento as d, servicio as s 
where s.fecha_ingreso between '2019-06-01' and '2020-12-31' and s.id_departamento = d.id_departamento
group by d.id_departamento order by TrabajosHechos DESC limit 1; 

/* Mostrar el consumo de refacciones clasificado por departamento.*/
select d.nombre_depart as NombreDepartamento, pro.descrip as ProductoDescripcion, count(pro.descrip) as Cantidad, d.id_departamento as DepartamentoId  from producto as pro, pedido as pe, departamento as d
where pe.id_producto = pro.id_producto and pro.id_departamento = d.id_departamento
group by pro.id_producto order by d.id_departamento;

/*Mostrar las características de los automóviles registrados en un periodo de tiempo. */
select * from vehiculo where fecha_registro between '2018-01-01' and '2018-06-01';

/*Mostrar el cliente con mayor gasto en reparaciones.*/
select v.cantidad_final, c.id_cliente, c.nombre, c.apellido_p, c.apellido_m from venta as v, servicio as s, cliente as c, vehiculo as ve
where v.id_servicio = s.id_servicio and s.id_vehiculo = ve.id_vehiculo and ve.id_cliente = c.id_cliente
order by v.cantidad_final DESC LIMIT 1;

/*Mostrar cual es la refacción más vendida del departamento de refacciones y cuanto genera de ganancia.*/ /*Hack 2.0*/
select pe.id_producto,p.descrip,count(pe.id_producto)*100 as Ganancia, count(pe.id_producto) as Cantidad from pedido as pe, producto as p
where pe.id_producto = p.id_producto
group by p.id_producto order by p.precio DESC limit 1;

/*Mostrar los datos del trabajador con mayores garantías aplicadas de los servicios que realizo.*/
select m.id_mecanico,m.nombre, m.apellido_p, m.apellido_m, count(g.aplicada) as GarantiasAplicadas from mecanico as m, garantia as g,venta as v, servicio as s 
where g.id_venta = v.id_venta and v.id_servicio = s.id_servicio and s.id_mecanicoResp = m.id_mecanico and g.aplicada = 1
group by m.id_mecanico order by GarantiasAplicadas DESC limit 1;

/*Mostrar la informacion de las promociones aplicadas en un departamento especifico, en base a un rango de fechas dado CONSULTA EXTRA*/
select v.*, prom.porcen_des, fecha_inicio, fecha_final, tipopromo from promocion as prom, venta as v, servicio as s
where v.id_servicio = s.id_servicio and s.id_departamento = 2 and v.id_promocion = prom.id_promocion and v.fecha_venta between '2020-01-01' and '2020-12-31' and v.id_promocion is not null;
