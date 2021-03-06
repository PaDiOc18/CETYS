PGDMP                         x            hotelazo    13.0    13.0 �    ^           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            _           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            `           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            a           1262    19941    hotelazo    DATABASE     d   CREATE DATABASE hotelazo WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Spanish_Spain.1252';
    DROP DATABASE hotelazo;
                postgres    false            �            1255    20176    agregar_bono()    FUNCTION     u  CREATE FUNCTION public.agregar_bono() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
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
$$;
 %   DROP FUNCTION public.agregar_bono();
       public          postgres    false            �            1255    20174    evitar_modificacion_paquete()    FUNCTION       CREATE FUNCTION public.evitar_modificacion_paquete() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
  DECLARE
  BEGIN
   if OLD.id_paquete <> NEW.id_paquete THEN
   	RAISE unique_violation USING MESSAGE = 'CANNOT CHANGE PACKET ONCE REGISTERED';
	END if;
   RETURN NEW;
  END;
$$;
 4   DROP FUNCTION public.evitar_modificacion_paquete();
       public          postgres    false            �            1259    19988    queja    TABLE     �   CREATE TABLE public.queja (
    id_queja integer NOT NULL,
    id_huesped integer,
    id_departamento integer,
    fechainicio date,
    fechafin date,
    activa boolean,
    seguimiento character varying,
    razon character varying
);
    DROP TABLE public.queja;
       public         heap    postgres    false            �            1255    20184 )   get_active_quejas_per_department(integer)    FUNCTION     �   CREATE FUNCTION public.get_active_quejas_per_department(departamento integer) RETURNS SETOF public.queja
    LANGUAGE sql
    AS $$
select * from queja where id_departamento = departamento and activa = '1';
$$;
 M   DROP FUNCTION public.get_active_quejas_per_department(departamento integer);
       public          postgres    false    209            �            1259    20134    cargo    TABLE     �   CREATE TABLE public.cargo (
    id_cargo integer NOT NULL,
    id_factura integer,
    fecha date,
    id_paquete integer,
    id_servicio integer,
    id_categoria integer,
    total numeric(15,2)
);
    DROP TABLE public.cargo;
       public         heap    postgres    false            �            1255    20181 !   get_charges_from_factura(integer)    FUNCTION     �   CREATE FUNCTION public.get_charges_from_factura(idfactura integer) RETURNS SETOF public.cargo
    LANGUAGE sql
    AS $$
select * from cargo where id_factura = idfactura;
$$;
 B   DROP FUNCTION public.get_charges_from_factura(idfactura integer);
       public          postgres    false    225            �            1259    20017    empleado    TABLE     e  CREATE TABLE public.empleado (
    id_empleado integer NOT NULL,
    id_departamento integer,
    nombre character varying,
    edad integer,
    sexo character(1),
    telefono character varying,
    direccion character varying,
    correo_electronico character varying,
    fecha_nacimiento date,
    fecha_contratacion date,
    rfc character varying
);
    DROP TABLE public.empleado;
       public         heap    postgres    false            �            1255    20180 '   get_employee_by_name(character varying)    FUNCTION     �   CREATE FUNCTION public.get_employee_by_name(name character varying) RETURNS SETOF public.empleado
    LANGUAGE sql
    AS $$
select * from empleado where nombre = name;
$$;
 C   DROP FUNCTION public.get_employee_by_name(name character varying);
       public          postgres    false    213            �            1259    20088    reservacion    TABLE       CREATE TABLE public.reservacion (
    id_reservacion integer NOT NULL,
    id_huesped integer,
    id_empleado integer,
    id_habitacion integer,
    activo boolean,
    tipo_reservacion integer,
    fecha_reservacion date,
    fecha_inicio date,
    fecha_final date
);
    DROP TABLE public.reservacion;
       public         heap    postgres    false            �            1255    20182 $   get_reservations_between(date, date)    FUNCTION     �   CREATE FUNCTION public.get_reservations_between(fechainicio date, fechafinal date) RETURNS SETOF public.reservacion
    LANGUAGE sql
    AS $$
select * from reservacion where fecha_reservacion between fechaInicio and fechaFinal;
$$;
 R   DROP FUNCTION public.get_reservations_between(fechainicio date, fechafinal date);
       public          postgres    false    221            �            1259    20004 
   habitacion    TABLE     �   CREATE TABLE public.habitacion (
    id_habitacion integer NOT NULL,
    id_categoria integer,
    disponible boolean,
    capacidad integer
);
    DROP TABLE public.habitacion;
       public         heap    postgres    false            �            1255    20183    get_rooms_availables(integer)    FUNCTION     �   CREATE FUNCTION public.get_rooms_availables(categoria integer) RETURNS SETOF public.habitacion
    LANGUAGE sql
    AS $$
select * from habitacion where id_categoria = categoria and disponible = '1';
$$;
 >   DROP FUNCTION public.get_rooms_availables(categoria integer);
       public          postgres    false    211            �            1255    20178    package_updater()    FUNCTION     �   CREATE FUNCTION public.package_updater() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
  DECLARE
  BEGIN
   if new.id_departamento = 3 THEN
   	INSERT INTO promocion VALUES (default, 1,NEW.id_servicio,NULL);
	END if;
   RETURN NEW;
  END;
$$;
 (   DROP FUNCTION public.package_updater();
       public          postgres    false            �            1255    20172    verificar_fecha_cancelacion()    FUNCTION     G  CREATE FUNCTION public.verificar_fecha_cancelacion() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
  DECLARE
  BEGIN
   if OLD.activo = '1' and NEW.activo = '0' and OLD.fecha_final <= current_date THEN
   	RAISE unique_violation USING MESSAGE = 'COMPLETED RESERVATIONS CANNOT BE CANCELLED';
	END if;
   RETURN NEW;
  END;
$$;
 4   DROP FUNCTION public.verificar_fecha_cancelacion();
       public          postgres    false            �            1259    20072    bono    TABLE     �   CREATE TABLE public.bono (
    id_bono integer NOT NULL,
    id_empleado integer,
    fecha date,
    cantidad numeric(10,2),
    razon character varying
);
    DROP TABLE public.bono;
       public         heap    postgres    false            �            1259    20070    bono_id_bono_seq    SEQUENCE     �   CREATE SEQUENCE public.bono_id_bono_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.bono_id_bono_seq;
       public          postgres    false    219            b           0    0    bono_id_bono_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.bono_id_bono_seq OWNED BY public.bono.id_bono;
          public          postgres    false    218            �            1259    20132    cargo_id_cargo_seq    SEQUENCE     �   CREATE SEQUENCE public.cargo_id_cargo_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.cargo_id_cargo_seq;
       public          postgres    false    225            c           0    0    cargo_id_cargo_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.cargo_id_cargo_seq OWNED BY public.cargo.id_cargo;
          public          postgres    false    224            �            1259    19955    categoria_habitacion    TABLE     �   CREATE TABLE public.categoria_habitacion (
    id_categoria integer NOT NULL,
    nombre character varying,
    descripcion character varying,
    precio numeric
);
 (   DROP TABLE public.categoria_habitacion;
       public         heap    postgres    false            �            1259    19953 %   categoria_habitacion_id_categoria_seq    SEQUENCE     �   CREATE SEQUENCE public.categoria_habitacion_id_categoria_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 <   DROP SEQUENCE public.categoria_habitacion_id_categoria_seq;
       public          postgres    false    203            d           0    0 %   categoria_habitacion_id_categoria_seq    SEQUENCE OWNED BY     o   ALTER SEQUENCE public.categoria_habitacion_id_categoria_seq OWNED BY public.categoria_habitacion.id_categoria;
          public          postgres    false    202            �            1259    19966    departamento    TABLE     �   CREATE TABLE public.departamento (
    id_departamento integer NOT NULL,
    nombre character varying,
    descripcion character varying
);
     DROP TABLE public.departamento;
       public         heap    postgres    false            �            1259    19964     departamento_id_departamento_seq    SEQUENCE     �   CREATE SEQUENCE public.departamento_id_departamento_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.departamento_id_departamento_seq;
       public          postgres    false    205            e           0    0     departamento_id_departamento_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.departamento_id_departamento_seq OWNED BY public.departamento.id_departamento;
          public          postgres    false    204            �            1259    20015    empleado_id_empleado_seq    SEQUENCE     �   CREATE SEQUENCE public.empleado_id_empleado_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.empleado_id_empleado_seq;
       public          postgres    false    213            f           0    0    empleado_id_empleado_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.empleado_id_empleado_seq OWNED BY public.empleado.id_empleado;
          public          postgres    false    212            �            1259    20111    factura    TABLE     �   CREATE TABLE public.factura (
    id_factura integer NOT NULL,
    id_empleado integer,
    id_reservacion integer,
    id_huesped integer,
    fecha date,
    total numeric(15,2)
);
    DROP TABLE public.factura;
       public         heap    postgres    false            �            1259    20109    factura_id_factura_seq    SEQUENCE     �   CREATE SEQUENCE public.factura_id_factura_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.factura_id_factura_seq;
       public          postgres    false    223            g           0    0    factura_id_factura_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.factura_id_factura_seq OWNED BY public.factura.id_factura;
          public          postgres    false    222            �            1259    20002    habitacion_id_habitacion_seq    SEQUENCE     �   CREATE SEQUENCE public.habitacion_id_habitacion_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.habitacion_id_habitacion_seq;
       public          postgres    false    211            h           0    0    habitacion_id_habitacion_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.habitacion_id_habitacion_seq OWNED BY public.habitacion.id_habitacion;
          public          postgres    false    210            �            1259    20160    huesped_acompanante    TABLE     �   CREATE TABLE public.huesped_acompanante (
    id_reservacion integer,
    nombre character varying,
    fecha_nacimiento date,
    correo_electronico character varying
);
 '   DROP TABLE public.huesped_acompanante;
       public         heap    postgres    false            �            1259    19944    huesped_principal    TABLE     z  CREATE TABLE public.huesped_principal (
    id_huesped integer NOT NULL,
    nombre character varying,
    edad integer,
    direccion character varying,
    fecha_nacimiento date,
    sexo character(1),
    telefono character varying,
    telefono_cel character varying,
    correo_electronico character varying,
    rfc character varying,
    procedencia character varying
);
 %   DROP TABLE public.huesped_principal;
       public         heap    postgres    false            �            1259    19942     huesped_principal_id_huesped_seq    SEQUENCE     �   CREATE SEQUENCE public.huesped_principal_id_huesped_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.huesped_principal_id_huesped_seq;
       public          postgres    false    201            i           0    0     huesped_principal_id_huesped_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.huesped_principal_id_huesped_seq OWNED BY public.huesped_principal.id_huesped;
          public          postgres    false    200            �            1259    19977    paquete    TABLE     �   CREATE TABLE public.paquete (
    id_paquete integer NOT NULL,
    nombre character varying,
    descripcion character varying,
    fecha_inicio date,
    fecha_fin date,
    costo numeric(15,2)
);
    DROP TABLE public.paquete;
       public         heap    postgres    false            �            1259    19975    paquete_id_paquete_seq    SEQUENCE     �   CREATE SEQUENCE public.paquete_id_paquete_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.paquete_id_paquete_seq;
       public          postgres    false    207            j           0    0    paquete_id_paquete_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.paquete_id_paquete_seq OWNED BY public.paquete.id_paquete;
          public          postgres    false    206            �            1259    20049 	   promocion    TABLE     �   CREATE TABLE public.promocion (
    id_promocion integer NOT NULL,
    id_paquete integer,
    id_servicio integer,
    id_categoria integer
);
    DROP TABLE public.promocion;
       public         heap    postgres    false            �            1259    20047    promocion_id_promocion_seq    SEQUENCE     �   CREATE SEQUENCE public.promocion_id_promocion_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.promocion_id_promocion_seq;
       public          postgres    false    217            k           0    0    promocion_id_promocion_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.promocion_id_promocion_seq OWNED BY public.promocion.id_promocion;
          public          postgres    false    216            �            1259    19986    queja_id_queja_seq    SEQUENCE     �   CREATE SEQUENCE public.queja_id_queja_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.queja_id_queja_seq;
       public          postgres    false    209            l           0    0    queja_id_queja_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.queja_id_queja_seq OWNED BY public.queja.id_queja;
          public          postgres    false    208            �            1259    20086    reservacion_id_reservacion_seq    SEQUENCE     �   CREATE SEQUENCE public.reservacion_id_reservacion_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public.reservacion_id_reservacion_seq;
       public          postgres    false    221            m           0    0    reservacion_id_reservacion_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public.reservacion_id_reservacion_seq OWNED BY public.reservacion.id_reservacion;
          public          postgres    false    220            �            1259    20033    servicio    TABLE       CREATE TABLE public.servicio (
    id_servicio integer NOT NULL,
    id_departamento integer,
    externo boolean,
    nombre character varying,
    descripcion character varying,
    costo numeric(15,2),
    abre time without time zone,
    cierra time without time zone
);
    DROP TABLE public.servicio;
       public         heap    postgres    false            �            1259    20031    servicio_id_servicio_seq    SEQUENCE     �   CREATE SEQUENCE public.servicio_id_servicio_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.servicio_id_servicio_seq;
       public          postgres    false    215            n           0    0    servicio_id_servicio_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.servicio_id_servicio_seq OWNED BY public.servicio.id_servicio;
          public          postgres    false    214            �           2604    20075    bono id_bono    DEFAULT     l   ALTER TABLE ONLY public.bono ALTER COLUMN id_bono SET DEFAULT nextval('public.bono_id_bono_seq'::regclass);
 ;   ALTER TABLE public.bono ALTER COLUMN id_bono DROP DEFAULT;
       public          postgres    false    218    219    219            �           2604    20137    cargo id_cargo    DEFAULT     p   ALTER TABLE ONLY public.cargo ALTER COLUMN id_cargo SET DEFAULT nextval('public.cargo_id_cargo_seq'::regclass);
 =   ALTER TABLE public.cargo ALTER COLUMN id_cargo DROP DEFAULT;
       public          postgres    false    224    225    225            �           2604    19958 !   categoria_habitacion id_categoria    DEFAULT     �   ALTER TABLE ONLY public.categoria_habitacion ALTER COLUMN id_categoria SET DEFAULT nextval('public.categoria_habitacion_id_categoria_seq'::regclass);
 P   ALTER TABLE public.categoria_habitacion ALTER COLUMN id_categoria DROP DEFAULT;
       public          postgres    false    203    202    203            �           2604    19969    departamento id_departamento    DEFAULT     �   ALTER TABLE ONLY public.departamento ALTER COLUMN id_departamento SET DEFAULT nextval('public.departamento_id_departamento_seq'::regclass);
 K   ALTER TABLE public.departamento ALTER COLUMN id_departamento DROP DEFAULT;
       public          postgres    false    205    204    205            �           2604    20020    empleado id_empleado    DEFAULT     |   ALTER TABLE ONLY public.empleado ALTER COLUMN id_empleado SET DEFAULT nextval('public.empleado_id_empleado_seq'::regclass);
 C   ALTER TABLE public.empleado ALTER COLUMN id_empleado DROP DEFAULT;
       public          postgres    false    213    212    213            �           2604    20114    factura id_factura    DEFAULT     x   ALTER TABLE ONLY public.factura ALTER COLUMN id_factura SET DEFAULT nextval('public.factura_id_factura_seq'::regclass);
 A   ALTER TABLE public.factura ALTER COLUMN id_factura DROP DEFAULT;
       public          postgres    false    223    222    223            �           2604    20007    habitacion id_habitacion    DEFAULT     �   ALTER TABLE ONLY public.habitacion ALTER COLUMN id_habitacion SET DEFAULT nextval('public.habitacion_id_habitacion_seq'::regclass);
 G   ALTER TABLE public.habitacion ALTER COLUMN id_habitacion DROP DEFAULT;
       public          postgres    false    210    211    211            �           2604    19947    huesped_principal id_huesped    DEFAULT     �   ALTER TABLE ONLY public.huesped_principal ALTER COLUMN id_huesped SET DEFAULT nextval('public.huesped_principal_id_huesped_seq'::regclass);
 K   ALTER TABLE public.huesped_principal ALTER COLUMN id_huesped DROP DEFAULT;
       public          postgres    false    201    200    201            �           2604    19980    paquete id_paquete    DEFAULT     x   ALTER TABLE ONLY public.paquete ALTER COLUMN id_paquete SET DEFAULT nextval('public.paquete_id_paquete_seq'::regclass);
 A   ALTER TABLE public.paquete ALTER COLUMN id_paquete DROP DEFAULT;
       public          postgres    false    206    207    207            �           2604    20052    promocion id_promocion    DEFAULT     �   ALTER TABLE ONLY public.promocion ALTER COLUMN id_promocion SET DEFAULT nextval('public.promocion_id_promocion_seq'::regclass);
 E   ALTER TABLE public.promocion ALTER COLUMN id_promocion DROP DEFAULT;
       public          postgres    false    216    217    217            �           2604    19991    queja id_queja    DEFAULT     p   ALTER TABLE ONLY public.queja ALTER COLUMN id_queja SET DEFAULT nextval('public.queja_id_queja_seq'::regclass);
 =   ALTER TABLE public.queja ALTER COLUMN id_queja DROP DEFAULT;
       public          postgres    false    208    209    209            �           2604    20091    reservacion id_reservacion    DEFAULT     �   ALTER TABLE ONLY public.reservacion ALTER COLUMN id_reservacion SET DEFAULT nextval('public.reservacion_id_reservacion_seq'::regclass);
 I   ALTER TABLE public.reservacion ALTER COLUMN id_reservacion DROP DEFAULT;
       public          postgres    false    221    220    221            �           2604    20036    servicio id_servicio    DEFAULT     |   ALTER TABLE ONLY public.servicio ALTER COLUMN id_servicio SET DEFAULT nextval('public.servicio_id_servicio_seq'::regclass);
 C   ALTER TABLE public.servicio ALTER COLUMN id_servicio DROP DEFAULT;
       public          postgres    false    215    214    215            T          0    20072    bono 
   TABLE DATA           L   COPY public.bono (id_bono, id_empleado, fecha, cantidad, razon) FROM stdin;
    public          postgres    false    219   ��       Z          0    20134    cargo 
   TABLE DATA           j   COPY public.cargo (id_cargo, id_factura, fecha, id_paquete, id_servicio, id_categoria, total) FROM stdin;
    public          postgres    false    225   ��       D          0    19955    categoria_habitacion 
   TABLE DATA           Y   COPY public.categoria_habitacion (id_categoria, nombre, descripcion, precio) FROM stdin;
    public          postgres    false    203   �       F          0    19966    departamento 
   TABLE DATA           L   COPY public.departamento (id_departamento, nombre, descripcion) FROM stdin;
    public          postgres    false    205   ��       N          0    20017    empleado 
   TABLE DATA           �   COPY public.empleado (id_empleado, id_departamento, nombre, edad, sexo, telefono, direccion, correo_electronico, fecha_nacimiento, fecha_contratacion, rfc) FROM stdin;
    public          postgres    false    213   8�       X          0    20111    factura 
   TABLE DATA           d   COPY public.factura (id_factura, id_empleado, id_reservacion, id_huesped, fecha, total) FROM stdin;
    public          postgres    false    223   Z�       L          0    20004 
   habitacion 
   TABLE DATA           X   COPY public.habitacion (id_habitacion, id_categoria, disponible, capacidad) FROM stdin;
    public          postgres    false    211   R�       [          0    20160    huesped_acompanante 
   TABLE DATA           k   COPY public.huesped_acompanante (id_reservacion, nombre, fecha_nacimiento, correo_electronico) FROM stdin;
    public          postgres    false    226   ��       B          0    19944    huesped_principal 
   TABLE DATA           �   COPY public.huesped_principal (id_huesped, nombre, edad, direccion, fecha_nacimiento, sexo, telefono, telefono_cel, correo_electronico, rfc, procedencia) FROM stdin;
    public          postgres    false    201   ��       H          0    19977    paquete 
   TABLE DATA           b   COPY public.paquete (id_paquete, nombre, descripcion, fecha_inicio, fecha_fin, costo) FROM stdin;
    public          postgres    false    207   6�       R          0    20049 	   promocion 
   TABLE DATA           X   COPY public.promocion (id_promocion, id_paquete, id_servicio, id_categoria) FROM stdin;
    public          postgres    false    217   M�       J          0    19988    queja 
   TABLE DATA           y   COPY public.queja (id_queja, id_huesped, id_departamento, fechainicio, fechafin, activa, seguimiento, razon) FROM stdin;
    public          postgres    false    209   ��       V          0    20088    reservacion 
   TABLE DATA           �   COPY public.reservacion (id_reservacion, id_huesped, id_empleado, id_habitacion, activo, tipo_reservacion, fecha_reservacion, fecha_inicio, fecha_final) FROM stdin;
    public          postgres    false    221   f�       P          0    20033    servicio 
   TABLE DATA           s   COPY public.servicio (id_servicio, id_departamento, externo, nombre, descripcion, costo, abre, cierra) FROM stdin;
    public          postgres    false    215   p�       o           0    0    bono_id_bono_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.bono_id_bono_seq', 16, true);
          public          postgres    false    218            p           0    0    cargo_id_cargo_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.cargo_id_cargo_seq', 15, true);
          public          postgres    false    224            q           0    0 %   categoria_habitacion_id_categoria_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public.categoria_habitacion_id_categoria_seq', 6, true);
          public          postgres    false    202            r           0    0     departamento_id_departamento_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.departamento_id_departamento_seq', 5, true);
          public          postgres    false    204            s           0    0    empleado_id_empleado_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.empleado_id_empleado_seq', 15, true);
          public          postgres    false    212            t           0    0    factura_id_factura_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.factura_id_factura_seq', 15, true);
          public          postgres    false    222            u           0    0    habitacion_id_habitacion_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public.habitacion_id_habitacion_seq', 15, true);
          public          postgres    false    210            v           0    0     huesped_principal_id_huesped_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.huesped_principal_id_huesped_seq', 15, true);
          public          postgres    false    200            w           0    0    paquete_id_paquete_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.paquete_id_paquete_seq', 5, true);
          public          postgres    false    206            x           0    0    promocion_id_promocion_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.promocion_id_promocion_seq', 15, true);
          public          postgres    false    216            y           0    0    queja_id_queja_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.queja_id_queja_seq', 15, true);
          public          postgres    false    208            z           0    0    reservacion_id_reservacion_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public.reservacion_id_reservacion_seq', 16, true);
          public          postgres    false    220            {           0    0    servicio_id_servicio_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.servicio_id_servicio_seq', 16, true);
          public          postgres    false    214            �           2606    20080    bono bono_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.bono
    ADD CONSTRAINT bono_pkey PRIMARY KEY (id_bono);
 8   ALTER TABLE ONLY public.bono DROP CONSTRAINT bono_pkey;
       public            postgres    false    219            �           2606    20139    cargo cargo_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.cargo
    ADD CONSTRAINT cargo_pkey PRIMARY KEY (id_cargo);
 :   ALTER TABLE ONLY public.cargo DROP CONSTRAINT cargo_pkey;
       public            postgres    false    225            �           2606    19963 .   categoria_habitacion categoria_habitacion_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public.categoria_habitacion
    ADD CONSTRAINT categoria_habitacion_pkey PRIMARY KEY (id_categoria);
 X   ALTER TABLE ONLY public.categoria_habitacion DROP CONSTRAINT categoria_habitacion_pkey;
       public            postgres    false    203            �           2606    19974    departamento departamento_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.departamento
    ADD CONSTRAINT departamento_pkey PRIMARY KEY (id_departamento);
 H   ALTER TABLE ONLY public.departamento DROP CONSTRAINT departamento_pkey;
       public            postgres    false    205            �           2606    20025    empleado empleado_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleado_pkey PRIMARY KEY (id_empleado);
 @   ALTER TABLE ONLY public.empleado DROP CONSTRAINT empleado_pkey;
       public            postgres    false    213            �           2606    20116    factura factura_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.factura
    ADD CONSTRAINT factura_pkey PRIMARY KEY (id_factura);
 >   ALTER TABLE ONLY public.factura DROP CONSTRAINT factura_pkey;
       public            postgres    false    223            �           2606    20009    habitacion habitacion_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.habitacion
    ADD CONSTRAINT habitacion_pkey PRIMARY KEY (id_habitacion);
 D   ALTER TABLE ONLY public.habitacion DROP CONSTRAINT habitacion_pkey;
       public            postgres    false    211            �           2606    19952 (   huesped_principal huesped_principal_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public.huesped_principal
    ADD CONSTRAINT huesped_principal_pkey PRIMARY KEY (id_huesped);
 R   ALTER TABLE ONLY public.huesped_principal DROP CONSTRAINT huesped_principal_pkey;
       public            postgres    false    201            �           2606    19985    paquete paquete_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.paquete
    ADD CONSTRAINT paquete_pkey PRIMARY KEY (id_paquete);
 >   ALTER TABLE ONLY public.paquete DROP CONSTRAINT paquete_pkey;
       public            postgres    false    207            �           2606    20054    promocion promocion_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT promocion_pkey PRIMARY KEY (id_promocion);
 B   ALTER TABLE ONLY public.promocion DROP CONSTRAINT promocion_pkey;
       public            postgres    false    217            �           2606    19996    queja queja_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.queja
    ADD CONSTRAINT queja_pkey PRIMARY KEY (id_queja);
 :   ALTER TABLE ONLY public.queja DROP CONSTRAINT queja_pkey;
       public            postgres    false    209            �           2606    20093    reservacion reservacion_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT reservacion_pkey PRIMARY KEY (id_reservacion);
 F   ALTER TABLE ONLY public.reservacion DROP CONSTRAINT reservacion_pkey;
       public            postgres    false    221            �           2606    20041    servicio servicio_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.servicio
    ADD CONSTRAINT servicio_pkey PRIMARY KEY (id_servicio);
 @   ALTER TABLE ONLY public.servicio DROP CONSTRAINT servicio_pkey;
       public            postgres    false    215            �           2620    20177    reservacion agregar_bono    TRIGGER     t   CREATE TRIGGER agregar_bono AFTER INSERT ON public.reservacion FOR EACH ROW EXECUTE FUNCTION public.agregar_bono();
 1   DROP TRIGGER agregar_bono ON public.reservacion;
       public          postgres    false    229    221            �           2620    20175 !   cargo evitar_modificacion_paquete    TRIGGER     �   CREATE TRIGGER evitar_modificacion_paquete BEFORE UPDATE ON public.cargo FOR EACH ROW EXECUTE FUNCTION public.evitar_modificacion_paquete();
 :   DROP TRIGGER evitar_modificacion_paquete ON public.cargo;
       public          postgres    false    228    225            �           2620    20179    servicio package_updater    TRIGGER     w   CREATE TRIGGER package_updater AFTER INSERT ON public.servicio FOR EACH ROW EXECUTE FUNCTION public.package_updater();
 1   DROP TRIGGER package_updater ON public.servicio;
       public          postgres    false    230    215            �           2620    20173 '   reservacion verificar_fecha_cancelacion    TRIGGER     �   CREATE TRIGGER verificar_fecha_cancelacion BEFORE UPDATE ON public.reservacion FOR EACH ROW EXECUTE FUNCTION public.verificar_fecha_cancelacion();
 @   DROP TRIGGER verificar_fecha_cancelacion ON public.reservacion;
       public          postgres    false    227    221            �           2606    20081    bono bono_id_empleado_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.bono
    ADD CONSTRAINT bono_id_empleado_fkey FOREIGN KEY (id_empleado) REFERENCES public.empleado(id_empleado);
 D   ALTER TABLE ONLY public.bono DROP CONSTRAINT bono_id_empleado_fkey;
       public          postgres    false    219    213    2971            �           2606    20150    cargo cargo_id_categoria_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cargo
    ADD CONSTRAINT cargo_id_categoria_fkey FOREIGN KEY (id_categoria) REFERENCES public.categoria_habitacion(id_categoria);
 G   ALTER TABLE ONLY public.cargo DROP CONSTRAINT cargo_id_categoria_fkey;
       public          postgres    false    225    203    2961            �           2606    20140    cargo cargo_id_factura_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cargo
    ADD CONSTRAINT cargo_id_factura_fkey FOREIGN KEY (id_factura) REFERENCES public.factura(id_factura);
 E   ALTER TABLE ONLY public.cargo DROP CONSTRAINT cargo_id_factura_fkey;
       public          postgres    false    225    223    2981            �           2606    20155    cargo cargo_id_paquete_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cargo
    ADD CONSTRAINT cargo_id_paquete_fkey FOREIGN KEY (id_paquete) REFERENCES public.paquete(id_paquete);
 E   ALTER TABLE ONLY public.cargo DROP CONSTRAINT cargo_id_paquete_fkey;
       public          postgres    false    225    207    2965            �           2606    20145    cargo cargo_id_servicio_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cargo
    ADD CONSTRAINT cargo_id_servicio_fkey FOREIGN KEY (id_servicio) REFERENCES public.servicio(id_servicio);
 F   ALTER TABLE ONLY public.cargo DROP CONSTRAINT cargo_id_servicio_fkey;
       public          postgres    false    225    215    2973            �           2606    20026 &   empleado empleado_id_departamento_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleado_id_departamento_fkey FOREIGN KEY (id_departamento) REFERENCES public.departamento(id_departamento);
 P   ALTER TABLE ONLY public.empleado DROP CONSTRAINT empleado_id_departamento_fkey;
       public          postgres    false    2963    205    213            �           2606    20127     factura factura_id_empleado_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.factura
    ADD CONSTRAINT factura_id_empleado_fkey FOREIGN KEY (id_empleado) REFERENCES public.empleado(id_empleado);
 J   ALTER TABLE ONLY public.factura DROP CONSTRAINT factura_id_empleado_fkey;
       public          postgres    false    223    213    2971            �           2606    20122    factura factura_id_huesped_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.factura
    ADD CONSTRAINT factura_id_huesped_fkey FOREIGN KEY (id_huesped) REFERENCES public.huesped_principal(id_huesped);
 I   ALTER TABLE ONLY public.factura DROP CONSTRAINT factura_id_huesped_fkey;
       public          postgres    false    223    201    2959            �           2606    20117 #   factura factura_id_reservacion_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.factura
    ADD CONSTRAINT factura_id_reservacion_fkey FOREIGN KEY (id_reservacion) REFERENCES public.reservacion(id_reservacion);
 M   ALTER TABLE ONLY public.factura DROP CONSTRAINT factura_id_reservacion_fkey;
       public          postgres    false    223    221    2979            �           2606    20010 '   habitacion habitacion_id_categoria_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.habitacion
    ADD CONSTRAINT habitacion_id_categoria_fkey FOREIGN KEY (id_categoria) REFERENCES public.categoria_habitacion(id_categoria);
 Q   ALTER TABLE ONLY public.habitacion DROP CONSTRAINT habitacion_id_categoria_fkey;
       public          postgres    false    211    203    2961            �           2606    20166 ;   huesped_acompanante huesped_acompanante_id_reservacion_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.huesped_acompanante
    ADD CONSTRAINT huesped_acompanante_id_reservacion_fkey FOREIGN KEY (id_reservacion) REFERENCES public.reservacion(id_reservacion);
 e   ALTER TABLE ONLY public.huesped_acompanante DROP CONSTRAINT huesped_acompanante_id_reservacion_fkey;
       public          postgres    false    226    221    2979            �           2606    20060 %   promocion promocion_id_categoria_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT promocion_id_categoria_fkey FOREIGN KEY (id_categoria) REFERENCES public.categoria_habitacion(id_categoria);
 O   ALTER TABLE ONLY public.promocion DROP CONSTRAINT promocion_id_categoria_fkey;
       public          postgres    false    203    217    2961            �           2606    20065 #   promocion promocion_id_paquete_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT promocion_id_paquete_fkey FOREIGN KEY (id_paquete) REFERENCES public.paquete(id_paquete);
 M   ALTER TABLE ONLY public.promocion DROP CONSTRAINT promocion_id_paquete_fkey;
       public          postgres    false    207    217    2965            �           2606    20055 $   promocion promocion_id_servicio_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT promocion_id_servicio_fkey FOREIGN KEY (id_servicio) REFERENCES public.servicio(id_servicio);
 N   ALTER TABLE ONLY public.promocion DROP CONSTRAINT promocion_id_servicio_fkey;
       public          postgres    false    2973    217    215            �           2606    19997    queja queja_id_huesped_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.queja
    ADD CONSTRAINT queja_id_huesped_fkey FOREIGN KEY (id_huesped) REFERENCES public.huesped_principal(id_huesped);
 E   ALTER TABLE ONLY public.queja DROP CONSTRAINT queja_id_huesped_fkey;
       public          postgres    false    2959    201    209            �           2606    20099 (   reservacion reservacion_id_empleado_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT reservacion_id_empleado_fkey FOREIGN KEY (id_empleado) REFERENCES public.empleado(id_empleado);
 R   ALTER TABLE ONLY public.reservacion DROP CONSTRAINT reservacion_id_empleado_fkey;
       public          postgres    false    221    213    2971            �           2606    20104 *   reservacion reservacion_id_habitacion_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT reservacion_id_habitacion_fkey FOREIGN KEY (id_habitacion) REFERENCES public.habitacion(id_habitacion);
 T   ALTER TABLE ONLY public.reservacion DROP CONSTRAINT reservacion_id_habitacion_fkey;
       public          postgres    false    211    2969    221            �           2606    20094 '   reservacion reservacion_id_huesped_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT reservacion_id_huesped_fkey FOREIGN KEY (id_huesped) REFERENCES public.huesped_principal(id_huesped);
 Q   ALTER TABLE ONLY public.reservacion DROP CONSTRAINT reservacion_id_huesped_fkey;
       public          postgres    false    221    201    2959            �           2606    20042 &   servicio servicio_id_departamento_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.servicio
    ADD CONSTRAINT servicio_id_departamento_fkey FOREIGN KEY (id_departamento) REFERENCES public.departamento(id_departamento);
 P   ALTER TABLE ONLY public.servicio DROP CONSTRAINT servicio_id_departamento_fkey;
       public          postgres    false    2963    215    205                       826    20186    DEFAULT PRIVILEGES FOR TABLES    DEFAULT ACL     &  ALTER DEFAULT PRIVILEGES FOR ROLE postgres GRANT SELECT ON TABLES  TO user_selecter;
ALTER DEFAULT PRIVILEGES FOR ROLE postgres GRANT INSERT,UPDATE ON TABLES  TO user_insert;
ALTER DEFAULT PRIVILEGES FOR ROLE postgres GRANT SELECT,INSERT,UPDATE ON TABLES  TO user_privileges WITH GRANT OPTION;
                   postgres    false            T   `  x���Kn�0D��)t	"��o�t��B� �Sr�Ҳ�h����� ��6i$M<�	>�I=ʰ�!�;�!�����j.ӣ?�cÀx�N���i�	f5�e�m{ebh�=F�f��d�~�@㬾�r	�#N�D�� �z-��nyVK_n�Q-S>�K��	���Cp���:y_�e5]�q��j1�dxW~�����%�-
