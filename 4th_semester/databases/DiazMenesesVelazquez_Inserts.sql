use tallerestrellitafugaz;

insert into cliente values(1,'Pablo','Diaz','Ochoa','M','Villa Fontana','2020-09-27',6647098461,10);
insert into cliente values(2,'Gerardo','Hernandez','Meneses','M','El lago','2000-03-19',66498562,15);
insert into cliente values(3,'Daniel','Velazquez','Nomelose','M','Teran Teran','2000-12-07',6647098461,30);
insert into cliente values(4,'Diego','Garibay','Zuazo','M','La 51','2000-08-11',6647098461,50);
insert into cliente values(5,'Dolores','Monarrez','Herrera','F','Santa Fe','2000-08-27',6647098461,22);
insert into cliente values(6,'Alejandro','Flores','Aquino','M','Buenos Aires Sur','1997-08-4',6647098461,7);
insert into cliente values(7,'Ana','Laura','Norecuerdo','F','5 y 10','2000-02-03',6647098461,60);
insert into cliente values(8,'Michel','Vielma','Norecuerdo2','F','Villa Fontana','1998-01-02',6647098461,28);
insert into cliente values(9,'Daniela','Torres','Inzunza','F','Otay','2001-04-05',6647098461,33);
insert into cliente values(10,'Sofia','Torres','Velazquez','F','La Morita','1985-07-17',6647098461,37);

insert into vehiculo values(1,'Toyota','Highlander',2008,'verde','2016-03-28',1);
insert into vehiculo values(2,'Honda','Civic',2004,'gris','2016-05-13',1);
insert into vehiculo values(3,'Chevrolet','Camaro',2011,'rojo','2016-08-09',2);
insert into vehiculo values(4,'Jeep','Wrangler',2018,'negro','2017-02-17',2);
insert into vehiculo values(5,'Volkswagen','Jetta',2009,'arena','2017-06-23',2);
insert into vehiculo values(6,'Nissan','Versa',2011,'azul','2017-10-14',4);
insert into vehiculo values(7,'Nissan','X-trail',2015,'gris','2018-01-07',3);
insert into vehiculo values(8,'Honda','CR-V',2018,'blanco','2018-01-04',3);
insert into vehiculo values(9,'Honda','CH-R',2020,'rojo','2018-03-18',5);
insert into vehiculo values(10,'Mazda','3',2009,'amarillo','2018-05-19',6);
insert into vehiculo values(11,'Tesla','Roadster',2020,'verde','2018-06-11',6);
insert into vehiculo values(12,'Tesla','Model S',2020,'gris','2018-06-18',6);
insert into vehiculo values(13,'Mazda','5',2012,'azul','2018-08-26',7);
insert into vehiculo values(14,'Suzuki','Swift',2016,'rojo','2018-09-13',8);
insert into vehiculo values(15,'Toyota','Rav-4',1997,'negro','2018-11-24',9);
insert into vehiculo values(16,'Subaru','XV',2017,'naranja','2018-12-21',10);

/*Cobramos el 10 porciento del presupuesto*/                  
insert into diagnostico values(1,125.03,1250.30,"Falla en Bomba de Agua",1);
insert into diagnostico values(2,218.06,2180.60,"Falla en Radiador",2);
insert into diagnostico values(3,500,5000,"Falla en Transmision",3);
insert into diagnostico values(4,185.05,1850.50,"Falla en las bocinas",4);
insert into diagnostico values(5,323.05,3230.50,"Cambio de Bujias",5);
insert into diagnostico values(6,40,400,"Balatas Gastadas",6);
insert into diagnostico values(7,125.03,1250.30,"Aire Acondicionado",7);
insert into diagnostico values(8,80.05,800.50,"Fusibles en mal estado",8);
insert into diagnostico values(9,250,2500,"Problemas de encendido",9);
insert into diagnostico values(10,450,4500.83,"Pintura del automovil",10);
insert into diagnostico values(11,65.05,650.50,"Abolladura en el guardafango",11);
insert into diagnostico values(12,25,250,"Divergencia en llantas delantera",12);
insert into diagnostico values(13,20,200,"Convergencia enn llantas traseras",13);
insert into diagnostico values(14,75,750,"Radio no prende",14);
insert into diagnostico values(15,150,1500,"Tablero no marca velocidad",15);     
insert into diagnostico values(16,133.44,1334.45,"Cambiar bomba de gasolina",16);   
/*insert into diagnostico values(17,133.44,1334.45,"Cambiar bomba de gasolina",1);   */

