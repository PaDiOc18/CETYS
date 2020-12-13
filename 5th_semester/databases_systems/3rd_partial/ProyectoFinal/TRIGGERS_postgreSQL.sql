
--TRIGGER B)


CREATE OR REPLACE FUNCTION verificar_fecha_cancelacion() RETURNS TRIGGER AS $verificar_fecha_cancelacion$
  DECLARE
  BEGIN
   if OLD.activo = '1' and NEW.activo = '0' and OLD.fecha_final <= current_date THEN
   	RAISE unique_violation USING MESSAGE = 'COMPLETED RESERVATIONS CANNOT BE CANCELLED';
	END if;
   RETURN NEW;
  END;
$verificar_fecha_cancelacion$ LANGUAGE plpgsql;


CREATE TRIGGER verificar_fecha_cancelacion BEFORE UPDATE 
    ON reservacion FOR EACH ROW 
    EXECUTE PROCEDURE verificar_fecha_cancelacion();



--TRIGGER C)
CREATE OR REPLACE FUNCTION evitar_modificacion_paquete() RETURNS TRIGGER AS $evitar_modificacion_paquete$
  DECLARE
  BEGIN
   if OLD.id_paquete <> NEW.id_paquete THEN
   	RAISE unique_violation USING MESSAGE = 'CANNOT CHANGE PACKET ONCE REGISTERED';
	END if;
   RETURN NEW;
  END;
$evitar_modificacion_paquete$ LANGUAGE plpgsql;


CREATE TRIGGER evitar_modificacion_paquete BEFORE UPDATE 
    ON cargo FOR EACH ROW 
    EXECUTE PROCEDURE evitar_modificacion_paquete();



--TRIGGER D)
CREATE OR REPLACE FUNCTION agregar_bono() RETURNS TRIGGER AS $agregar_bono$
  DECLARE
  BEGIN
   	if NEW.fecha_final - NEW.fecha_inicio > 10 THEN
   		insert into bono values(default,NEW.id_empleado, current_date,1500,'registro de reservacion mas de 10 dias');
	elseif NEW.fecha_final - NEW.fecha_inicio > 5 THEN
		insert into bono values(default,NEW.id_empleado, current_date,500,'registro de reservacion mas de 5 dias');
	elseif NEW.fecha_final - NEW.fecha_inicio > 3 THEN
		insert into bono values(default,NEW.id_empleado, current_date,380,'registro de reservacion mas de 3 dias');
	END if;
   RETURN NEW;
  END;
$agregar_bono$ LANGUAGE plpgsql;


CREATE TRIGGER agregar_bono AFTER INSERT 
    ON reservacion FOR EACH ROW 
    EXECUTE PROCEDURE agregar_bono();



--Trigger E)

CREATE OR REPLACE FUNCTION package_updater() RETURNS TRIGGER AS $package_updater$
  DECLARE
  BEGIN
   if new.id_departamento = 3 THEN
   	INSERT INTO promocion VALUES (default, 1,NEW.id_servicio,NULL);
	END if;
   RETURN NEW;
  END;
$package_updater$ LANGUAGE plpgsql;


CREATE TRIGGER package_updater after insert 
    ON servicio FOR EACH ROW 
    EXECUTE PROCEDURE package_updater();




--TRIGGER B
update reservacion SET activo = '0' where id_reservacion = 1;


--TRIGGER C
update cargo SET id_paquete = 2 where id_cargo = 4;


--TRIGGER D
INSERT INTO reservacion VALUES (default, 6, 6, 5, '1', 1, '2017-09-14', '2017-10-14', '2017-10-20');


--Trigger E
INSERT INTO servicio VALUES (default, 3, '0', 'Limpieza de Perro', 'Limpieza de perrukis', '200.0', '08:00:00', '20:00:00');
	
 




