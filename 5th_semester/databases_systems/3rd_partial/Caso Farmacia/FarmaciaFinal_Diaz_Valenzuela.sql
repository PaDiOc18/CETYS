CREATE DATABASE  IF NOT EXISTS `farmacia3` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `farmacia3`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: farmacia3
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bill`
--

DROP TABLE IF EXISTS `bill`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bill` (
  `id_bill` int NOT NULL,
  `id_employee` int DEFAULT NULL,
  `id_client` int DEFAULT NULL,
  `date_purchase` datetime DEFAULT NULL,
  `total_cost` double DEFAULT NULL,
  `id_district` int DEFAULT NULL,
  PRIMARY KEY (`id_bill`),
  KEY `id_employee` (`id_employee`),
  KEY `id_client` (`id_client`),
  KEY `fk_iddis` (`id_district`),
  CONSTRAINT `bill_ibfk_1` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id_employee`),
  CONSTRAINT `bill_ibfk_2` FOREIGN KEY (`id_client`) REFERENCES `clientt` (`id_client`),
  CONSTRAINT `fk_iddis` FOREIGN KEY (`id_district`) REFERENCES `district` (`id_district`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bill`
--

LOCK TABLES `bill` WRITE;
/*!40000 ALTER TABLE `bill` DISABLE KEYS */;
INSERT INTO `bill` VALUES (1,4,1,'2020-02-20 00:00:00',250,1),(2,6,7,'2020-05-16 00:00:00',190,2),(3,7,2,'2020-01-10 00:00:00',510,3),(4,10,6,'2020-03-04 00:00:00',620,4),(5,6,3,'2020-01-03 00:00:00',180,5),(6,9,5,'2020-04-12 00:00:00',140,5),(7,12,4,'2020-02-13 00:00:00',90,4),(8,10,8,'2020-05-22 00:00:00',190,2),(9,9,9,'2020-07-19 00:00:00',610,3),(10,12,10,'2020-06-13 00:00:00',300,2);
/*!40000 ALTER TABLE `bill` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `billproducts`
--

DROP TABLE IF EXISTS `billproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `billproducts` (
  `id_product` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `id_prescription` int DEFAULT NULL,
  `id_bill` int DEFAULT NULL,
  KEY `id_bill` (`id_bill`),
  KEY `id_product` (`id_product`),
  KEY `id_prescription` (`id_prescription`),
  CONSTRAINT `billproducts_ibfk_1` FOREIGN KEY (`id_bill`) REFERENCES `bill` (`id_bill`),
  CONSTRAINT `billproducts_ibfk_2` FOREIGN KEY (`id_product`) REFERENCES `product` (`id_product`),
  CONSTRAINT `billproducts_ibfk_3` FOREIGN KEY (`id_prescription`) REFERENCES `prescription` (`id_pres`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `billproducts`
--

LOCK TABLES `billproducts` WRITE;
/*!40000 ALTER TABLE `billproducts` DISABLE KEYS */;
INSERT INTO `billproducts` VALUES (4,4,1,1),(3,1,5,2),(7,2,7,3),(5,5,5,4),(3,7,3,5),(2,4,3,6),(8,3,6,7),(5,5,7,8),(3,7,5,9),(2,8,3,10),(1,2,3,1),(2,5,2,3),(3,1,1,3),(5,2,4,3),(4,4,5,4),(11,3,2,2),(12,1,5,5),(13,2,1,6),(14,1,3,1),(13,6,8,7);
/*!40000 ALTER TABLE `billproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `id_category` int NOT NULL,
  `name_category` varchar(30) DEFAULT NULL,
  `presc_req` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_category`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Hepatico',0),(2,'Analgesicos',0),(3,'Hepatico',0),(4,'Antialergicos',0),(5,'Antidiarreicos',0),(6,'Antiulcerosos',0),(7,'Antiinflamatorios',0),(8,'Antipireticos',0),(9,'Laxante',0),(10,'Antisecrecion',0),(11,'Antibiotico',1);
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientt`
--

DROP TABLE IF EXISTS `clientt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientt` (
  `id_client` int NOT NULL,
  `name_client` varchar(20) DEFAULT NULL,
  `lastname1_client` varchar(20) DEFAULT NULL,
  `lastname2_client` varchar(20) DEFAULT NULL,
  `birthdate_client` date DEFAULT NULL,
  `email_client` varchar(50) DEFAULT NULL,
  `phone_number` varchar(11) DEFAULT NULL,
  `RFC` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`id_client`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientt`
--

LOCK TABLES `clientt` WRITE;
/*!40000 ALTER TABLE `clientt` DISABLE KEYS */;
INSERT INTO `clientt` VALUES (1,'Roberto','Barrientos','Domingo','1999-01-02','roberto1@gmail.com','6641675298','12345'),(2,'Benjamin','Moron','Remiro','2000-02-02','ben2@gmail.com','6647532587','54322'),(3,'Paula','Becerra','Monte','2002-03-02','paula3@gmail.com','6641235974','23451'),(4,'Leonardo','Ruiz','Morana','2001-04-02','leo4@gmail.com','6641289745','15432'),(5,'Gonzalo','Carpio','Llamas','1998-05-11','gonzalo5@gmail.com','6641297631','34512'),(6,'Cesar','Herreras','Campos','1992-06-09','cesar6@gmail.com','6642871445','21543'),(7,'Valeria','Calvillo','Vega','1978-07-10','valeria7@gmail.com','6641194882','45123'),(8,'Vladimir','Ocampo','Vazquez','1986-08-08','vladimir8@gmail.com','6646558741','32154'),(9,'Lucas','Fontevilla','Maseda','1956-09-10','lucas9@gmail.com','6645741944','51234'),(10,'Facundo','Cañedo','Higuera','2003-10-04','facundo10@gmail.com','6643558655','43215'),(11,'Celestino','Uriarte','Iglesias','2004-11-03','celes11@gmail.com','6647995451','67890'),(12,'Carlos','Corvera','Piñeira','1979-05-04','carlos12@gmail.com','6649951123','98765'),(13,'Silvia','Trinidad','Serdio','1974-09-04','silvia13@gmail.com','6642582599','78965'),(14,'Jazmin','Gamez','Palmadas','1981-05-12','jazmin14@gmail.com','6649753477','98765'),(15,'Teodoro','Ramon','Villalba','1942-04-02','teodoro15@gmail.com','6649992547','78865');
/*!40000 ALTER TABLE `clientt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discount`
--

DROP TABLE IF EXISTS `discount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discount` (
  `id_discount` int NOT NULL,
  `start_date` date DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  `id_product` int DEFAULT NULL,
  `discount_amount` double DEFAULT NULL,
  PRIMARY KEY (`id_discount`),
  KEY `id_product` (`id_product`),
  CONSTRAINT `discount_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `product` (`id_product`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount`
--

LOCK TABLES `discount` WRITE;
/*!40000 ALTER TABLE `discount` DISABLE KEYS */;
INSERT INTO `discount` VALUES (1,'2020-02-13','2020-02-13',1,0.3),(2,'2020-01-19','2020-02-19',2,0.2),(3,'2020-03-09','2020-03-15',3,0.1),(4,'2020-04-07','2020-04-13',4,0.5),(5,'2020-05-27','2020-05-31',5,0.4),(6,'2020-06-23','2020-06-30',6,0.36),(7,'2020-07-16','2020-07-25',7,0.39),(8,'2020-02-23','2020-02-28',8,0.64),(9,'2020-03-16','2020-03-23',9,0.21),(10,'2020-04-15','2020-04-20',10,0.45),(11,'2020-05-14','2020-05-19',11,0.54),(12,'2020-06-13','2020-06-18',12,0.81),(13,'2020-07-06','2020-07-21',13,0.43),(14,'2020-03-14','2020-03-21',14,0.54),(15,'2020-03-13','2020-03-27',15,0.91);
/*!40000 ALTER TABLE `discount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `district`
--

DROP TABLE IF EXISTS `district`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `district` (
  `id_district` int NOT NULL,
  `name_distr` varchar(30) DEFAULT NULL,
  `adress` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_district`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `district`
--

LOCK TABLES `district` WRITE;
/*!40000 ALTER TABLE `district` DISABLE KEYS */;
INSERT INTO `district` VALUES (1,'Sucursal Tijuana','Blvd. Cucapah #22447, Villafontana, Fraccionamiento Villafontana, 22204 Tijuana, B.C.'),(2,'Sucursal Mexicali','Calle Juárez 92, Primera, 21100 Mexicali, B.C.'),(3,'Sucursal Tecate','Av. Nuevo León, Dr. Arturo Guerra y, Loma Alta, 21480 Tecate, B.C.'),(4,'Sucursal Rosarito','Sucursal Rosarito\',\'Blvd. Benito Juárez 907, Centro Playas, Local 16 Rosarito, B.C.'),(5,'Sucursal Ensenada','Av. Ruiz 700, Zona Centro, 22800 Ensenada, B.C.');
/*!40000 ALTER TABLE `district` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `id_employee` int NOT NULL,
  `name_employee` varchar(30) DEFAULT NULL,
  `lastname1_employee` varchar(30) DEFAULT NULL,
  `lastname2_employee` varchar(30) DEFAULT NULL,
  `phone_number` varchar(11) DEFAULT NULL,
  `birthdate_employee` date DEFAULT NULL,
  `salary_employee` double DEFAULT NULL,
  `position_employee` varchar(30) DEFAULT NULL,
  `id_district` int DEFAULT NULL,
  PRIMARY KEY (`id_employee`),
  KEY `fk_iddiss` (`id_district`),
  CONSTRAINT `fk_iddiss` FOREIGN KEY (`id_district`) REFERENCES `district` (`id_district`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Farid','Galdamez','Ayala','6641850276','1991-10-10',7500,'Limpieza',2),(2,'Melania','Iñigo','Perero','6647492659','1995-01-12',7500,'Limpieza',3),(3,'Renato','Valverde','Valles','6649265609','1943-05-04',12000,'Doctor',1),(4,'Cristela','Reyes','Torrado','6644398651','1952-04-02',9000,'Cajero',5),(5,'Aracely','Pachon','Cercalde','6641097572','1978-02-01',12000,'Doctor',3),(6,'David','Lobregon','Moldes','6641956205','1965-09-10',9000,'Cajero',2),(7,'Octavio','Sousa','Turres','6647090672','1992-09-08',9000,'Cajero',2),(8,'Alexander','Caceo','Sevillano','6649286212','1987-01-10',7500,'Limpieza',1),(9,'Leonardo','Gallo','Castillo','6648976920','1998-10-03',9000,'Cajero',2),(10,'Victor','Hidalgo','Bermudo','6648475027','1989-11-12',9000,'Cajero',3),(11,'Zulma','Greña','Llano','6648926576','1994-03-04',7500,'Limpieza',5),(12,'Luciana','Olivera','Vivanco','6647405766','1995-05-10',9000,'Cajero',3),(13,'Petri','Regato','Vargas','6648567202','1986-09-01',12000,'Doctor',1),(14,'Carlo','Nalda','Tapia','6640271650','1965-01-21',7500,'Limpieza',3),(15,'Sergio','Pedro','Verganzo','6640173045','1993-10-12',12000,'Doctor',2);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory` (
  `id_inventory` int NOT NULL,
  `id_district` int DEFAULT NULL,
  `id_product` int DEFAULT NULL,
  `current_stock` int DEFAULT NULL,
  `min_stock` int DEFAULT NULL,
  `max_stock` int DEFAULT NULL,
  PRIMARY KEY (`id_inventory`),
  KEY `id_product` (`id_product`),
  KEY `id_district` (`id_district`),
  CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `product` (`id_product`),
  CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`id_district`) REFERENCES `district` (`id_district`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,1,1,50,10,100),(2,2,2,45,10,100),(3,3,3,30,10,100),(4,4,4,25,10,100),(5,5,5,32,10,100),(6,1,6,45,10,100),(7,2,7,67,10,100),(8,3,8,23,10,100),(9,4,9,42,10,100),(10,5,10,37,10,100),(11,1,11,41,10,100),(12,2,12,50,10,100),(13,3,13,29,10,100),(14,4,14,31,10,100),(15,5,15,34,10,100);
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescription`
--

DROP TABLE IF EXISTS `prescription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prescription` (
  `id_pres` int NOT NULL,
  `id_card` int DEFAULT NULL,
  `date_` date DEFAULT NULL,
  `doctor_name` varchar(30) DEFAULT NULL,
  `doctor_lastname1` varchar(30) DEFAULT NULL,
  `doctor_lastname2` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_pres`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescription`
--

LOCK TABLES `prescription` WRITE;
/*!40000 ALTER TABLE `prescription` DISABLE KEYS */;
INSERT INTO `prescription` VALUES (1,456964,'2020-02-13','Panfilo','Poncedo','Garcia'),(2,633790,'2020-01-19','Alejandro','Hernandez','Sanchez'),(3,357892,'2020-03-09','Alexander','Carvajal','Vargas'),(4,87633,'2020-04-07','Camilo','Cruz','Garcia'),(5,656894,'2020-05-27','Daniel','Polanco','Ruiz'),(6,268933,'2020-06-23','Carolina','Gomez','Rodriguez'),(7,893371,'2020-07-16','Daniel','Torres','Frias'),(8,143246,'2020-02-23','Daniela','Quesada','Calderin'),(9,235775,'2020-03-16','Gloria','Camargo','Vargas'),(10,467767,'2020-04-15','Gabriel','Diaz','Mejia'),(11,764378,'2020-05-14','Juan','Novoa','Gomez'),(12,577643,'2020-06-13','Fabian','Salazar','Gamez'),(13,689743,'2020-07-06','Mario','Uribie','Antia'),(14,234577,'2020-03-14','Luisa','Puentes','Perdomo'),(15,567842,'2020-03-13','Maria','Uribe','Antia');
/*!40000 ALTER TABLE `prescription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `id_product` int NOT NULL,
  `name_prod` varchar(50) DEFAULT NULL,
  `date_Expiry` date DEFAULT NULL,
  `type_` varchar(30) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `ingredients` varchar(100) DEFAULT NULL,
  `id_category` int DEFAULT NULL,
  `price` double DEFAULT NULL,
  PRIMARY KEY (`id_product`),
  KEY `id_category` (`id_category`),
  CONSTRAINT `product_ibfk_1` FOREIGN KEY (`id_category`) REFERENCES `category` (`id_category`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Simvastatina','2020-09-07','Tomado',500,'Mevalonato,Eritromicina',1,260.7),(2,'Aspirina','2021-09-07','Pastillas',10,'Sacarina,Citrato de sodio,',2,320.4),(3,'Omeprazol','2020-01-13','Tomado',100,'Auril sulfato sódico,fosfato disódico',3,150),(4,'Lexotiroxina sodica','2020-02-07','Pastillas',30,'Croscarmelosa,Levotiroxina',4,420.32),(5,'Ramipril','2020-03-07','Tomado',400,'Ramipirina,Calcioso',5,123.67),(6,'Amlodipina','2020-04-13','Pastillas',13,'Amlodipino,Hidrogenofosfato de calcio',6,260.87),(7,'Paracetamol','2020-05-27','Pastillas',15,'Acetaminofeno,Almidón pregelatinizado',7,60.34),(8,'Atorvastatina','2020-06-01','Tomado',300,'Microcristalina,Carbonato sodico anhidro',8,356.89),(9,'Salbutamol','2020-07-07','Pastillas',20,'Nosemina calcica,Quiensabefuro',9,140.54),(10,'Lansoprazol','2020-08-19','Tomado',800,'Acido metacrilico,Acrilato de etilo',10,56.12),(11,'Ampicilina','2020-09-07','Pastillas',5,'Almidon Sodio Glicolato, Estearato de Magnesio',11,620.67),(12,'Amoxicilina','2020-10-23','Tomado',100,'Almidon Sodio Glicolato,Estearato de Magnesio',11,800.53),(13,'Penicilina','2021-11-28','Pastillas',10,'Acido 6-aminopenicilanico',11,720.21),(14,'Tetraciclina','2021-12-31','Tomado',200,'Estearato de Magnesio,Almidon Glicolato de Sodio',11,634.58),(15,'Estreptomicina','2020-09-05','Pastillas',8,'OXITETRACICLINA,ESTREPTOMICINA',11,861.29);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `id_supplier` int NOT NULL,
  `name_supplier` varchar(20) DEFAULT NULL,
  `last_supply_date` date DEFAULT NULL,
  `email_supplier` varchar(50) DEFAULT NULL,
  `phone_number` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'MediCorp','2018-02-20','wearemedicorp@medicorp.com','6641597774'),(2,'DoctorMed','2019-05-21','getyoursupplies@doctormed.com','6648985234'),(3,'MedDepot','2019-10-29','callusnow@meddepot.com','6640157896'),(4,'BestMedical','2020-04-10','thebest@bestmedical.com','6641248200'),(5,'MedLine','2020-03-12','supplyemail@medline.com','6648921311');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier_products`
--

DROP TABLE IF EXISTS `supplier_products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier_products` (
  `id_sup` int NOT NULL,
  `id_product` int DEFAULT NULL,
  `id_district` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `total_price` double DEFAULT NULL,
  KEY `id_product` (`id_product`),
  KEY `id_district` (`id_district`),
  KEY `fk_idsup` (`id_sup`),
  CONSTRAINT `fk_idsup` FOREIGN KEY (`id_sup`) REFERENCES `supplier` (`id_supplier`),
  CONSTRAINT `supplier_products_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `product` (`id_product`),
  CONSTRAINT `supplier_products_ibfk_2` FOREIGN KEY (`id_district`) REFERENCES `district` (`id_district`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier_products`
--

LOCK TABLES `supplier_products` WRITE;
/*!40000 ALTER TABLE `supplier_products` DISABLE KEYS */;
INSERT INTO `supplier_products` VALUES (1,1,1,150,5000),(2,2,1,200,10000),(4,4,2,70,8500),(5,5,3,50,9000),(3,3,2,100,7500);
/*!40000 ALTER TABLE `supplier_products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userr`
--

DROP TABLE IF EXISTS `userr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userr` (
  `id_user` int NOT NULL,
  `username` varchar(20) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL,
  `id_employee` int DEFAULT NULL,
  PRIMARY KEY (`id_user`),
  KEY `id_employee` (`id_employee`),
  CONSTRAINT `userr_ibfk_1` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id_employee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userr`
--

LOCK TABLES `userr` WRITE;
/*!40000 ALTER TABLE `userr` DISABLE KEYS */;
INSERT INTO `userr` VALUES (1,'e001','74821',4),(2,'e002','65925',6),(3,'e003','79753',7),(4,'e004','54122',9),(5,'e005','54319',10),(6,'e006','31778',12);
/*!40000 ALTER TABLE `userr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'farmacia3'
--

--
-- Dumping routines for database 'farmacia3'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-13 17:52:00