insert into supervisor values(1,'Francisco','Armenta','Gonzalez','M','Altabrisa','1985-12-06',6649845362);
insert into supervisor values(2,'Samuel','Zurita','Pena','M','Altiplano','1986-07-13',6646798436);
insert into supervisor values(3,'Michelle','Vargas','Perez','F','Otay','1988-01-27',6640364789);
insert into supervisor values(4,'Kate','Covarrubias','Cota','F','Villa del Sol','1983-04-18',6649637469);
insert into supervisor values(5,'Misael','Perez','Rodriguez','M','Zona rio','1981-09-30',6643279014);

insert into departamento values(1,"Carroceria y Pintura",1,"Hacen servicios referentes a choques, abolladuras, pintura,etc");
insert into departamento values(2,"Electrico",2,"Hacen servicios referente a lo electrico, como ventanas que no bajan, baterias, etc");
insert into departamento values(3,"Alineacion y Balanceo, Suspension",3,"Hacen servicios referentes a las flechas del carro, alinean y balancean");
insert into departamento values(4,"Mecanico",4,"Hacen servicios referentes a casi todo tipo de fallas en el coche");
insert into departamento values(5,"Refaccionaria",5,"Estos nomas buscan piezas y las dan, pagar menos plis");

/*ALTER TABLE mecanico ADD FOREIGN KEY (id_mecresp) REFERENCES mecanico_respo(id_mecanicoresp);*/
insert into mecanico values(1,'Javier','Veliz', 'Andalon','1998-06-09',75,8,1);
insert into mecanico values(2,'Yessica','Jacobo', 'Ramirez','1999-11-01',150,7,2);
insert into mecanico values(3,'Jose','Camino', 'Velasco','1997-07-02',78,12,3);
insert into mecanico values(4,'Aislinn','Gracia', 'Guzman','2000-07-01',240,12,4);
insert into mecanico values(5,'Alejandro','Solis', 'Huerta' ,'1997-02-21',130,8,5);
insert into mecanico values(6,'Jennifer','Orenday', 'Lepe','1999-09-18',220,48,1);
insert into mecanico values(7,'Luis','Cruz', 'Alvarez','1999-01-23',330,40,2);
insert into mecanico values(8,'Miguel','Ojeda', 'Sanchez','2000-06-21',400,37,3);
insert into mecanico values(9,'Eduardo','Ramos','Espinoza','2000-08-19',300,40,4);
insert into mecanico values(10,'Alejandro','Medina','Contreras','2000-05-14',500,48,5);
Insert into mecanico values(11,'Zayra','Zarate', 'Villegas','2000-07-16',550,42,1);
insert into mecanico values(12,'Diego','Jimenez', 'Ruíz','1999-02-09',200,30,2);
Insert into mecanico values(13,'Ricardo','Camacho', 'Eaton','1997-11-02',150,8,3);
Insert into mecanico values(14,'Iván','Suro', 'Mascareño','1999-10-05',250,35,4);
Insert into mecanico values(15,'Mariano','Prado', 'Piña','1998-05-17',150,20,5);
							   
