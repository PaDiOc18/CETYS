create database hotelazoPostgreSQL;

create table huesped_principal(
	id_huesped serial primary key,
	nombre varchar,
	edad int,
	direccion varchar,
	fecha_nacimiento date,
	sexo char,
	telefono varchar,
	telefono_cel varchar,
	correo_electronico varchar,
	rfc varchar,
	procedencia varchar
);

create table categoria_habitacion(
	id_categoria serial primary key,
	nombre varchar,
	descripcion varchar,
	precio numeric
);

create table departamento(
	id_departamento serial primary key,
	nombre varchar,
	descripcion varchar
);

create table paquete(
	id_paquete serial primary key,
	nombre varchar,
	descripcion varchar,
	fecha_inicio date,
	fecha_fin date,
	costo numeric(15,2)
);

create table queja(
	id_queja serial primary key,
	id_huesped int,
	id_departamento int,
	fechaInicio date,
	fechaFin date,
	activa bool,
	seguimiento varchar,
	razon varchar,
	Foreign key (id_huesped) references huesped_principal(id_huesped)
);

create table habitacion(
	id_habitacion serial primary key,
	id_categoria int,
	disponible bool,
	capacidad int,
	Foreign key (id_categoria) references categoria_habitacion(id_categoria)
);

create table empleado(
	id_empleado serial primary key,
	id_departamento int,
	nombre varchar,
	edad int,
	sexo char,
	telefono varchar,
	direccion varchar,
	correo_electronico varchar,
	fecha_nacimiento date,
	fecha_contratacion date,
	rfc varchar,
	Foreign key (id_departamento) references departamento(id_departamento)
);

create table servicio(
	id_servicio serial primary key,
	id_departamento int, 
	externo bool,
	nombre varchar,
	descripcion varchar,
	costo numeric(15,2),
	abre time,
	cierra time,
	Foreign key (id_departamento) references departamento(id_departamento)
);

create table promocion(
	id_promocion serial primary key,
	id_paquete int,
	id_servicio int NULL,
	id_categoria int NULL,
	Foreign key (id_servicio) references servicio(id_servicio),
	Foreign key (id_categoria) references categoria_habitacion(id_categoria),
	Foreign key (id_paquete) references paquete(id_paquete)
);

create table bono(
	id_bono serial primary key,
	id_empleado int,
	fecha date,
	cantidad numeric(10,2),
	razon varchar,
	Foreign key (id_empleado) references empleado(id_empleado)
);

create table reservacion(
	id_reservacion serial primary key,
	id_huesped int,
	id_empleado int,
	id_habitacion int,
	activo bool,
	tipo_reservacion int,
	fecha_reservacion date,
	fecha_inicio date,
	fecha_final date,
	Foreign key (id_huesped) references huesped_principal(id_huesped),
	Foreign key (id_empleado) references empleado(id_empleado),
	Foreign key (id_habitacion) references habitacion(id_habitacion)
);

create table factura(
	id_factura serial primary key,
	id_empleado int,
	id_reservacion int,
	id_huesped int,
	fecha date,
	total numeric(15,2),
	Foreign key (id_reservacion) references reservacion(id_reservacion),
	Foreign key (id_huesped) references huesped_principal(id_huesped),
	Foreign key (id_empleado) references empleado(id_empleado)
);

create table cargo(
	id_cargo serial primary key,
	id_factura int,
	fecha date,
	id_paquete int NULL,
	id_servicio int NULL,
	id_categoria int NULL,
	total numeric(15,2),
	Foreign key (id_factura) references factura(id_factura),
	Foreign key (id_servicio) references servicio(id_servicio),
	Foreign key (id_categoria) references categoria_habitacion(id_categoria),
	Foreign key (id_paquete) references paquete(id_paquete)
);

create table huesped_acompanante(
	id_reservacion int,
	nombre varchar,
	fecha_nacimiento date,
	correo_electronico varchar,
	Foreign key (id_reservacion) references reservacion(id_reservacion)
);



