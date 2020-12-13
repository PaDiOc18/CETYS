create function get_employee_by_name(name varchar)
  returns setof empleado
as
$$
select * from empleado where nombre = name;
$$
language sql;


create function get_charges_from_factura(idfactura int)
	returns setof cargo
as
$$
select * from cargo where id_factura = idfactura;
$$
language sql;


create function get_reservations_between(fechaInicio date, fechaFinal date)
	returns setof reservacion
as
$$
select * from reservacion where fecha_reservacion between fechaInicio and fechaFinal;
$$
language sql;


create function get_rooms_availables(categoria int)
	returns setof habitacion
as
$$
select * from habitacion where id_categoria = categoria and disponible = '1';
$$
language sql;


create function get_active_quejas_per_department(departamento int)
	returns setof queja
as
$$
select * from queja where id_departamento = departamento and activa = '1';
$$
language sql;


select * from get_employee_by_name('Amaya Ortiz PhD');
select * from get_reservations_between('2018-02-01','2018-05-01');	
select * from get_charges_from_factura(1);
select * from get_rooms_availables(1);
select * from get_active_quejas_per_department(1);