insert into servicio values (1,4,4,1,'Falla en Bomba de Agua','2019-12-23','2019-12-24',1);
insert into servicio values (2,9,4,2,'Falla en Radiador','2019-01-01','2019-01-03',2);
insert into servicio values (3,14,4,3,'Falla en Transmision','2019-02-02','2019-02-05',3);
insert into servicio values (4,2,2,4,'Falla en las bocinas','2019-03-01','2019-03-02',4);
insert into servicio values (5,7,2,5,'Cambio de Bujias','2019-04-01','2019-04-02',5);
insert into servicio values (6,4,4,6,'Balatas Gastadas','2019-05-01','2019-05-01',6);
insert into servicio values (7,2,2,7,'Aire Acondicionado','2019-06-02','2019-06-03',7);
insert into servicio values (8,7,2,8,'Fusibles en mal estado','2019-07-02','2019-07-04',8);
insert into servicio values (9,12,2,9,'Problemas de encendido','2019-08-17','2019-08-21',9);
insert into servicio values (10,1,1,10,'Pintura del automovil','2019-10-15','2019-10-18',10);
insert into servicio values (11,3,3,11,'Abolladura en el guardafango','2020-01-01','2020-01-01',11);
insert into servicio values (12,8,3,12,'Divergencia en llantas delantera','2020-02-02','2020-02-02',12);
insert into servicio values (13,7,2,13,'Convergencia enn llantas traseras','2020-03-02','2020-03-03',13);
insert into servicio values (14,2,2,14,'Radio no prende','2020-04-05','2020-04-06',14);
insert into servicio values (15,4,4,15,'Tablero no marca velocidad','2020-04-06','2020-04-06',15);
insert into servicio values (16,4,4,16,'Cambiar bomba de gasolina','2020-05-02','2020-05-03',16);
/*insert into servicio values (17,4,4,1,'Falla en Bomba de Agua','2020-01-21','2020-01-22',17);*/

insert into pedido values(1,1,1,1,800);
insert into pedido values(2,2,2,1,2500);
insert into pedido values(3,3,3,1,5500);
insert into pedido values(4,4,4,1,750);
insert into pedido values(5,5,5,1,1500);
insert into pedido values(6,6,6,1,1800);
insert into pedido values(7,7,7,1,3000);
insert into pedido values(8,8,8,1,450);
insert into pedido values(9,9,9,1,500);
insert into pedido values(10,10,10,1,4500);
insert into pedido values(11,11,11,1,15000);
insert into pedido values(12,12,12,1,2000);
insert into pedido values(13,13,13,1,2000);
insert into pedido values(14,14,14,1,350);
insert into pedido values(15,15,15,1,250);
insert into pedido values(16,16,16,1,1800);
/*insert into pedido values(17,16,16,1,1800);*/ /*Hack 2.0*/

/*Le sumamos 100 pesos a los productos que compramos para ganarle 100 x producto*/
insert into producto values(1,'Bomba de agua',800,'Toyota','Highlander','2008',4);
insert into producto values(2,'Radiador',2500,'Honda','Civic','2004',4);
insert into producto values(3,'Transmision',5500,'Chevrolet','Camaro','2011',4);
insert into producto values(4,'Bocina',750,'Jeep','Wrangler',2018,2);
insert into producto values(5,'Bujias',1500,'Volkswagen','Jetta','2009',2);
insert into producto values(6,'Balata',1800,'Nissan','Versa','2011',4);
insert into producto values(7,'Aire Acondicionado',3000,'Nissan','X-trail','2015',2);
insert into producto values(8,'Fusibles',450,'Honda','CR-V',2018,2);
insert into producto values(9,'cable',500,'Honda','CH-R','2020',2);
insert into producto values(10,'Pintura',4500,'Mazda','3','2009',1);
insert into producto values(11,'Guardafango',15000,'Testla','Roadster','2020',1);
insert into producto values(12,'Llanta',2000,'Testla','Model S','2020',3);
insert into producto values(13,'Llanta',2000,'Mazda','5','2012',2);
insert into producto values(14,'Cable',350,'Suzuki','Swift',2016,2);
insert into producto values(15,'Conector',250,'Toyota','Rav-4',1997,4);
insert into producto values(16,'Bomba',1800,'Subaru','XV',2017,4);