INSERT INTO huesped_principal VALUES (default, 'Dr. Hayden Herman', 24, '2020 Ebba Garden\nRashawncheste', '1996-05-17', 'M', '947-419-6965', '307.815.7109', 'etha35@gmail.com', 'lgtj3025583dh', 'Lake');
INSERT INTO huesped_principal VALUES (default, 'Hilda Macejkovic', 21, '8607 Noe Centers\nThadhaven, TN', '1999-11-16', 'F', '256.626.8004x56997', '385-743-5735x5399', 'hoppe.jerrell@rice.com', 'fego2295679uy', 'West');
INSERT INTO huesped_principal VALUES (default, 'Elijah Predovic', 31, '481 Simonis Estate Suite 396\nC', '1989-02-16', 'F', '290.601.8115', '1-024-733-9271x4201', 'maryam75@walshshields.com', 'qmri1478489ru', 'New');
INSERT INTO huesped_principal VALUES (default, 'Blaise Little', 46, '066 Kiehn Lights Suite 522\nOli', '1974-05-30', 'M', '1-314-386-1662x06910', '1-471-084-1707x3282', 'hammes.roger@yahoo.com', 'ztzj1361309pr', 'East');
INSERT INTO huesped_principal VALUES (default, 'Dale Daniel', 23, '778 Sasha Corner\nWest Jamil, R', '1997-05-21', 'M', '+52(7)9448840436', '740-722-0953x85756', 'dickinson.reid@brakus.biz', 'fuqi9851614ra', 'North');
INSERT INTO huesped_principal VALUES (default, 'Prof. Imani Kunze', 45, '8078 Armstrong Mountains Suite', '1975-05-03', 'F', '1-062-148-6972', '1-487-884-8086x18213', 'kamren67@hoppe.com', 'ztqf2400051iw', 'South');
INSERT INTO huesped_principal VALUES (default, 'Kaelyn Macejkovic', 27, '455 Kenyon Extension\nHermiston', '1993-06-16', 'F', '+72(8)5332481441', '355.272.6746', 'garret15@beahanwill.com', 'tjad2819311dd', 'East');
INSERT INTO huesped_principal VALUES (default, 'Jerod Oberbrunner', 33, '961 Muriel Courts\nStevestad, S', '1987-01-05', 'M', '579.216.1845x927', '453.412.4259x3237', 'cleta.stokes@gmail.com', 'ezye7725632ka', 'West');
INSERT INTO huesped_principal VALUES (default, 'Norberto Brown DDS', 43, '0285 Christop Prairie Apt. 357', '1977-10-05', 'M', '02489766889', '1-523-692-4030x55351', 'dickinson.gwendolyn@towne.com', 'vyti4832704kr', 'East');
INSERT INTO huesped_principal VALUES (default, 'Opal Pollich', 31, '65113 Mable Walks\nPort Julian,', '1989-05-24', 'M', '168.528.7566', '(172)807-8179x569', 'jacobson.kenna@ortiz.com', 'drxx6080276es', 'West');
INSERT INTO huesped_principal VALUES (default, 'Ms. Onie Kulas V', 28, '61047 Aliza Brook\nStewartchest', '1992-01-03', 'M', '01680378502', '1-863-527-0909x970', 'chyna.west@hotmail.com', 'ugot9320638ul', 'Lake');
INSERT INTO huesped_principal VALUES (default, 'Erick Huel', 51, '35465 Ledner Squares\nNew Billi', '1969-08-05', 'F', '803.679.4992x81702', '1-205-694-0772x49265', 'cortez.kirlin@yahoo.com', 'ycre8542479lh', 'West');
INSERT INTO huesped_principal VALUES (default, 'Marquis Grady', 42, '558 Rhoda Motorway Apt. 888\nNo', '1978-01-12', 'F', '1-077-047-9763', '(988)365-8269x79451', 'jamir53@gmail.com', 'oeyf7671713yk', 'North');
INSERT INTO huesped_principal VALUES (default, 'Oran Abbott', 39, '928 Lindsay Shore\nKochstad, GA', '1981-02-01', 'F', '076.638.6680x010', '854.693.6417', 'lila17@yahoo.com', 'sfqn2942265oo', 'North');
INSERT INTO huesped_principal VALUES (default, 'Johnathan Donnelly', 16, '948 Camron Wells\nPort Sammysta', '2004-12-11', 'M', '1-375-112-5102', '482-921-3132x114', 'houston21@gmail.com', 'dduk5546694fb', 'New');