��6�"R0įY��Z �Zk߄%�y-j����\���A��k��ؙ�@9;'w38gF��Ń��Z�Т��_YJQ���;HN[��ha��9�$�J�9a��I�}k��0��~����H[��jO���U���i��D���      Z   �   x�E���� ��.%@�%���s\��ML��� �)�^Z����«�&��u�,��ӽ�%;���|;�>�S'��۔�x��27j��Ҿ��h���N�����LwBJ��|����VH�QR�Eu�'�ҵ�&R<h���/v��1��fB��#<�����y��_U@�3��q%�jddJ�"���E��b��b�\���~��V1D�M#�mj~6KW������Y      D   �   x�e���0������#x��*G/lhZC[�oo5��0�ɗݩEu�F8S���hlC�4�CG	M3�?I��BZ�B=���?�ep��m���B��C%�Z26���:���pe��0�Yp{�h�k��df\%k|�+iM����� ���}E�|I      F   �   x�u��
B1F��)�� ".��R� �6���>���-p������L�npx���Pև%��IŚT���Y-�UJ�j�k�we�>�ٳƀ[�h�T>�(-wp���#S��p�l�������B�/��L<      N     x�]�Yo�8���_����˛ӤM;mڠ): /�D[�:��ȿ~�<��)`�-��=�"��:79�-�����4����93$��d��_���w)��������u�[���$Z�έ�&���}�C��ֈZ�sBs�#��.	Z���9�DIl2��I���ޏ5�M���X �`V^*6?'2VK�ѧ��=��;4��0_�~=��p5�֥��:�BY����(c7��,9��8��qK��w�8��O~p�����1�&�'E�f	|���7���S$��w�FW���h�'�,�q���u;�g#g&_ɲ�JC���4!0�[���_���!��R�IzD"Ÿ��]����C?l��V��/W��P�I���U���s��^X�վ�$�q]�y#�oS5ᛛ$H�/����}�( 8��:n���8��iQڥ+�¥6�E��?�h6���s�n{�)M��|Xe
H�r��=�x���'$HrA,�TR�Hq�J[d��W�v+�=�|�W����$�u��Vi��v5��c0��������׊):��F�*���~�ʺՈ�M�0y�/�����H��]L�(D&�V@�^��j�F<��v��a�>c�"'"g��Z�ȕ���M���]
�1���M]Є�l)Ʌ�⠵Q('n,���o����� ���^L���� �ӓK���T�U:��B0�2�$�wm��ׄ~�-�cK��3D(��-����n��e��-�<%����%�ɧW":s���We����a�@yj�/10hѶH>��TN�KrȬ����0�q	\�߆�s}��v�Q9��\��k�b�\.�\�Ш�"D��4��N@�ͧmF霙P��l`ψ�٧��Kwn-1���$��!�u���O7�6���"���f�O� 1m��*�Ҝ���s��C�Pa�e�>�}�>u���-��e�ϩ1B_Z�s5v Rj�'�5,����W���D����b��X/�.����m[h���갓:P,|�e�O�Z�	��r����Nuu�z�g8t��)���#���9���9Æ��И�zz�U8q^�ĲS��s�*������SȨ��ܻm�~g��"o�����|\
i!Ό(�?�.M=�����(�ro�O4�0���]��	��*��)�ܬ�3�z�VRA-qU��'�^�S��p��eUu�׹K4�~զ�F������p�f;�!	�߳&F0 {���z��|���K���K^�,�'FSJ��Ȳ�_�l?�      X   �   x�EQ[�E!���H(��^f���G�&'��r �		�^)8���5$�{��S��v����`�!���n9��F@��ق<5�,%g�tQw�T��< ��k8f�}�G y��>��������uE0M��Y�a'���Ӱ��읝�T�ky���[��Ҽ��|������86��9���ݠ�Y��K1����|�<����n����_7�o��q�هW��뗩�7N�J=      L   P   x�-���0Cki�q�]�3�Ƹ���#J=�J?����:g��f���_���E	�K����N�_�� E{      [   �  x�MR͎�0>���Ċ�e!7Th�[�Tm�!��^�M�(<}ǡ�r���o��AkQ~OhH覩����.�T
t6�j �j�iV���EJ�x�1󢬊�A�mM�)��?��W��;��+X�h�>/�R7E�d�#�ػ#�vu8�u#߃X�����d�f$�E�G�l���īr��w��:���Q�}�Q|���ڠ���1I{�YS�^
݈���2,����>B{��a�������J�w�#F���	鿮�����CO9"��C�E�ȠI���;R�#��U˗�'��E�N8,���z�[�BJ�&���-F��ۀ�l��mrz��(: 
^�ϓ�kH�/_-�w�ײ(煮��Ԟ���)c%> �R�O����b4�O�蜊��c������Ԍ��i���&0pʤ:�^�=�?�S�|��O��C��=�������\5�)l.v6F�pl����t>�8�T�t'�_j6��S�S      B   m  x�U�KS�8���Wh	5إ�c�f�yT�kz�%��#�l'�~���٤*J�>:�;�Rt�k|�v����獋�	�#�z�p���������[������G�ZUYQ����V�*�8ѵ��֔X��q9[m\��eڠn5�p¤4�i�w��'݄�q��-��:��%bE4~H_�8�܃���kZ���9��P؊Ҋ*�1�j�Tm�T�jč�����\N�[���������YK���W�1+������pt݅��웃"N�0��&����~p���1�'�
�]�"c+�>YR+B�
*�cQi�+�4�#m\޹�������o��� �m��c���D�/�����0t	��R�.�6�٪�-�1���P�EI�H�V����������Р�H��3�P�6��9�|��\��A�~ؿP�('�5�kIt�:��\�q����	�L9�:����mBw���tQ�ޣ�$;�gVc\!-H����|2RK���\�اXg��"���׋�G��[�FREEv�!�=Q�)���|7�=%�!��"o�!����i����+6�"�p�P��0��f� �+Xb�D���&�����ѝ�g&!��-���ht�|����Z� ��|ܥ�����>�R�Ҽ�)�8�8B��f��Lr� >!(�R�L�Zi@`����»��m�^\���Ҧ9�eЭϩ���y��YE���!@�l�Ci�|���k�� ��-"��֌��!'{��e�`�>\�e�W�E־��z��y�����ݱb��j���䴍��j�G��/�\�x��� ����Pc.u�KW�A���Jc!+�8��*A8���~h���I��l��c{�A�4�������O��²-�W�R). �_�[�� 8|;v����֢M�Z2S�
�R�΀��Pm�XB/n�E����f�?hi�4)b���G�(Ԥ��#�h�\��A� E����{W�K�cf[���l.�Cf�X��F���Q0$j���&h���7�y��׸J��(n��8�)C�02��f��˂�P����o�˾X�
� R��)Q}�r����M`�Aה�)lL�2�K����u�]���n����	m������o#��o�5;$�����l�4��u�#:Ƙ�-~L1�s�;�vV@G�֘3�de����n��+K����w�Zi�)߭?F�1��/�4�[d�����۔=��.-�c��]j�V - �hX_�Ԁ2�@W���,�.t��Of��o�Y������ �mj���]J�������������w�~r`�� 0��qQ�<��UR�H+�l�&
�l�X���i�q-���yq�W�듓��[       H     x�e��N�0E��W����6-]�$H�5��3��q�������{=i�_���:y��%����� �&'��+n�@��5�fxN?e*Sk�[�Y�Y��J%J�YP�X/��v�
t�-h�u��l�-�����˘�#v����� uh��
)qՃ��������z�f�բc�˧���er�7QK�����.v��|X��ё/[���!2pbz8��c}�7,�s�7��<74S��8�_�8�/ˏ      R   U   x�=���0��=LUH�%:A����H�CFP���
w��`O�b��=1*���Q��od��3��䔧V��~��H���]      J   �  x��SKn�0]O�( )ɲ�E�J� ]t��Hbb4�R���h��bJ1�P��g�o�}Fd%(!w�(u�U!jx�/�u6������d<�5�0�: S �J��7��q=�Az�_������ To�2C��~����it=Mc�����8�͚|k��D�a�V���֦P��+�wN��[s8����z��������tm-��$��Yr�¿0���Ϩ{����)
�����}�ﴍ�A�\ʜ^�ͧ�[<��Ȩ��Y�T��2TrŽ�����{l͈�������fR�nҡH>-\Wq���!a��zK'XS3�$-PU%M��pt�2���9�[�o�
|�'j�̤���� ݀�d������9x:�L��������S�����F;�����1dW����(]      V   �   x���A�!E�r;��z�Y�	�����b'���������!4�����#�9}�����h�Qn1qL���P���;�u"Q̱:6B��|?bp��ͱ9v����Q�q6��N�g&�o1���Q�g�%��h��ddw9���痊�R�w]���,��09��-�O�� gG����d\�u�/4�Jh-��Š�1�+
��A�73�,�>���xEإ�D�n�z}�'2���a@:�/Ģ���+�~^D�t�~�      P   �  x��TKn�@]�O��H����&
-�6YvCK�3�hF�O��N]��X�_b�(��h��|�b)��U7�*����*��X�����<T����ΑG@�7�UK���$"�2�R��R�{c��\���j�l��"C�(�i�B���1�\��"c�k�����]T��:����J1�5����j,����H6J��&82<��!�A�u�~��{޶�N����8{Ml���M����Qב���p��s+�!��pI5��u�ɹ6N:Q�o��E/�b�px�#w{D�լ��,/�dR�E��e�4|EI�8O6�����Ĥ]�hLfy(#�+O�Jn�){�nF�i*R��o�nQl��at�]��q�1.�.�ʡ�whG<�o�L̭�C�M�)f�O�[<�'rm;����o����i��g@�{��C�]W6�ܖ������\k����W(_����0*?�(�H��۵�1     