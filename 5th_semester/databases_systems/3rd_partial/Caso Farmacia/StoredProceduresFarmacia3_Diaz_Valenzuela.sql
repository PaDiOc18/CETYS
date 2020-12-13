#Stored Procedures farmacia3
use farmacia3;
#Un stored procedure para seleccionar todos los trabajadores de un distrito 
DELIMITER //
CREATE PROCEDURE GetEmployeesFromDistrict(id_distrito int)
BEGIN
	SELECT *  FROM employee where id_district = id_distrito;
END //
DELIMITER ;

call GetEmployeesFromDistrict(1); #P

#Un stored procedure para seleccionar todos los productos que tuvieron descuento en un intervalo de tiempo
DELIMITER //
CREATE PROCEDURE GetProductosDiscBetweenDates(startdate date, enddate date)
BEGIN
    SELECT product.id_product,product.name_prod,product.price, discount.discount_amount, discount.start_date, discount.end_date FROM discount
	INNER JOIN product ON discount.id_product = product.id_product where start_date >= startdate and end_date <= enddate;
END //
DELIMITER ;

call GetProductosDiscBetweenDates('2020-02-13','2020-04-13');#P

#Un stored procedure para seleccionar todos los productos que esten cerca de el stock minimo
DELIMITER //
CREATE PROCEDURE GetProductsNeedRestock(stock_range int)
BEGIN
	SELECT product.id_product as ProductID, name_prod as ProductName, category.name_category as CategoryName, current_stock as CurrentStock, min_stock as MinimumStock, max_stock as MaximumStock FROM inventory 
    INNER JOIN product ON inventory.id_product = product.id_product 
    INNER JOIN category ON product.id_category = category.id_category
    where current_stock < min_stock + stock_range;
END //
DELIMITER ;

call GetProductsNeedRestock(30);

#Un stored procedure para calcular el total de ganancia a partir de una fecha
DELIMITER //
CREATE PROCEDURE GetTotalDistrictEarningsSince(id_district int, since_date date)
BEGIN
	SELECT id_district as DistrictID, district.name_distr as DistrictName, district.adress as DistrictAddress, since_date as EarningsSince, sum(total_cost) as TotalEarnings FROM bill
    INNER JOIN district on id_district = district.id_district
    WHERE bill.date_purchase >= since_date AND id_district = bill.id_district;
END //
DELIMITER ;

call GetTotalDistrictEarningsSince(2, '2020-04-12 00:00:00');

# Un stored procedure para encontrar la informacion de un empleado relacionado a una cuenta
DELIMITER //
CREATE PROCEDURE GetEmployeeFromUserAccount(username varchar(20))
BEGIN
	SELECT employee.id_employee as EmployeeID, username as Username, employee.name_employee as EmployeeName, employee.lastname1_employee as EmployeeLastName, employee.phone_number as PhoneNumber, district.name_distr as DistrictName FROM userr 
    INNER JOIN employee ON userr.id_employee = employee.id_employee
    INNER JOIN district ON district.id_district = employee.id_district
    WHERE username = userr.username;
END //
DELIMITER ;

call GetEmployeeFromUserAccount('e002');








