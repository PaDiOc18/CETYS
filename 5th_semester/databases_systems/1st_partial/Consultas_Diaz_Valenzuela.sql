use farmacia3;

#Mostrar de que sucursal fueron vendidos los bills
select * from bill inner join district on bill.id_district = district.id_district;
#Mostrar los datos del bill entre dos fechas
select * from bill where date_purchase between '2020-03-04 00:00:00' and '2020-05-20 00:00:00';
#Cuales productos requieren receta medica
select * from product where id_category = 11;
#Los productos suministrados por los diferentes proveedores
select product.name_prod,product.type_,product.ingredients,supplier_products.quantity,supplier_products.total_price,supplier.id_supplier,supplier.name_supplier from 
product inner join supplier_products on product.id_product = supplier_products.id_product
inner join supplier on  supplier.id_supplier = supplier_products.id_sup;
#Enlistar los productos comprados por un cliente que requieran receta medica(ANTIBIOTICOS)
select clientt.id_client,clientt.name_client,clientt.lastname1_client,clientt.phone_number, product.id_product,product.name_prod,product.ingredients,product.price from 
clientt inner join bill on clientt.id_client = bill.id_client
inner join billproducts on  billproducts.id_bill = bill.id_bill 
inner join product on  product.id_product = billproducts.id_product 
where clientt.id_client = 7 and product.id_category = 11;


#Mostrar informacion de contacto para un proveedor
select name_supplier as SupplierName, email_supplier as Email, phone_number as PhoneNumber from supplier where name_supplier = "MedLine";
#Mostrar el descuento que tiene un producto
select discount.id_product as ProductID, product.name_prod as ProductName, discount.discount_amount as DiscountAmount, discount.end_date as DiscountValidUntil from discount 
inner join product on discount.id_product = product.id_product
where discount.id_product = 1;
#Mostrar productos que necesitan restock (un product necesita restock si tiene menos de 20 items mas que el min stock)
select inventory.id_product as ProductID, product.name_prod as ProductName, inventory.current_stock as CurrentStock, inventory.min_stock as MinStock, inventory.max_stock as MaxStock from inventory 
inner join product on inventory.id_product = product.id_product
where current_stock - 20 < min_stock;
#Mostrar los empleados con acceso a sistema
select employee.id_employee as EmployeeID, userr.id_user as UserID, userr.username as Username, employee.name_employee as EmployeeName, employee.lastname1_employee as EmployeeLastName from employee
inner join userr on employee.id_employee = userr.id_employee;
#Mostrar todos los empleados que trabajan en cierto distrito
select employee.id_employee as EmployeeID, employee.name_employee as EmployeeName, employee.lastname1_employee as EmployeeLastName, employee.position_employee as EmployeePosition, district.name_distr as DistrictName from employee
inner join district on employee.id_district = district.id_district
where district.name_distr = "Sucursal Tijuana";
#Mostrar cuantos empleados trabajan en cada distrito
select district.id_district as DistrictID, district.name_distr as DistrictName, count(employee.id_employee) as EmployeeCount, sum(employee.salary_employee) as TotalPay from district
inner join employee on district.id_district = employee.id_district group by district.name_distr order by TotalPay desc;