insert into categoria_habitacion values(default,'Individual', 'Habitacion con 1 cama',1900);
insert into categoria_habitacion values(default,'Doble', 'Habitacion con 2 camas',3800);
insert into categoria_habitacion values(default,'Triple', 'Habitacion con 3 camas',5700);
insert into categoria_habitacion values(default,'Suite', 'Habitacion con lujos',7500);
insert into categoria_habitacion values(default,'Chungus', 'The biggest room we have',8400);
insert into categoria_habitacion values(default,'CakeRoom', 'For when you wanna eat cake',10500);


insert into departamento values(default,'Recepcion','Aqui se reciben los clientes');
insert into departamento values(default,'Cocina','Pertenece a todo lo de servicio de comida');
insert into departamento values(default,'Limpieza','Pertenece a todo lo de limpieza');
insert into departamento values(default,'Eventos','Pertenece a todo lo de eventos');
insert into departamento values(default,'Gimnasio','Pertenece a todo lo de gimnasio');

insert into paquete values(default,'Paquete Mr.Limpio','Incluye acceso ilimitado al servicio de limpieza','2020-06-12','2020-06-25',7400);
insert into paquete values(default,'Paquete basico','Incluye desayuno y un cuarto individual','2020-07-25','2020-07-25',2150);
insert into paquete values(default,'Paquete CAKE','Incluye salon de boda, una novia, Dj y un cuarto cakeRoom','2020-08-25','2020-08-25',16500);
insert into paquete values(default,'Paquete Fiesta','Incluye salon de eventos, y 3 cuartos individuales ','2020-09-25','2020-09-25',21500);
insert into paquete values(default,'Paquete Circo','Incluye el Diego Clown y una habitacion suite','2020-10-25','2020-10-25',2000);

INSERT INTO queja VALUES (default, 14, 3, '2019-03-23', '2019-04-05', '0', 'Concluido', 'Extravio de cartera');
INSERT INTO queja VALUES (default, 12, 1, '2019-04-22', NULL, '1', 'En espera de juzgado', 'Extravio de joyas');
INSERT INTO queja VALUES (default, 10, 4, '2019-05-01', '2019-05-12', '0', 'Concluido', 'Perdida de mandado');
INSERT INTO queja VALUES (default, 3, 2, '2019-06-22', '2019-06-26', '0', 'Concluido', 'Problemas de WiFi');
INSERT INTO queja VALUES (default, 15, 4, '2019-07-27', '2019-07-28', '0', 'Concluido', 'Servicio de limpieza malo');
INSERT INTO queja VALUES (default, 2, 1, '2019-08-19', NULL, '1', 'En espera de juzgado', 'Extravio de llaves de auto');
INSERT INTO queja VALUES (default, 13, 2, '2019-09-03', NULL, '1', 'En espera de busqueda', 'Extravio de cartera');
INSERT INTO queja VALUES (default, 5, 4, '2019-10-02', NULL, '1', 'En búsqueda', 'Extravio de un celular');
INSERT INTO queja VALUES (default, 4, 3, '2019-11-22', '2019-11-27', '0', 'Concluido', 'Extravio de laptop');
INSERT INTO queja VALUES (default, 8, 2, '2019-12-14', '2019-12-21', '0', 'Concluido', 'La llave de la habitacion no sirve');
INSERT INTO queja VALUES (default, 9, 3, '2020-01-20', '2020-01-28', '0', 'Concluido', 'Mucho ruido en la habitacion');
INSERT INTO queja VALUES (default, 15, 5, '2020-02-15', '2020-02-24', '0', 'Concluido', 'La regadera no sirve');
INSERT INTO queja VALUES (default, 11, 5, '2020-03-02', NULL, '1', 'En espera de juzgado', 'Robo de coche');
INSERT INTO queja VALUES (default, 6, 5, '2020-04-07', NULL, '1', 'En espera de transaccion de dinero', 'Robo de moto');
INSERT INTO queja VALUES (default, 7, 1, '2020-05-28', '2020-05-30', '0', 'Concluido', 'La regadera solo tiene agua fria');

