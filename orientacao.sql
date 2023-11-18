-- MySqlBackup.NET 2.3.6
-- Dump Time: 2023-11-13 15:47:59
-- --------------------------------------
-- Server version 10.4.28-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of alimento
-- 

create database orientacao;

use orientacao;

DROP TABLE IF EXISTS `alimento`;
CREATE TABLE IF NOT EXISTS `alimento` (
  `cod_alimento` int(11) NOT NULL AUTO_INCREMENT,
  `nome_alimento` varchar(100) NOT NULL,
  `descricao_alimento` text DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_alimento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table alimento
-- 

/*!40000 ALTER TABLE `alimento` DISABLE KEYS */;

/*!40000 ALTER TABLE `alimento` ENABLE KEYS */;

-- 
-- Definition of apenado
-- 

DROP TABLE IF EXISTS `apenado`;
CREATE TABLE IF NOT EXISTS `apenado` (
  `cod_apenado` int(11) NOT NULL AUTO_INCREMENT,
  `nome_apenado` varchar(250) NOT NULL,
  `data_nascimento` varchar(255) DEFAULT NULL,
  `genero` enum('Masculino','Feminino') NOT NULL,
  `bi` varchar(30) NOT NULL,
  `nome_pai` varchar(250) DEFAULT NULL,
  `nome_mae` varchar(250) DEFAULT NULL,
  `cod_provincia` int(11) NOT NULL,
  `naturalidade` varchar(150) NOT NULL,
  `residencia` varchar(250) DEFAULT NULL,
  `estado_civil` enum('Solteiro(a)','Casado(a)','Divorciado(a)','Viuvo(a)','Uniao de facto') DEFAULT NULL,
  `altura` float NOT NULL,
  `img` blob DEFAULT NULL,
  `apelido` varchar(250) NOT NULL,
  `descricao_apenado` text DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_apenado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table apenado
-- 

/*!40000 ALTER TABLE `apenado` DISABLE KEYS */;

/*!40000 ALTER TABLE `apenado` ENABLE KEYS */;

-- 
-- Definition of bloco
-- 

DROP TABLE IF EXISTS `bloco`;
CREATE TABLE IF NOT EXISTS `bloco` (
  `cod_bloco` int(11) NOT NULL AUTO_INCREMENT,
  `nome_bloco` varchar(100) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_bloco`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table bloco
-- 

/*!40000 ALTER TABLE `bloco` DISABLE KEYS */;

/*!40000 ALTER TABLE `bloco` ENABLE KEYS */;

-- 
-- Definition of cama
-- 

DROP TABLE IF EXISTS `cama`;
CREATE TABLE IF NOT EXISTS `cama` (
  `cod_cama` int(11) NOT NULL AUTO_INCREMENT,
  `numero_cama` int(11) NOT NULL,
  `cod_cela` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_cama`),
  KEY `fk_codcela_cama` (`cod_cela`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table cama
-- 

/*!40000 ALTER TABLE `cama` DISABLE KEYS */;

/*!40000 ALTER TABLE `cama` ENABLE KEYS */;

-- 
-- Definition of cela
-- 

DROP TABLE IF EXISTS `cela`;
CREATE TABLE IF NOT EXISTS `cela` (
  `cod_cela` int(11) NOT NULL AUTO_INCREMENT,
  `nome_cela` varchar(100) NOT NULL,
  `cod_bloco` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_cela`),
  KEY `fk_codbloco_cela` (`cod_bloco`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table cela
-- 

/*!40000 ALTER TABLE `cela` DISABLE KEYS */;

/*!40000 ALTER TABLE `cela` ENABLE KEYS */;

-- 
-- Definition of cuidado
-- 

DROP TABLE IF EXISTS `cuidado`;
CREATE TABLE IF NOT EXISTS `cuidado` (
  `cod_cuidado` int(11) NOT NULL AUTO_INCREMENT,
  `cod_enfermagem` int(11) NOT NULL,
  `problema` text NOT NULL,
  `acao_implementada` text NOT NULL,
  `data_registo` date NOT NULL,
  `hora` time NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`cod_cuidado`),
  KEY `fk_codenfermagem_cuidado` (`cod_enfermagem`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table cuidado
-- 

/*!40000 ALTER TABLE `cuidado` DISABLE KEYS */;

/*!40000 ALTER TABLE `cuidado` ENABLE KEYS */;

-- 
-- Definition of enfermagem
-- 

DROP TABLE IF EXISTS `enfermagem`;
CREATE TABLE IF NOT EXISTS `enfermagem` (
  `cod_enfermagem` int(11) NOT NULL AUTO_INCREMENT,
  `cod_processo` int(11) DEFAULT NULL,
  `cod_utilizador` int(11) NOT NULL,
  `descricao` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_enfermagem`),
  KEY `fk_codprocesso_enfermagem` (`cod_processo`),
  KEY `fk_codutilizador_enfermagem` (`cod_utilizador`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table enfermagem
-- 

/*!40000 ALTER TABLE `enfermagem` DISABLE KEYS */;

/*!40000 ALTER TABLE `enfermagem` ENABLE KEYS */;

-- 
-- Definition of funcao
-- 

DROP TABLE IF EXISTS `funcao`;
CREATE TABLE IF NOT EXISTS `funcao` (
  `cod_funcao` int(11) NOT NULL AUTO_INCREMENT,
  `nome_funcao` varchar(100) NOT NULL,
  `descricao_funcao` text DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_funcao`)
) ENGINE=MyISAM AUTO_INCREMENT=85 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table funcao
-- 

/*!40000 ALTER TABLE `funcao` DISABLE KEYS */;
INSERT INTO `funcao`(`cod_funcao`,`nome_funcao`,`descricao_funcao`,`created_at`) VALUES(1,'funcao efectuar login\r\n',NULL,'2022-06-23 19:31:46'),(2,'funcao acessar tipo de funcionario \r\n',NULL,'2022-06-23 19:31:59'),(3,'funcao cadastrar  tipo de funcionario \r\n',NULL,'2022-06-23 19:32:15'),(4,'funcao editar  tipo de funcionario \r\n',NULL,'2022-06-23 19:32:27'),(5,'funcao excluir  tipo de funcionario \r\n',NULL,'2022-06-23 19:32:35'),(6,'funcao listar  tipo de funcionario \r\n',NULL,'2022-06-23 19:32:55'),(7,'funcao acessar funcionario \r\n',NULL,'2022-06-23 19:33:18'),(8,'funcao cadastrar funcionario \r\n',NULL,'2022-06-23 19:33:25'),(9,'funcao editar funcionario \r\n',NULL,'2022-06-23 19:33:35'),(10,'funcao excluir funcionario \r\n',NULL,'2022-06-23 19:36:25'),(11,'funcao listar funcionario \r\n',NULL,'2022-06-23 19:33:54'),(12,'funcao acessar processo\r\n',NULL,'2022-06-23 19:37:09'),(13,'funcao dar soltura\r\n',NULL,'2022-06-23 19:37:17'),(14,'funcao cadastrar processo\r\n',NULL,'2022-06-23 19:37:25'),(15,'funcao excluir processo\r\n',NULL,'2022-06-23 19:37:35'),(16,'funcao listar processo\r\n',NULL,'2022-06-23 19:37:45'),(17,'funcao acessar apenado \r\n',NULL,'2022-06-23 19:38:00'),(18,'funcao cadastrar apenado\r\n',NULL,'2022-06-23 19:38:09'),(19,'funcao editar apenado \r\n',NULL,'2022-06-23 19:38:19'),(20,'funcao excluir apenado\r\n',NULL,'2022-06-23 19:38:26'),(21,'funcao listar apenado\r\n',NULL,'2022-06-23 19:38:35'),(22,'funcao acessar visita \r\n',NULL,'2022-06-23 19:39:08'),(23,'funcao cadastar visita\r ',NULL,'2023-11-06 09:45:41'),(24,'funcao editar visita\r\n',NULL,'2022-06-23 19:39:29'),(25,'funcao excluir visita\r\n',NULL,'2022-06-23 19:39:41'),(26,'funcao listar visita \r\n',NULL,'2022-06-23 19:39:52'),(27,'funcao acessar visitante \r\n',NULL,'2022-06-23 19:41:59'),(28,'funcao cadastrar visitante \r\n',NULL,'2022-06-23 19:42:06'),(29,'funcao editar visitante\r\n',NULL,'2022-06-23 19:42:13'),(30,'funcao excluir visitante\r\n',NULL,'2022-06-23 19:43:40'),(31,'funcao listar visitante\r\n',NULL,'2022-06-23 19:43:49'),(32,'funcao acessar enfermaria\r\n',NULL,'2022-06-23 19:44:03'),(33,'funcao cadastrar enfermaria\r\n',NULL,'2022-06-23 19:44:11'),(34,'funcao editar enfermaria\r\n',NULL,'2022-06-23 19:52:50'),(35,'funcao excluir enfermaria\r\n',NULL,'2022-06-23 19:45:21'),(36,'funcao listar enfermaria\r\n',NULL,'2022-06-23 19:53:34'),(37,'funcao acessar cuidados\r\n',NULL,'2022-06-23 19:46:18'),(38,'funcao cadastrar cuidados\r\n',NULL,'2022-06-23 20:22:53'),(39,'funcao editar cuidados\r\n',NULL,'2022-06-23 19:47:40'),(40,'funcao excluir cuidados \r\n',NULL,'2022-06-23 19:48:34'),(41,'funcao listar cuidados\r\n',NULL,'2022-06-23 19:48:43'),(42,'funcao acessar refeitorio\r\n',NULL,'2022-06-23 19:49:34'),(43,'funcao cadastrar refeitorio\r\n',NULL,'2022-06-23 19:50:08'),(44,'funcao editar refeitorio\r\n',NULL,'2022-06-23 19:54:18'),(45,'funcao excluir refeitorio\r\n',NULL,'2022-06-23 19:54:46'),(46,'funcao listar refeitorio\r\n',NULL,'2022-06-23 19:55:17'),(47,'funcao acessar alimento\r\n',NULL,'2022-06-23 19:55:51'),(48,'funcao cadastrar alimento\r\n',NULL,'2022-06-23 19:56:00'),(49,'funcao editar alimento\r\n',NULL,'2022-06-23 19:56:08'),(50,'funcao excluir alimento\r\n',NULL,'2022-06-23 19:56:16'),(51,'funcao listar alimento\r\n',NULL,'2022-06-23 20:12:16'),(52,'funcao acessar tipo de crime \r\n',NULL,'2022-06-23 19:56:39'),(53,'funcao cadastrar tipo de crime',NULL,'2022-06-23 20:12:09'),(54,'funcao editar tipo de crime \r\n',NULL,'2022-06-23 19:56:55'),(55,'funcao excluir tipo de crime \r\n',NULL,'2022-06-23 19:57:01'),(56,'funcao listar tipo de crime \r\n',NULL,'2022-06-23 19:57:09'),(57,'funcao acessar bloco \r\n',NULL,'2022-06-23 19:57:44'),(58,'funcao cadastrar bloco\r\n',NULL,'2022-06-23 19:57:54'),(59,'funcao editar bloco\r\n',NULL,'2022-06-23 19:58:03'),(60,'funcao excluir bloco\r\n',NULL,'2022-06-23 19:59:08'),(61,'funcao listrar bloco\r\n',NULL,'2022-06-23 19:59:29'),(62,'funcao acessar cela \r\n',NULL,'2022-06-23 20:13:22'),(63,'funcao cadastrar cela\r\n',NULL,'2022-06-23 20:13:35'),(64,'funcao editar cela\r\n',NULL,'2022-06-23 20:13:54'),(65,'funcao excluir cela\r\n',NULL,'2022-06-23 20:14:03'),(66,'funcao listar cela\r\n',NULL,'2022-06-23 20:14:11'),(67,'funcao acessar cama \r\n',NULL,'2022-06-23 20:14:17'),(68,'funcao cadastrar cama\r\n',NULL,'2022-06-23 20:14:35'),(69,'funcao editar cama\r\n',NULL,'2022-06-23 20:14:44'),(70,'funcao excluir cama\r\n',NULL,'2022-06-23 20:14:52'),(71,'funcao listar cama\r\n',NULL,'2022-06-23 20:15:01'),(72,'funcao acessar funcao \r\n',NULL,'2022-06-23 20:15:09'),(73,'funcao cadastrar funcao \r\n',NULL,'2022-06-23 20:15:20'),(74,'funcao editar funcao\r\n',NULL,'2022-06-23 20:15:32'),(75,'funcao listar funcao\r\n',NULL,'2022-06-23 20:15:41'),(76,'funcao acessar utiltizador\r\n',NULL,'2022-06-23 20:15:49'),(77,'funcao cadastrar utiltizador\r\n',NULL,'2022-06-23 20:15:57'),(78,'funcao editar utiltizador\r\n',NULL,'2022-06-23 20:16:19'),(79,'funcao excluir utiltizador\r\n',NULL,'2022-06-23 20:16:27'),(80,'funcao listrar utiltizador\r\n',NULL,'2022-06-23 20:16:35'),(81,'funcao acessar backup\r\n',NULL,'2022-06-23 20:16:48'),(82,'funcao fazer backup\r\n',NULL,'2022-06-23 20:16:55'),(83,'',NULL,'2022-06-23 20:17:06'),(84,'Admin','Função para Administrador do Sistema','2023-11-06 09:42:15');
/*!40000 ALTER TABLE `funcao` ENABLE KEYS */;

-- 
-- Definition of funcao_permissao
-- 

DROP TABLE IF EXISTS `funcao_permissao`;
CREATE TABLE IF NOT EXISTS `funcao_permissao` (
  `cod_funcao` int(11) NOT NULL,
  `cod_permissao` int(11) NOT NULL,
  PRIMARY KEY (`cod_funcao`,`cod_permissao`),
  KEY `fk_codpermissao_funcaopermissao` (`cod_permissao`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table funcao_permissao
-- 

/*!40000 ALTER TABLE `funcao_permissao` DISABLE KEYS */;
INSERT INTO `funcao_permissao`(`cod_funcao`,`cod_permissao`) values(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10),
    (11, 11), (12, 12), (13, 13), (14, 14), (15, 15), (16, 16), (17, 17), (18, 18), (19, 19), (20, 20),
    (21, 21), (22, 22), (23, 23), (24, 24), (25, 25), (26, 26), (27, 27), (28, 28), (29, 29), (30, 30),
    (31, 31), (32, 32), (33, 33), (34, 34), (35, 35), (36, 36), (37, 37), (38, 38), (39, 39), (40, 40),
    (41, 41), (42, 42), (43, 43), (44, 44), (45, 45), (46, 46), (47, 47), (48, 48), (49, 49), (50, 50),
    (51, 51), (52, 52), (53, 53), (54, 54), (55, 55), (56, 56), (57, 57), (58, 58), (59, 59), (60, 60),
    (61, 61), (62, 62), (63, 63), (64, 64), (65, 65), (66, 66), (67, 67), (68, 68), (69, 69), (70, 70),
    (71, 71), (72, 72), (73, 73), (74, 74), (75, 75), (76, 76), (77, 77), (78, 78), (79, 79), (80, 80),
    (81, 81), (82, 82), (83, 83), (84, 84),(84,1),(84,2),(84,3),(84,4),(84,5),(84,6),(84,7),(84,8),(84,9),(84,10),(84,11),(84,12),(84,13),(84,14),(84,15),(84,16),(84,17),(84,18),(84,19),(84,20),(84,21),(84,22),(84,23),(84,24),(84,25),(84,26),(84,27),(84,28),(84,29),(84,30),(84,31),(84,32),(84,33),(84,34),(84,35),(84,36),(84,37),(84,38),(84,39),(84,40),(84,41),(84,42),(84,43),(84,44),(84,45),(84,46),(84,47),(84,48),(84,49),(84,50),(84,51),(84,52),(84,53),(84,54),(84,55),(84,56),(84,57),(84,58),(84,59),(84,60),(84,61),(84,62),(84,63),(84,64),(84,65),(84,66),(84,67),(84,68),(84,69),(84,70),(84,71),(84,72),(84,73),(84,74),(84,75),(84,76),(84,77),(84,78),(84,79),(84,80),(84,81),(84,82),(84,83);
/*!40000 ALTER TABLE `funcao_permissao` ENABLE KEYS */;
-- 
-- Definition of funcionario
-- 

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE IF NOT EXISTS `funcionario` (
  `cod_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `cod_tipo_funcionario` int(11) NOT NULL,
  `nome_funcionario` varchar(250) NOT NULL,
  `data_nascimento` varchar(255) DEFAULT '',
  `genero` enum('Masculino','Feminino') NOT NULL,
  `bi` varchar(30) NOT NULL,
  `nome_pai` varchar(250) DEFAULT '',
  `nome_mae` varchar(250) DEFAULT '',
  `cod_provincia` int(11) NOT NULL,
  `residencia` varchar(250) DEFAULT '',
  `estado_civil` enum('Solteiro(a)','Casado(a)','Divorciado(a)','Viuvo(a)','Uniao de facto') DEFAULT NULL,
  `altura` float DEFAULT NULL,
  `img` blob DEFAULT NULL,
  `nip` int(11) NOT NULL,
  `tel1` int(11) NOT NULL,
  `tel2` int(11) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_funcionario`),
  KEY `fk_codtipofuncionario_funcionario` (`cod_tipo_funcionario`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table funcionario
-- 

/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;

/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;

-- 
-- Definition of permissao
-- 

DROP TABLE IF EXISTS `permissao`;
CREATE TABLE IF NOT EXISTS `permissao` (
  `cod_permissao` int(11) NOT NULL AUTO_INCREMENT,
  `nome_permissao` varchar(100) NOT NULL,
  `descricao_permissao` text DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`cod_permissao`)
) ENGINE=MyISAM AUTO_INCREMENT=84 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table permissao
-- 

/*!40000 ALTER TABLE `permissao` DISABLE KEYS */;
INSERT INTO `permissao`(`cod_permissao`,`nome_permissao`,`descricao_permissao`,`created_at`) VALUES(1,'permissao efectuar login',NULL,NULL),(2,'permissao acessar tipo de funcionario ',NULL,NULL),(3,'permissao cadastrar  tipo de funcionario ',NULL,NULL),(4,'permissao editar  tipo de funcionario ',NULL,NULL),(5,'permissao excluir  tipo de funcionario ',NULL,NULL),(6,'permissao listar  tipo de funcionario ',NULL,NULL),(7,'permissao acessar funcionario ',NULL,NULL),(8,'permissao cadastrar funcionario ',NULL,NULL),(9,'permissao editar funcionario ',NULL,NULL),(10,'permissao excluir funcionario ',NULL,NULL),(11,'permissao listar funcionario ',NULL,NULL),(12,'permissao acessar processo',NULL,NULL),(13,'permissao dar soltura',NULL,NULL),(14,'permissao cadastrar processo',NULL,NULL),(15,'permissao excluir processo',NULL,NULL),(16,'permissao listar processo',NULL,NULL),(17,'permissao acessar apenado ',NULL,NULL),(18,'permissao cadastrar apenado',NULL,NULL),(19,'permissao editar apenado ',NULL,NULL),(20,'permissao excluir apenado',NULL,NULL),(21,'permissao listar apenado',NULL,NULL),(22,'permissao acessar visita ',NULL,NULL),(23,'permissao cadastar visita',NULL,NULL),(24,'permissao editar visita',NULL,NULL),(25,'permissao excluir visita',NULL,NULL),(26,'permissao listar visita ',NULL,NULL),(27,'permissao acessar visitante ',NULL,NULL),(28,'permissao cadastrar visitante ',NULL,NULL),(29,'permissao editar visitante',NULL,NULL),(30,'permissao excluir visitante',NULL,NULL),(31,'permissao listar visitante',NULL,NULL),(32,'permissao acessar enfermaria',NULL,NULL),(33,'permissao cadastrar enfermaria',NULL,NULL),(34,'permissao editar enfermaria',NULL,NULL),(35,'permissao excluir enfermaria',NULL,NULL),(36,'permissao listar enfermaria',NULL,NULL),(37,'permissao acessar cuidados',NULL,NULL),(38,'permissao cadastrar cuidados',NULL,NULL),(39,'permissao editar cuidados',NULL,NULL),(40,'permissao excluir cuidados ',NULL,NULL),(41,'permissao listar cuidados',NULL,NULL),(42,'permissao acessar refeitorio',NULL,NULL),(43,'permissao cadastrar refeitorio',NULL,NULL),(44,'permissao editar refeitorio',NULL,NULL),(45,'permissao excluir refeitorio',NULL,NULL),(46,'permissao listar refeitorio',NULL,NULL),(47,'permissao acessar alimento',NULL,NULL),(48,'permissao cadastrar alimento',NULL,NULL),(49,'permissao editar alimento',NULL,NULL),(50,'permissao excluir alimento',NULL,NULL),(51,'permissao listar alimento',NULL,NULL),(52,'permissao acessar tipo de crime ',NULL,NULL),(53,'permissao cadastrar tipo de crime',NULL,NULL),(54,'permissao editar tipo de crime ',NULL,NULL),(55,'permissao excluir tipo de crime ',NULL,NULL),(56,'permissao listar tipo de crime ',NULL,NULL),(57,'permissao acessar bloco ',NULL,NULL),(58,'permissao cadastrar bloco',NULL,NULL),(59,'permissao editar bloco',NULL,NULL),(60,'permissao excluir bloco',NULL,NULL),(61,'permissao listrar bloco',NULL,NULL),(62,'permissao acessar cela ',NULL,NULL),(63,'permissao cadastrar cela',NULL,NULL),(64,'permissao editar cela',NULL,NULL),(65,'permissao excluir cela',NULL,NULL),(66,'permissao listar cela',NULL,NULL),(67,'permissao acessar cama ',NULL,NULL),(68,'permissao cadastrar cama',NULL,NULL),(69,'permissao editar cama',NULL,NULL),(70,'permissao excluir cama',NULL,NULL),(71,'permissao listar cama',NULL,NULL),(72,'permissao acessar funcao ',NULL,NULL),(73,'permissao cadastrar funcao ',NULL,NULL),(74,'permissao editar funcao',NULL,NULL),(75,'permissao listar funcao',NULL,NULL),(76,'permissao acessar utiltizador',NULL,NULL),(77,'permissao cadastrar utiltizador',NULL,NULL),(78,'permissao editar utiltizador',NULL,NULL),(79,'permissao excluir utiltizador',NULL,NULL),(80,'permissao listrar utiltizador',NULL,NULL),(81,'permissao acessar backup',NULL,NULL),(82,'Permissao fazer backup',NULL,NULL),(83,'',NULL,NULL);
/*!40000 ALTER TABLE `permissao` ENABLE KEYS */;

-- 
-- Definition of processo
-- 

DROP TABLE IF EXISTS `processo`;
CREATE TABLE IF NOT EXISTS `processo` (
  `cod_processo` int(11) NOT NULL AUTO_INCREMENT,
  `num_processo` varchar(100) NOT NULL,
  `cod_apenado` int(11) NOT NULL,
  `cod_cama` int(11) NOT NULL,
  `descricao` text DEFAULT NULL,
  `estado` enum('Detido','Solto') DEFAULT 'Detido',
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_processo`),
  KEY `fk_codapenado_processo` (`cod_apenado`),
  KEY `fk_idcodapenado_processo` (`cod_cama`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table processo
-- 

/*!40000 ALTER TABLE `processo` DISABLE KEYS */;

/*!40000 ALTER TABLE `processo` ENABLE KEYS */;

-- 
-- Definition of processo_cama
-- 

DROP TABLE IF EXISTS `processo_cama`;
CREATE TABLE IF NOT EXISTS `processo_cama` (
  `cod_processo` int(11) NOT NULL,
  `cod_cama` int(11) NOT NULL,
  KEY `fk_codprocesso_processocama` (`cod_processo`),
  KEY `fk_codcama_processocama` (`cod_cama`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table processo_cama
-- 

/*!40000 ALTER TABLE `processo_cama` DISABLE KEYS */;

/*!40000 ALTER TABLE `processo_cama` ENABLE KEYS */;

-- 
-- Definition of processo_crime
-- 

DROP TABLE IF EXISTS `processo_crime`;
CREATE TABLE IF NOT EXISTS `processo_crime` (
  `cod_processo` int(11) NOT NULL,
  `cod_tipo_crime` int(11) NOT NULL,
  PRIMARY KEY (`cod_processo`,`cod_tipo_crime`),
  KEY `fk_codtipocrime_processocrime` (`cod_tipo_crime`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table processo_crime
-- 

/*!40000 ALTER TABLE `processo_crime` DISABLE KEYS */;
INSERT INTO `processo_crime`(`cod_processo`,`cod_tipo_crime`) VALUES(2,2),(2,4),(2,5),(2,6),(3,1),(3,3),(3,4),(3,5),(4,2),(4,3),(4,4),(4,5),(5,6),(6,1),(6,3),(6,4),(6,6),(7,1),(7,2),(7,5),(7,6),(8,1),(8,2),(8,3),(8,4),(8,5),(8,6);
/*!40000 ALTER TABLE `processo_crime` ENABLE KEYS */;

-- 
-- Definition of provincia
-- 

DROP TABLE IF EXISTS `provincia`;
CREATE TABLE IF NOT EXISTS `provincia` (
  `cod_provincia` int(11) NOT NULL AUTO_INCREMENT,
  `nome_provincia` varchar(50) NOT NULL,
  PRIMARY KEY (`cod_provincia`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table provincia
-- 

/*!40000 ALTER TABLE `provincia` DISABLE KEYS */;
INSERT INTO `provincia`(`cod_provincia`,`nome_provincia`) VALUES(1,'Bengo'),(2,'Benguela'),(3,'Bié'),(4,'Cabinda'),(5,'Kuando-Kubango'),(6,'Kwanza-Norte'),(7,'Kwanza-Sul'),(8,'Cunene'),(9,'Huambo'),(10,'Huíla'),(11,'Luanda '),(12,'Lunda-Norte'),(13,'Lunda-Sul'),(14,'Malanje'),(15,'Moxico'),(16,'Namibe'),(17,'Uíge'),(18,'Zaire');
/*!40000 ALTER TABLE `provincia` ENABLE KEYS */;

-- 
-- Definition of refeitorio
-- 

DROP TABLE IF EXISTS `refeitorio`;
CREATE TABLE IF NOT EXISTS `refeitorio` (
  `cod_refeitorio` int(11) NOT NULL AUTO_INCREMENT,
  `cod_processo` int(11) NOT NULL,
  `cod_alimento` int(11) NOT NULL,
  `tipo_refereicao` enum('Matabicho','Almoco','Jantar') NOT NULL DEFAULT 'Matabicho',
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_refeitorio`),
  KEY `fk_codprocesso_refeitorio` (`cod_processo`),
  KEY `fk_codalimento_refeitorio` (`cod_alimento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table refeitorio
-- 

/*!40000 ALTER TABLE `refeitorio` DISABLE KEYS */;

/*!40000 ALTER TABLE `refeitorio` ENABLE KEYS */;

-- 
-- Definition of tipo_crime
-- 

DROP TABLE IF EXISTS `tipo_crime`;
CREATE TABLE IF NOT EXISTS `tipo_crime` (
  `cod_tipo_crime` int(11) NOT NULL AUTO_INCREMENT,
  `nome_tipo_crime` varchar(100) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_tipo_crime`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table tipo_crime
-- 

/*!40000 ALTER TABLE `tipo_crime` DISABLE KEYS */;

/*!40000 ALTER TABLE `tipo_crime` ENABLE KEYS */;

-- 
-- Definition of tipo_funcionario
-- 

DROP TABLE IF EXISTS `tipo_funcionario`;
CREATE TABLE IF NOT EXISTS `tipo_funcionario` (
  `cod_tipo_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `nome_tipo_funcionario` varchar(100) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_tipo_funcionario`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table tipo_funcionario
-- 

/*!40000 ALTER TABLE `tipo_funcionario` DISABLE KEYS */;

/*!40000 ALTER TABLE `tipo_funcionario` ENABLE KEYS */;

-- 
-- Definition of utilizador
-- 

DROP TABLE IF EXISTS `utilizador`;
CREATE TABLE IF NOT EXISTS `utilizador` (
  `cod_utilizador` int(11) NOT NULL AUTO_INCREMENT,
  `cod_funcionario` int(11) DEFAULT NULL,
  `nome_utilizador` varchar(250) NOT NULL,
  `senha` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_utilizador`),
  UNIQUE KEY `nome_utilizador` (`nome_utilizador`),
  KEY `fk_codfuncionario_utilizador` (`cod_funcionario`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table utilizador
-- 

/*!40000 ALTER TABLE `utilizador` DISABLE KEYS */;
INSERT INTO `utilizador`(`cod_utilizador`,`cod_funcionario`,`nome_utilizador`,`senha`,`created_at`) VALUES(1,NULL,'HP','4a1cc6a0e2f4d7724677dc49de19b5b8','2022-06-22 08:16:30');
/*!40000 ALTER TABLE `utilizador` ENABLE KEYS */;

-- 
-- Definition of utilizador_funcao
-- 

DROP TABLE IF EXISTS `utilizador_funcao`;
CREATE TABLE IF NOT EXISTS `utilizador_funcao` (
  `cod_utilizador` int(11) NOT NULL,
  `cod_funcao` int(11) NOT NULL,
  PRIMARY KEY (`cod_utilizador`,`cod_funcao`),
  KEY `fk_codfuncao_utilizadorfuncao` (`cod_funcao`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table utilizador_funcao
-- 

/*!40000 ALTER TABLE `utilizador_funcao` DISABLE KEYS */;
INSERT INTO `utilizador_funcao`(`cod_utilizador`,`cod_funcao`) VALUES(1,84);
/*!40000 ALTER TABLE `utilizador_funcao` ENABLE KEYS */;

-- 
-- Definition of visita
-- 

DROP TABLE IF EXISTS `visita`;
CREATE TABLE IF NOT EXISTS `visita` (
  `cod_visita` int(11) NOT NULL AUTO_INCREMENT,
  `cod_visitante` int(11) NOT NULL,
  `cod_processo` int(11) NOT NULL,
  `tipo_visita` enum('Social','Intima') NOT NULL,
  `data_visita` varchar(255) DEFAULT NULL,
  `hora_visita` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cod_visita`),
  KEY `fk_codvisitante_visita` (`cod_visitante`),
  KEY `fk_codprocesso_visita` (`cod_processo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table visita
-- 

/*!40000 ALTER TABLE `visita` DISABLE KEYS */;

/*!40000 ALTER TABLE `visita` ENABLE KEYS */;

-- 
-- Definition of visitante
-- 

DROP TABLE IF EXISTS `visitante`;
CREATE TABLE IF NOT EXISTS `visitante` (
  `cod_visitante` int(11) NOT NULL AUTO_INCREMENT,
  `nome_visitante` varchar(250) NOT NULL,
  `data_nascimento` varchar(255) DEFAULT NULL,
  `genero` enum('Masculino','Feminino') NOT NULL,
  `bi` varchar(30) NOT NULL,
  `naturalidade` varchar(150) NOT NULL,
  `residencia` varchar(250) DEFAULT NULL,
  `contacto` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`cod_visitante`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- 
-- Dumping data for table visitante
-- 

/*!40000 ALTER TABLE `visitante` DISABLE KEYS */;

/*!40000 ALTER TABLE `visitante` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-11-13 15:48:00
-- Total time: 0:0:0:0:379 (d:h:m:s:ms)
