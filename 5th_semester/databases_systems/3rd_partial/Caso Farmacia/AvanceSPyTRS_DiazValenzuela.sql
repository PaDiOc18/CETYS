#Un trigger del precio total de productos comprados por un cliente
#Un trigger del precio total de productos comprados a un proveedor (cambiarlo)

#Un stored procedure para seleccionar todos los trabajadores de un distrito 
#Un stored procedure para seleccionar todos los productos que tuvieron descuento en un intervalo de tiempo

DELIMITER //
CREATE PROCEDURE GetEmployeesFromDistrict(id_distrito int)
BEGIN
	SELECT *  FROM employee where id_district = id_distrito;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE GetProductosDiscBetweenDates(startdate date, enddate date)
BEGIN
	SELECT id_product,discount_amount FROM discount where start_date >= startdate and end_date <= enddate; #Agregar nombre del producto
END //
DELIMITER ;

call GetEmployeesFromDistrict(1);
call GetProductosDiscBetweenDates('2020-02-13','2020-04-13');

#PUEDE SER AFTER, aun falta pero eso para despues mejor
#CREATE TRIGGER ins_sum BEFORE INSERT ON account
#       FOR EACH ROW SET @sum = @sum + NEW.amount;
       
use farmacia3;
SELECT id_bill FROM bill WHERE id_bill = LAST_INSERT_ID();