INSERT INTO habitacion VALUES (default, 2, '1', 2);
INSERT INTO habitacion VALUES (default, 1, '1', 1);
INSERT INTO habitacion VALUES (default, 2, '0', 2);
INSERT INTO habitacion VALUES (default, 5, '0', 5);
INSERT INTO habitacion VALUES (default, 3, '0', 3);
INSERT INTO habitacion VALUES (default, 1, '0', 6);
INSERT INTO habitacion VALUES (default, 6, '1', 2);
INSERT INTO habitacion VALUES (default, 1, '1', 1);
INSERT INTO habitacion VALUES (default, 2, '1', 2);
INSERT INTO habitacion VALUES (default, 3, '0', 3);
INSERT INTO habitacion VALUES (default, 4, '0', 3);
INSERT INTO habitacion VALUES (default, 4, '1', 2);
INSERT INTO habitacion VALUES (default, 4, '1', 5);
INSERT INTO habitacion VALUES (default, 5, '1', 5);
INSERT INTO habitacion VALUES (default, 6, '1', 2);


INSERT INTO empleado VALUES (default, 1, 'Amaya Ortiz PhD', 27, 'F', '387-280-3880', '848 Lowe Brook\nNew Clay, NY 65', 'ghaag@spinkapowlowski.org', '1993-01-12', '2003-11-10', 'gcez3399310ok');
INSERT INTO empleado VALUES (default, 4, 'Dr. Kenneth Grant MD', 29, 'F', '(295)621-1052', '8975 Hermann Cove\nRessiecheste', 'hbechtelar@emmerichwisoky.com', '1991-12-19', '2003-11-10', 'pzzu1353604ax');
INSERT INTO empleado VALUES (default, 3, 'Teresa Davis', 35, 'F', '(670)280-3233x290', '35694 Donna Ford\nCreminstad, P', 'shyann.goyette@hotmail.com', '1985-12-25', '2003-11-10', 'gvyc8109118ki');
INSERT INTO empleado VALUES (default, 1, 'Garret Jones', 40, 'M', '993.957.8251x405', '62371 Bonita Shores Suite 765\n', 'jacobs.sherman@fadel.com', '1980-05-08', '2003-11-10', 'qeze4923217em');
INSERT INTO empleado VALUES (default, 3, 'Cheyanne Purdy DDS', 48, 'F', '283.784.3452x760', '8461 Shane Courts Suite 231\nCl', 'kilback.arlie@doyle.com', '1972-01-03', '2003-11-10', 'muzv6710673sf');
INSERT INTO empleado VALUES (default, 3, 'Jaiden Mante III', 42, 'M', '(093)657-7054x5679', '824 Armand River Apt. 965\nCris', 'drunolfsson@hotmail.com', '1978-09-12', '2003-11-10', 'sqzr8376261tc');
INSERT INTO empleado VALUES (default, 2, 'Mr. Baylee Schmidt', 26, 'F', '+25(7)8216577769', '6871 Morris Cliff\nFrancescobor', 'lauretta.hammes@gmail.com', '1994-04-29', '2003-11-10', 'dsct3659526pk');
INSERT INTO empleado VALUES (default, 4, 'Mrs. Hilda Fay', 38, 'M', '1-787-910-4734x7799', '81304 Hickle Overpass Suite 76', 'lacey57@yahoo.com', '1982-10-15', '2004-08-17', 'frzf8174421ws');
INSERT INTO empleado VALUES (default, 5, 'Palma Lakin MD', 39, 'F', '00121600132', '01154 Tillman Rapid Suite 746\n', 'bessie.o\conner@gmail.com', '1981-11-02', '2004-08-17', 'zvjd8693531st');
INSERT INTO empleado VALUES (default, 5, 'Dr. Lorine Hilll', 58, 'M', '1-726-162-0530', '34173 Kristy Oval\nGiovanimouth', 'clifford.lemke@williamsondare.', '1962-10-07', '2004-08-17', 'kyqv4135073yu');
INSERT INTO empleado VALUES (default, 3, 'Cicero Lockman', 37, 'M', '(201)911-9908x2017', '5068 Wilburn Camp\nCatalinaland', 'abigayle.ernser@torphy.info', '1983-01-24', '2004-08-17', 'qxip1491499hn');
INSERT INTO empleado VALUES (default, 2, 'Immanuel Deckow', 42, 'M', '(847)953-9694x0557', '3630 Magali View\nLake Angelina', 'kenton.smith@bartonmitchell.or', '1978-10-27', '2005-03-08', 'bhny2191701iv');
INSERT INTO empleado VALUES (default, 1, 'Vicenta Gleichner', 28, 'F', '05505534985', '56876 Emma Meadows Apt. 980\nLa', 'treutel.shad@lowe.com', '1992-12-12', '2005-03-08', 'drec1567928qi');
INSERT INTO empleado VALUES (default, 4, 'Paula Schmidt', 21, 'M', '+66(3)2323545926', '2066 Kamryn Summit\nLake Eda, V', 'emmett57@harveyhand.net', '1999-05-30', '2005-03-08', 'hwaf3121190ad');
INSERT INTO empleado VALUES (default, 1, 'Dr. Candido Keebler DDS', 46, 'F', '723.778.3862x905', '7003 Brakus Groves Apt. 842\nSo', 'elian26@trantow.com', '1974-01-27', '2005-03-08', 'cchq2082664xt');

