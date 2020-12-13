--Consultas

--Consulta 1
select factura.id_factura, factura.id_reservacion, (select nombre from huesped_principal where id_huesped = factura.id_huesped), cargo.fecha, 
(select nombre from servicio where servicio.id_servicio = cargo.id_servicio) as nombre_servicio, 
(select nombre from categoria_habitacion where categoria_habitacion.id_categoria = cargo.id_categoria) as nombre_habitacion, 
(select nombre from paquete where paquete.id_paquete = cargo.id_paquete) as nombre_paquete, 
cargo.total
from cargo inner join factura on factura.id_factura = cargo.id_factura where factura.id_factura = 2;

--Consulta 2

select id_habitacion,(select nombre from categoria_habitacion where id_categoria = habitacion.id_categoria), capacidad 
from habitacion where disponible = '1';

--consulta 3

select (select nombre from categoria_habitacion where categoria_habitacion.id_categoria = cargo.id_categoria), count(id_categoria) from 
cargo where fecha between '2018-05-01' and '2018-09-01' and 
id_categoria is not null group by id_categoria;

--consulta 4

select id_reservacion,
(select nombre from huesped_principal where id_huesped = reservacion.id_huesped) as nombre_huesped,
(select nombre from categoria_habitacion where (select id_categoria from habitacion 
where reservacion.id_habitacion = habitacion.id_habitacion) = id_categoria) as categoria_habitacion,
(case when tipo_reservacion = 1 then 'Internet'
when tipo_reservacion = 2 then 'Telefono'
when tipo_reservacion = 3 then 'Visita personal'
end), fecha_reservacion, fecha_inicio, fecha_final
from reservacion where fecha_reservacion between '2018-01-01' and '2018-12-01';

--consulta 5

select nombre, descripcion,
(select count(*) from habitacion where id_categoria = categoria_habitacion.id_categoria and habitacion.disponible = '1') as cuartos_disponibles
from categoria_habitacion;

--consulta 6

select id_reservacion,
(select nombre from huesped_principal where id_huesped = reservacion.id_huesped),
(select nombre from categoria_habitacion where (select id_categoria from habitacion 
where reservacion.id_habitacion = habitacion.id_habitacion) = id_categoria) as categoria_habitacion,
(case when tipo_reservacion = 1 then 'Internet'
when tipo_reservacion = 2 then 'Telefono'
when tipo_reservacion = 3 then 'Visita personal'
end), fecha_reservacion, fecha_inicio, fecha_final
from reservacion order by fecha_final - fecha_inicio DESC LIMIT 5;


--consulta 7

select nombre,
(select nombre from departamento where id_departamento = empleado.id_departamento) as nombre_departamento,
edad,sexo,telefono,direccion,correo_electronico,fecha_nacimiento,fecha_contratacion,rfc  from empleado order by id_departamento ASC;


--consulta 8

select id_bono,
(select nombre from empleado where id_empleado = bono.id_empleado),
fecha,cantidad,razon from bono where fecha between '2008-01-02' and '2008-12-01' order by cantidad DESC LIMIT 5;

--consulta 9


select id_cargo, fecha, 
(select nombre from servicio where servicio.id_servicio = cargo.id_servicio) as nombre_servicio, 
(select nombre from categoria_habitacion where categoria_habitacion.id_categoria = cargo.id_categoria) as nombre_habitacion, 
(select nombre from paquete where paquete.id_paquete = cargo.id_paquete) as nombre_paquete, 
total
from cargo where fecha between '2018-05-01' and '2018-12-01';


--consulta 10

SELECT s.id_servicio, s.nombre, total FROM 
(SELECT * FROM servicio) as s
INNER JOIN
(SELECT id_servicio, SUM(total) as total FROM cargo WHERE id_servicio is not null and fecha between '2015-11-11' and '2019-11-11' GROUP BY id_servicio) as c
ON s.id_servicio = c.id_servicio;

--consulta 11

SELECT h.id_huesped, h.nombre, dq.id_departamento, dq.nombre_departamento, dq.fechaInicio, dq.fechafin, dq.activa, dq.seguimiento, dq.razon FROM
(SELECT * FROM huesped_principal) as h
INNER JOIN
(SELECT d.id_departamento, q.id_huesped, d.nombre as nombre_departamento, q.fechaInicio, q.fechafin, q.activa, q.seguimiento, q.razon FROM
(SELECT * FROM departamento) as d
INNER JOIN
(SELECT * FROM queja WHERE id_departamento = 1 and fechaInicio between '2015-11-11' and '2019-11-11') as q
ON q.id_departamento = d.id_departamento) as dq
ON dq.id_huesped = h.id_huesped;

--consulta 12

select id_reservacion,
(select nombre from huesped_principal where id_huesped = reservacion.id_huesped) as nombre_huesped,
(select nombre from categoria_habitacion where (select id_categoria from habitacion 
where reservacion.id_habitacion = habitacion.id_habitacion) = id_categoria) as categoria_habitacion,
(case when tipo_reservacion = 1 then 'Internet'
when tipo_reservacion = 2 then 'Telefono'
when tipo_reservacion = 3 then 'Visita personal'
end), fecha_reservacion, fecha_inicio, fecha_final,
(select total from factura where id_reservacion = reservacion.id_reservacion)
from reservacion where fecha_reservacion between  '2018-05-01' and '2018-09-01' order by tipo_reservacion DESC; 


--consulta 13


SELECT (select nombre from departamento where id_departamento = d.id_departamento) as nombre_departamento,
count(d.id_departamento) as num_quejas FROM 
(SELECT * FROM departamento) as d
INNER JOIN
(SELECT * FROM queja WHERE fechaInicio between '2000-11-11' and '2020-12-31') as q
ON q.id_departamento = d.id_departamento
GROUP BY d.id_departamento order by num_quejas ASC LIMIT 1;


		