insert into bodega values(1,20,10,30);
insert into bodega values(2,15,10,30);
insert into bodega values(3,1,1,30);
insert into bodega values(4,3,1,30);
insert into bodega values(5,6,5,30);
insert into bodega values(6,20,10,30);
insert into bodega values(7,2,1,30);
insert into bodega values(8,40,10,50);
insert into bodega values(9,3,1,30);
insert into bodega values(10,1,1,30);
insert into bodega values(11,1,0,30); /*Tesla es muy caro */
insert into bodega values(12,1,0,30); /*Tesla es muy caro */
insert into bodega values(13,20,10,30);
insert into bodega values(14,30,10,30);
insert into bodega values(15,1,0,30);
insert into bodega values(16,25,10,30);

insert into proveedor values(1,'El gallo','Aguascalientes Sur');
insert into proveedor values(2,'El Huasteco','Aguascalientes Norte');
insert into proveedor values(3,'La Garza','Venencia Este');
insert into proveedor values(4,'Bob Toronja','San Bernardo Oeste');
insert into proveedor values(5,'San Agustin','Rucasteca Noroeste');

/*A los precios de las compras les ganamos 100 pesos por producto*/
insert into compra values(1,"Bomba de Agua para Toyota Highlander 2008", 700, 'Tarjeta de Credito',20, 1,1);
insert into compra values(2,"Radiador Honda Civic 2004", 2400, 'Tarjeta de Credito',15, 2,2);
insert into compra values(3,"Transmision Chevrolet Camaro 2011",5400 , 'Tarjeta de Credito',1, 3,3);
insert into compra values(4,"Bocina Jeep Wrangler 2018", 650, 'Tarjeta de Credito',3, 4,4);
insert into compra values(5,"Bujias para Volkswagen Jetta 2009", 1400, 'Tarjeta de Credito',6, 5,5);
insert into compra values(6,"Balatas para Nissan Versa 2011", 1700, 'Tarjeta de Credito',20, 6,1);
insert into compra values(7,"Aire Acondicionado para Nissan X-trail 2015", 2900, 'Tarjeta de Credito',2, 7,2);
insert into compra values(8,"Fusibles para Honda CR-V 2018", 350, 'Tarjeta de Credito',40, 8,3);
insert into compra values(9,"Cable arrancador para Honda HR-V 2020", 400, 'Tarjeta de Credito',3, 9,4);
insert into compra values(10,"Pintura para Mazda 3 2009", 4400, 'Tarjeta de Credito',1, 10,5);
insert into compra values(11,"Guardafango para Tesla Roaster 2020", 14900, 'Tarjeta de Credito',1, 11,1);
insert into compra values(12,"Llanta para Tesla Model S 2020", 1900, 'Tarjeta de Credito',1, 12,2);
insert into compra values(13,"Llanta para Mazda 5 2012", 1900, 'Tarjeta de Credito',20, 13,3);
insert into compra values(14,"Cable para radio Suzuki Swift 2016",250, 'Tarjeta de Credito',30, 14,4);
insert into compra values(15,"Conector Toyota Rav-4 1997",150, 'Tarjeta de Credito',1, 15,5);
insert into compra values(16,"Bomba Gasolina para SUbaru XV 2017", 1700, 'Tarjeta de Credito',25, 16,1);

insert into promocion values(1,0.15,'2019-01-01','2019-02-01','General');
insert into promocion values(2,0.16,'2019-02-02','2019-03-01','General');
insert into promocion values(3,0.17,'2019-03-02','2019-04-01','General');
insert into promocion values(4,0.18,'2019-04-02','2019-05-01','General');
insert into promocion values(5,0.19,'2019-05-02','2019-12-31','General');
insert into promocion values(6,0.32,'2020-01-01','2020-02-01','Recurrente');
insert into promocion values(7,0.33,'2020-02-02','2020-03-01','Recurrente');
insert into promocion values(8,0.34,'2020-03-02','2020-04-01','Recurrente');
insert into promocion values(9,0.35,'2020-04-02','2020-05-01','Recurrente');
insert into promocion values(10,0.36,'2020-05-02','2020-06-01','Recurrente');