INSERT INTO servicio VALUES (default, 3, '0', 'Limpieza de Ropa', 'Limpieza y doblado de ropa, se recoge y regresa a la habitación.', '200.0', '08:00:00', '20:00:00');
INSERT INTO servicio VALUES (default, 4, '1', 'DJ Pablo', 'DJ Pablo viene a tu habitación.', '5000.0', '18:00:00', '03:00:00');
INSERT INTO servicio VALUES (default, 2, '0', 'Desayuno', 'Cualquier plato de desayuno directamente a su habitación.', '350.0', '07:00:00', '22:00:00');
INSERT INTO servicio VALUES (default, 5, '0', 'Entrenadora Personal por Día', 'Entrenador de gimnasio profesional.', '400.0', '08:00:00', '20:00:00');
INSERT INTO servicio VALUES (default, 3, '1', 'Almuerzo', 'Cualquier plato de almuerzo directamente a su habitación.', '350.0', '07:00:00', '22:00:00');
INSERT INTO servicio VALUES (default, 5, '1', 'Entrenadora Personal por Semana', 'Entrenador de gimnasio profesional.', '2000.0', '08:00:00', '20:00:00');
INSERT INTO servicio VALUES (default, 4, '1', 'Chungus', 'Tu propio chungus directo a tu habitación.', '6000.0', '18:00:00', '03:00:00');
INSERT INTO servicio VALUES (default, 2, '1', 'Cena', 'Cualquier plato de desayuno directamente a su habitación.', '350.0', '07:00:00', '22:00:00');
INSERT INTO servicio VALUES (default, 4, '1', 'lil Manuel', 'lil Manuel viene a tu habitación.', '6000.0', '18:00:00', '03:00:00');
INSERT INTO servicio VALUES (default, 3, '1', 'Limpieza de Cuarto', 'Limpieza de habitaciones cuando sea necesario.', '200.0', '08:00:00', '22:00:00');
INSERT INTO servicio VALUES (default, 1, '0', 'Queja', 'Presentar una queja', '0.0', '06:00:00', '24:00:00');
INSERT INTO servicio VALUES (default, 1, '0', 'Transporte de Equipaje', 'Transporte de equipaje a o desde su habitación', '0.0', '08:00:00', '20:00:00');
INSERT INTO servicio VALUES (default, 2, '0', 'Botana', 'Cualquier botana directamente a su habitación.', '350.0', '08:00:00', '20:00:00');
INSERT INTO servicio VALUES (default, 5, '0', 'Pase de Gimnasio', 'Pase de invitado al gimnasio.', '100.0', '08:00:00', '20:00:00');
INSERT INTO servicio VALUES (default, 4, '1', 'DJ Big Snoot', 'DJ Big Snoot viene a tu habitación.', '5000.0', '14:00:00', '03:00:00');


