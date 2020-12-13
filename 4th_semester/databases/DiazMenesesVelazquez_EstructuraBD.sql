create database tallerestrellitafugaz;
use tallerestrellitafugaz;
alter database tallerestrellitafugaz charset=utf8;

create table cliente(id_cliente int(30) NOT NULL primary key,
				  nombre varchar(30) NOT NULL,
				  apellido_p varchar(30) NOT NULL,
				  apellido_m varchar(30) NOT NULL,
                  sexo varchar(2) NOT NULL,
				  direccion varchar(70) NOT NULL,
				  fecha_nac DATE NOT NULL,
				  telefono bigint(10) NOT NULL,
				  visitas int(30)
				  ) ENGINE=InnoDB;
                  
create table vehiculo(id_vehiculo int(30) NOT NULL primary key,
				  marca varchar(30) NOT NULL,
                  modelo varchar(30) NOT NULL,
                  anio int(5) NOT NULL,
                  color varchar(30) NULL,
                  fecha_registro DATE NOT NULL,
                  id_cliente int(30) NOT NULL,
                  FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
				  ) ENGINE=InnoDB;

create table diagnostico(id_diagnostico int(30) NOT NULL primary key,
				  costo numeric(12,2) NOT NULL,
                  presupuesto numeric(12,2) NOT NULL,
                  descr_fallas varchar(150) NULL,
                  id_vehiculo int(30) NOT NULL,
                  FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id_vehiculo)
				  ) ENGINE=InnoDB;
                                
create table supervisor(id_supervisor int(30) NOT NULL primary key,
				  nombre varchar(30) NOT NULL,
				  apellido_p varchar(30) NOT NULL,
				  apellido_m varchar(30) NOT NULL,
                  sexo varchar(2) NOT NULL,
				  direccion varchar(70) NOT NULL,
				  fecha_nac DATE NOT NULL,
                  telefono bigint(30) NOT NULL
				  ) ENGINE=InnoDB;

create table departamento(id_departamento int(30) NOT NULL primary key,
				  nombre_depart varchar(50) NOT NULL,
                  id_supervisor int(30) NOT NULL,
                  descripcion varchar(150) NOT NULL,
FOREIGN KEY (id_supervisor) REFERENCES supervisor(id_supervisor)
				  ) ENGINE=InnoDB;

create table mecanico(id_mecanico int(30) NOT NULL primary key,
				  nombre varchar(30) NOT NULL,
                  apellido_p varchar(30) NOT NULL,
                  apellido_m varchar(30) NOT NULL,
                  fecha_nac varchar(30) NOT NULL,
                  salarioxhora numeric(12,2) NOT NULL,
                  horas_trabaj int(30) NULL,
                  id_departamento int(30) NOT NULL,
FOREIGN KEY (id_departamento) REFERENCES departamento(id_departamento)
				  ) ENGINE=InnoDB;
                  
create table servicio(id_servicio int(30) NOT NULL primary key,
                  id_mecanicoResp int(30) NOT NULL,
                  id_departamento int(30) NOT NULL,
                  id_vehiculo int(30) NOT NULL,
                  falla_en_repa varchar(150) NULL,
                  fecha_ingreso DATE NOT NULL,
                  fecha_listo DATE NULL,
                  id_diagnostico int(30) NOT NULL,
FOREIGN KEY (id_diagnostico) REFERENCES diagnostico(id_diagnostico),
FOREIGN KEY (id_mecanicoResp) REFERENCES mecanico(id_mecanico),
FOREIGN KEY (id_vehiculo) references vehiculo(id_vehiculo),
FOREIGN KEY (id_departamento) references departamento(id_departamento) /*CAMBIO 27-05-2020*/
				  ) ENGINE=InnoDB;
                  
create table producto(id_producto int(30) NOT NULL primary key,
			  descrip varchar(120) NOT NULL,
			  precio numeric(12,2) NULL,
              marca varchar(50) NULL,
              modelo varchar(50) NULL,
              anio int(5) NULL,
              id_departamento int(30) NOT NULL,
FOREIGN KEY (id_departamento) REFERENCES departamento(id_departamento)
			  ) ENGINE=InnoDB;
              
create table pedido(id_pedido int(30) NOT NULL primary key,
			  id_producto int(30) NOT NULL,
			  id_servicio int(30) NOT NULL,
			  cantidad int(10) NOT NULL,
			  precio_total numeric(12,2) NULL,
FOREIGN KEY (id_servicio) REFERENCES servicio(id_servicio)
/*FOREIGN KEY (id_producto) REFERENCES producto(id_producto), Se pueden pedir productos nuevos */
			  ) ENGINE=InnoDB;
                            
create table bodega(id_producto int(30) NOT NULL, 
			  stock_actual int(30) NOT NULL,
			  stock_min int(30) NOT NULL,
              stock_max int(30) NULL,
              FOREIGN KEY (id_producto) REFERENCES producto(id_producto)
			  ) ENGINE=InnoDB;
              
create table proveedor(id_proveedor int(30) NOT NULL primary key,
			  nombre_proveedor varchar(40) NOT NULL,
			  direccion varchar(30) NOT NULL
			  ) ENGINE=InnoDB;
              
create table compra(id_compra int(30) NOT NULL primary key,
			  descripcion varchar(120) NOT NULL,
			  importe numeric(12,2) NOT NULL,
              metodopago varchar(40) NULL,
              cantidad int(10) NOT NULL,
              id_producto int(30) NULL,
              id_proveedor int(30) NULL,
FOREIGN KEY (id_producto) REFERENCES producto(id_producto),
FOREIGN KEY (id_proveedor) REFERENCES proveedor(id_proveedor)
			  ) ENGINE=InnoDB;

create table promocion(id_promocion int(30) NOT NULL primary key,
				  porcen_des numeric(3,2) NOT NULL,
                  fecha_inicio DATE NOT NULL,
				  fecha_final DATE NOT NULL,
                  tipopromo varchar(30)  NOT NULL
				  ) ENGINE=InnoDB;

create table venta(id_venta int(30) NOT NULL primary key,
                  id_servicio int(30) NOT NULL,
                  cantidadsindes numeric(12,2)  NOT NULL,
                  cantidad_final numeric(12,2) NOT NULL,
                  fecha_venta DATE NULL,
				  id_promocion int(30) NULL,
                  metodopago varchar(40) NULL,
FOREIGN KEY (id_servicio) REFERENCES servicio(id_servicio),
FOREIGN KEY (id_promocion) REFERENCES promocion(id_promocion)
				  ) ENGINE=InnoDB;
                                    
create table garantia(id_garantia int(30) NOT NULL primary key,
				  id_vehiculo int(30) NOT NULL,
                  id_venta int(30) NOT NULL,
                  cobertura numeric(12,2) NOT NULL,
                  fecha_inicio DATE NOT NULL,
                  fecha_final DATE NOT NULL,
                  aplicada int(2),
FOREIGN KEY (id_venta) REFERENCES venta(id_venta)
				  ) ENGINE=InnoDB;