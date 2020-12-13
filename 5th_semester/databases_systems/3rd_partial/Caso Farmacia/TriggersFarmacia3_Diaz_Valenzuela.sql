#Triggers farmacia3
use farmacia3;
#Si no tiene cedulaProfesional la prescription, entonces no es valida y se marca error
DELIMITER |
CREATE TRIGGER PrescriptionIDCardCheck 
	before INSERT ON prescription 
    FOR EACH ROW
BEGIN
IF NEW.id_card is null THEN 
	SIGNAL SQLSTATE '45000'
	SET MESSAGE_TEXT = 'Prescription no tiene numero de cedula';
END IF;
END;
|DELIMITER ;

insert into prescription values(16, null, '2020-02-13',"Pablo","Diaz","Ochoa"); #Correcto P
        
#Si quiere agregar un discount con mas del 100% o un descuento negativo, la vuelve 0, ya que no es válido un descuento del 100%.
DELIMITER |
CREATE TRIGGER DiscountCheck 
	BEFORE INSERT ON discount 
    FOR EACH ROW 
BEGIN
IF NEW.discount_amount >= 1 or NEW.discount_amount <= 0 THEN
	 	SIGNAL SQLSTATE '45000'
	SET MESSAGE_TEXT = 'Descuento no valido';
END IF;
END;    
|DELIMITER ;

insert into discount values(16,'2020-02-13','2020-05-13',2,2); #Correcto P

#Si queremos agregar una categoria que no tienen nombre, entonces arroja el error
DELIMITER |
CREATE TRIGGER CategoryCheck 
	after INSERT ON category 
    FOR EACH ROW 
BEGIN
IF NEW.name_category IS null THEN
	SIGNAL SQLSTATE '45000'
	SET MESSAGE_TEXT = 'No tiene nombre de categoria';
END IF;
END;
|DELIMITER ;

insert into category values(16, null,1); #Correcto P

#Si se cambia de puesto a un empleado, tambien cambiar su salario
DELIMITER $$
CREATE TRIGGER EmployeePositionChange 
	BEFORE UPDATE 
    ON employee FOR EACH ROW 
BEGIN
IF NEW.position_employee = 'Limpieza' THEN
	 SET NEW.salary_employee = '7500';
ELSEIF NEW.position_employee = 'Doctor' THEN
	 SET NEW.salary_employee = '12000';
ELSEIF NEW.position_employee = 'Cajero' THEN
	 SET NEW.salary_employee = '9000';
ELSE
     SIGNAL SQLSTATE '45000'
     SET MESSAGE_TEXT = "Could not update employee's salary";
END IF;
END$$ 
DELIMITER ;

UPDATE employee SET position_employee = 'Cajero' WHERE id_employee = 2;

# Trigger por si el telefono no tiene la cantidad minima de digitos
DELIMITER |
CREATE TRIGGER PhoneDigitCheck 
	BEFORE UPDATE 
    ON clientt FOR EACH ROW 
BEGIN
IF CHAR_LENGTH(NEW.phone_number) < 10 THEN
	SIGNAL SQLSTATE '45000'
	SET MESSAGE_TEXT = 'El teléfono no cumple con los dígitos minimos requeridos';
END IF;
END;
|DELIMITER ;

UPDATE clientt SET phone_number = '6647098461' WHERE id_client = 1;

#select * from information_schema.TRIGGERS;

#DROP TRIGGER PrescriptionIDCardCheck; 
#DROP TRIGGER DiscountCheck; 
#DROP TRIGGER CategoryCheck; 
#DROP TRIGGER EmployeePositionChange; 
#DROP TRIGGER PhoneDigitCheck; 