INSERT INTO promocion VALUES (default, 1,1, NULL);
INSERT INTO promocion VALUES (default, 1,10, NULL);
INSERT INTO promocion VALUES (default, 2,3,NULL);
INSERT INTO promocion VALUES (default, 2,NULL,1);
INSERT INTO promocion VALUES (default, 3,NULL,6);
INSERT INTO promocion VALUES (default, 3,7,NULL);
INSERT INTO promocion VALUES (default, 3,2,NULL);
INSERT INTO promocion VALUES (default, 3,NULL,5);
INSERT INTO promocion VALUES (default, 4,NULL,5);
INSERT INTO promocion VALUES (default, 4,NULL,1);
INSERT INTO promocion VALUES (default, 4,NULL,1);
INSERT INTO promocion VALUES (default, 4,NULL,1);
INSERT INTO promocion VALUES (default, 5,NULL,4);
INSERT INTO promocion VALUES (default, 5,7,NULL);


INSERT INTO bono VALUES (default, 14, '2008-12-26', '533.65', 'Por ventas');
INSERT INTO bono VALUES (default, 5, '2008-08-04', '662.19', 'Por buen servicio');
INSERT INTO bono VALUES (default, 11, '2008-04-25', '584.93', 'Por buena retroalimentacion');
INSERT INTO bono VALUES (default, 10, '2008-07-31', '632.05', 'Por menos quejas');
INSERT INTO bono VALUES (default, 8, '2008-07-21', '387.71', 'Por que lleva mas tiempo trabajando');
INSERT INTO bono VALUES (default, 9, '2008-12-21', '473.42', 'Por puntualidad');
INSERT INTO bono VALUES (default, 7, '2009-08-08', '378.33', 'Por prductividad');
INSERT INTO bono VALUES (default, 15, '2010-12-04', '726.23', 'Por ventas');
INSERT INTO bono VALUES (default, 15, '2011-10-27', '690.11', 'Por buen servicio');
INSERT INTO bono VALUES (default, 3, '2011-01-23', '531.55', 'Por menos quejas');
INSERT INTO bono VALUES (default, 4, '2013-05-20', '434.87', 'Por puntualidad');
INSERT INTO bono VALUES (default, 12, '2013-01-13', '440.22', 'Por productividad');
INSERT INTO bono VALUES (default, 1, '2013-06-22', '691.77', 'Por que lleva mas tiempo trabajando');
INSERT INTO bono VALUES (default, 13, '2016-07-08', '719.36', 'Por menos quejas');
INSERT INTO bono VALUES (default, 6, '2016-11-24', '523.68', 'Por ventas');