/*Si es mayor o igual a 15 visitas el cliente, entonces es un cliente recurrente*/
insert into venta values(1,1,800+800,(800+800)-(800+800)*0.19,'2019-12-24',5,'Cash');
insert into venta values(2,2,700+2500,(700+2500)-(700+2500)*0.19,'2019-01-03',5,'Cash');
insert into venta values(3,3,3500+5500,(3500+5500)-(3500+5500)*0.16,'2019-02-05',2,'Tarjeta de Credito');
insert into venta values(4,4,350+750,(350+750)-(350+750)*0.17,'2019-03-02',3,'Cash');
insert into venta values(5,5,550+1500,(550+1500)-(550+1500)*0.18,'2019-04-02',4,'Tarjeta de Credito');
insert into venta values(6,6,350+1800,(350+1800)-(350+1800)*0.18,'2019-05-01',4,'Cash');
insert into venta values(7,7,1200+3000,(1200+3000)-(1200+3000)*0.19,'2019-06-03',5,'Cash');
insert into venta values(8,8,400+450,(400+450)-(400+450)*0.19,'2019-07-04',5,'Tarjeta de Credito');
insert into venta values(9,9,690+500,(690+500)-(690+500)*0.19,'2019-08-21',5,'Cash');
insert into venta values(10,10,2500+4500,(2500+4500)-(2500+4500)*0.19,'2019-10-18',5,'Tarjeta de Credito');
insert into venta values(11,11,250+15000,250+15000,'2020-01-01',null,'Cash');
insert into venta values(12,12,100+2000,100+2000,'2020-02-02',null,'Tarjeta de Credito');
insert into venta values(13,13,100+2000,(100+2000)-(100+2000)*0.34,'2020-03-03',8,'Cash');
insert into venta values(14,14,350+350,(350+350)-(350+350)*0.35,'2020-04-06',9,'Tarjeta de Credito');
insert into venta values(15,15,250+250,(250+250)-(250+250)*0.35,'2020-04-06',9,'Cash');
insert into venta values(16,16,900+1800,(900+1800)-(900+1800)*0.36,'2020-05-03',10,'Tarjeta de Credito');

/*60 porciento de cobertura tiene la garantía en todos los trabajos*/
insert into garantia values(1,1,1,((800+800)-(800+800)*0.19)*0.6,'2019-12-24','2019-12-24',0);/*good*/
insert into garantia values(2,2,2,((700+2500)-(700+2500)*0.19)*0.6,'2019-01-03','2019-02-03',1);
insert into garantia values(3,3,3,((3500+5500)-(3500+5500)*0.16)*0.6,'2019-02-05','2019-03-05',0);
insert into garantia values(4,4,4,((350+750)-(350+750)*0.17)*0.6,'2019-03-02','2019-04-02',0);
insert into garantia values(5,5,5,((550+1500)-(550+1500)*0.18)*0.6,'2019-04-02','019-05-02',1);
insert into garantia values(6,6,6,((350+1800)-(350+1800)*0.18)*0.6,'2019-05-01','2019-06-01',0);
insert into garantia values(7,7,7,((1200+3000)-(1200+3000)*0.19)*0.6,'2019-06-03','2019-07-03',1);
insert into garantia values(8,8,8,((400+450)-(400+450)*0.19)*0.6,'2019-07-04','2019-08-04',0);
insert into garantia values(9,9,9,((690+500)-(690+500)*0.19)*0.6,'2019-08-21','2019-09-21',1);
insert into garantia values(10,10,10,((2500+4500)-(2500+4500)*0.19)*0.6,'2019-10-18','2019-11-18',0);
insert into garantia values(11,11,11,(250+15000)*0.6,'2020-01-01','2020-02-01',1);
insert into garantia values(12,12,12,(100+2000)*0.6,'2020-02-02','2020-03-02',0);
insert into garantia values(13,13,13,((100+2000)-(100+2000)*0.34)*0.6,'2020-03-03','2020-04-03',0);
insert into garantia values(14,14,14,((350+350)-(350+350)*0.35)*0.6,'2020-04-06','2020-05-06',1);
insert into garantia values(15,15,15,((250+250)-(250+250)*0.35)*0.6,'2020-04-06','2020-05-06',0);
insert into garantia values(16,16,16,((900+1800)-(900+1800)*0.36)*0.6,'2020-05-03','2020-06-03',1);