INSERT INTO reservacion VALUES (default, 6, 6, 5, '1', 1, '2017-09-14', '2017-10-14', '2017-10-15');
INSERT INTO reservacion VALUES (default, 8, 8, 7, '1', 2, '2018-01-05', '2018-01-09', '2018-01-12');
INSERT INTO reservacion VALUES (default, 14, 14, 14, '0', 3, '2018-02-26', '2018-02-27', '2018-02-28');
INSERT INTO reservacion VALUES (default, 15, 15, 15, '0', 1, '2018-05-16', '2018-05-18', '2018-05-19');	
INSERT INTO reservacion VALUES (default, 9, 9, 8, '1', 2, '2018-05-25', '2018-05-28', '2012-05-29');
INSERT INTO reservacion VALUES (default, 11, 11, 10, '1', 3, '2018-06-17', '2018-06-23', '2018-06-26');
INSERT INTO reservacion VALUES (default, 13, 13, 12, '0', 1, '2018-07-03', '2018-07-03', '2018-07-06');
INSERT INTO reservacion VALUES (default, 10, 10, 9, '1', 2, '2018-10-25', '2019-06-14', '2019-06-15');
INSERT INTO reservacion VALUES (default, 15, 15, 15, '0', 3, '2018-11-04', '2018-11-12', '2018-11-13');
INSERT INTO reservacion VALUES (default, 3, 3, 2, '0', 1, '2019-01-06', '2019-01-13', '2019-01-15');	
INSERT INTO reservacion VALUES (default, 12, 12, 11, '0', 2, '2019-02-22', '2019-02-26', '2019-02-27');
INSERT INTO reservacion VALUES (default, 4, 4, 3, '0', 3, '2019-03-01', '2019-03-01', '2019-03-02');
INSERT INTO reservacion VALUES (default, 2, 1, 1, '1', 1, '2019-03-12', '2019-03-13', '2019-03-16');
INSERT INTO reservacion VALUES (default, 7, 7, 6, '0', 2, '2019-04-24', '2019-05-27', '2019-05-29');
INSERT INTO reservacion VALUES (default, 5, 5, 4, '0', 3, '2019-11-10', '2019-11-24', '2019-11-25');

INSERT INTO factura VALUES (default, 1, 1, 2, '2016-08-14', '17046.40');
INSERT INTO factura VALUES (default, 4, 2, 4, '2004-02-03', '21214.90');
INSERT INTO factura VALUES (default, 5, 3, 5, '1971-07-08', '17960.43');
INSERT INTO factura VALUES (default, 12, 4, 12, '1990-12-09', '14783.75');
INSERT INTO factura VALUES (default, 15, 5, 15, '1984-03-04', '21827.21');
INSERT INTO factura VALUES (default, 10, 6, 10, '1991-05-01', '14466.21');
INSERT INTO factura VALUES (default, 11, 7, 11, '1970-06-07', '16986.55');
INSERT INTO factura VALUES (default, 15, 8, 15, '2018-06-10', '15842.72');
INSERT INTO factura VALUES (default, 3, 9, 3, '2006-11-12', '19764.14');
INSERT INTO factura VALUES (default, 9, 10, 9, '2001-07-26', '22184.09');
INSERT INTO factura VALUES (default, 6, 11, 6, '1992-09-30', '14017.31');
INSERT INTO factura VALUES (default, 7, 12, 7, '1986-09-21', '13845.98');
INSERT INTO factura VALUES (default, 13, 13, 13, '1979-03-17', '14141.68');
INSERT INTO factura VALUES (default, 14, 14, 14, '1980-08-04', '21105.21');
INSERT INTO factura VALUES (default, 8, 15, 8, '2001-05-01', '10829.20');

INSERT INTO cargo VALUES (default, 1, '2017-10-08', 1, NULL, NULL, '14386.07');
INSERT INTO cargo VALUES (default, 2, '2018-09-24', NULL, 2, NULL, '17335.27');
INSERT INTO cargo VALUES (default, 3, '2018-10-05', NULL, NULL, 3, '14705.26');
INSERT INTO cargo VALUES (default, 4, '2018-12-09', 4, NULL, NULL, '11044.99');
INSERT INTO cargo VALUES (default, 5, '2018-11-06', NULL, 5, NULL, '19537.31');
INSERT INTO cargo VALUES (default, 6, '2018-05-20', NULL, NULL, 6, '16118.69');
INSERT INTO cargo VALUES (default, 7, '2018-12-26', 2, NULL, NULL, '21998.88');
INSERT INTO cargo VALUES (default, 8, '2018-02-25', NULL, 8, NULL, '20717.41');
INSERT INTO cargo VALUES (default, 9, '2018-11-13', NULL, NULL, 3, '17631.32');
INSERT INTO cargo VALUES (default, 10, '2018-01-02', 5, NULL, NULL, '13402.39');
INSERT INTO cargo VALUES (default, 11, '2018-02-07', NULL, 11, NULL, '10011.53');
INSERT INTO cargo VALUES (default, 12, '2018-08-12', NULL, NULL, 6, '17477.59');
INSERT INTO cargo VALUES (default, 13, '2018-09-18', 3, NULL, NULL, '20333.18');
INSERT INTO cargo VALUES (default, 14, '2018-04-26', NULL, 14, NULL, '14349.03');
INSERT INTO cargo VALUES (default, 15, '2018-07-12', NULL, NULL, 3, '20081.06');


INSERT INTO huesped_acompanante VALUES (1, 'Macie Stehr', '1993-11-29', 'irving.torphy@yahoo.com');
INSERT INTO huesped_acompanante VALUES (2, 'Ivah Kertzmann', '1995-02-04', 'eichmann.evangeline@roberts.co');
INSERT INTO huesped_acompanante VALUES (3, 'Waino Jacobson', '2019-09-29', 'kassulke.sarai@gmail.com');
INSERT INTO huesped_acompanante VALUES (4, 'Chanel Mraz', '1989-02-03', 'conner@gmail.com');
INSERT INTO huesped_acompanante VALUES (5, 'Ethan Casper', '1989-03-10', 'adickens@robel.com');
INSERT INTO huesped_acompanante VALUES (6, 'Prof. Chelsie Franecki', '2013-04-19', 'wiza.hassie@lebsack.com');
INSERT INTO huesped_acompanante VALUES (7, 'Dan Roberts', '2012-02-21', 'janessa32@hotmail.com');
INSERT INTO huesped_acompanante VALUES (8, 'Toy Heidenreich I', '1991-07-21', 'angeline16@jerde.com');
INSERT INTO huesped_acompanante VALUES (9, 'Dedrick Runte', '1972-10-09', 'rick.runolfsdottir@yahoo.com');
INSERT INTO huesped_acompanante VALUES (10, 'Keshaun Koelpin MD', '1981-02-26', 'darron.koepp@gmail.com');
INSERT INTO huesped_acompanante VALUES (11, 'Cathryn Wiegand', '2018-05-13', 'daugherty.breanne@yahoo.com');
INSERT INTO huesped_acompanante VALUES (12, 'Bennett Hand II', '1971-07-12', 'newell.schuster@oreillyledner.');
INSERT INTO huesped_acompanante VALUES (13, 'Virgie Graham', '2011-11-18', 'bryon43@gmail.com');
INSERT INTO huesped_acompanante VALUES (14, 'Conor Hirthe', '1979-01-21', 'jaqueline.wuckert@gmail.com');
INSERT INTO huesped_acompanante VALUES (15, 'Miss Leta Heathcote', '2019-01-03', 'sydnee.mann@gmail.com');







