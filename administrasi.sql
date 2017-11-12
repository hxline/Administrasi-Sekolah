/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.1.72-community : Database - administrasi
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`administrasi` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `administrasi`;

/*Table structure for table `tdaftar` */

DROP TABLE IF EXISTS `tdaftar`;

CREATE TABLE `tdaftar` (
  `id_daftar` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `jenis` varchar(50) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_daftar`),
  KEY `nis` (`nis`),
  KEY `tdaftar_ibfk_3` (`id_tu`),
  CONSTRAINT `tdaftar_ibfk_2` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `tdaftar_ibfk_3` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

/*Data for the table `tdaftar` */

insert  into `tdaftar`(`id_daftar`,`nis`,`jenis`,`jumlah`,`tanggal`,`id_tu`) values (32,10111,'Daftar Baru',1000000,'2013-12-13',10234),(33,10113,'Daftar Ulang',500000,'2013-12-13',10234),(34,10114,'Daftar Baru',1000000,'2013-12-13',10234),(35,10115,'Daftar Ulang',500000,'2013-12-13',10234),(36,10113,'Daftar Ulang',500000,'2013-12-13',10234);

/*Table structure for table `tpembayaran` */

DROP TABLE IF EXISTS `tpembayaran`;

CREATE TABLE `tpembayaran` (
  `id_pembayaran` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `spp` int(11) DEFAULT NULL,
  `cathering` int(11) DEFAULT NULL,
  `marching_band` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  `bulan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_pembayaran`),
  KEY `nis` (`nis`),
  KEY `tpembayaran_ibfk_1` (`id_tu`),
  CONSTRAINT `tpembayaran_ibfk_1` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `tpembayaran_ibfk_2` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `tpembayaran` */

insert  into `tpembayaran`(`id_pembayaran`,`nis`,`spp`,`cathering`,`marching_band`,`total`,`tanggal`,`id_tu`,`bulan`) values (4,10112,250000,0,100000,350000,'2013-11-22',10232,'Januari'),(5,10111,250000,50000,100000,400000,'2013-11-22',10232,'Februari'),(6,10113,250000,50000,100000,400000,'2013-11-22',10232,'Januari'),(7,10114,250000,50000,100000,400000,'2013-11-22',10234,'Desember'),(8,10114,250000,50000,100000,400000,'2013-11-22',10234,'Maret'),(9,10113,250000,50000,100000,400000,'2013-12-13',10234,'Maret');

/*Table structure for table `tsiswa` */

DROP TABLE IF EXISTS `tsiswa`;

CREATE TABLE `tsiswa` (
  `nis` int(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `kelas` int(11) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  PRIMARY KEY (`nis`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tsiswa` */

insert  into `tsiswa`(`nis`,`nama`,`kelas`,`tanggal`) values (10111,'Bagas',1,'2013-11-22'),(10112,'Andri Sandi',6,'2013-11-22'),(10113,'Gogon Candra',6,'2013-11-22'),(10114,'Agus Safri',1,'2013-11-22'),(10115,'Fahri',5,'2013-11-22');

/*Table structure for table `tsurat` */

DROP TABLE IF EXISTS `tsurat`;

CREATE TABLE `tsurat` (
  `id_surat` int(11) NOT NULL AUTO_INCREMENT,
  `no_surat` varchar(50) DEFAULT NULL,
  `lampiran` varchar(50) DEFAULT NULL,
  `perihal` varchar(50) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `jenis` varchar(50) DEFAULT NULL,
  `pengirim` varchar(50) DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_surat`),
  KEY `tsurat_ibfk_1` (`id_tu`),
  CONSTRAINT `tsurat_ibfk_1` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `tsurat` */

insert  into `tsurat`(`id_surat`,`no_surat`,`lampiran`,`perihal`,`tanggal`,`jenis`,`pengirim`,`id_tu`) values (6,'10233','Ate','ass','2013-11-22','Surat Keluar','Bagus',10232);

/*Table structure for table `ttabungan` */

DROP TABLE IF EXISTS `ttabungan`;

CREATE TABLE `ttabungan` (
  `id_tabung` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_tabung`),
  KEY `nis` (`nis`),
  KEY `ttabungan_ibfk_2` (`id_tu`),
  CONSTRAINT `ttabungan_ibfk_1` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ttabungan_ibfk_2` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

/*Data for the table `ttabungan` */

insert  into `ttabungan`(`id_tabung`,`nis`,`jumlah`,`tanggal`,`id_tu`) values (27,10112,90000,'2013-11-22',10232),(28,10113,80000,'2013-11-22',10232),(29,10113,70000,'2013-11-22',10232),(30,10112,80000,'2013-11-22',10232),(31,10111,90000,'2013-11-22',10232),(32,10111,300000,'2013-11-28',10235),(33,10114,20000,'2013-11-28',10235),(34,10112,900000,'2013-11-28',10235),(35,10114,220000,'2013-11-28',10235),(36,10115,5000,'2013-11-28',10235),(37,10115,50000,'2013-11-28',10235),(38,10115,98,'2013-11-28',10235),(39,10113,80000,'2013-11-28',10235),(40,10112,90000,'2013-11-28',10235),(41,10111,90000,'2013-11-28',10235);

/*Table structure for table `ttabungankeluar` */

DROP TABLE IF EXISTS `ttabungankeluar`;

CREATE TABLE `ttabungankeluar` (
  `id_tabung_keluar` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_tabung_keluar`),
  KEY `nis` (`nis`),
  KEY `ttabungankeluar_ibfk_2` (`id_tu`),
  CONSTRAINT `ttabungankeluar_ibfk_1` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ttabungankeluar_ibfk_2` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

/*Data for the table `ttabungankeluar` */

insert  into `ttabungankeluar`(`id_tabung_keluar`,`nis`,`jumlah`,`tanggal`,`id_tu`) values (10,10112,70000,'2013-11-22',10232),(11,10113,50000,'2013-11-22',10232),(12,10115,2000,'2013-11-22',10234),(13,10114,20000,'2013-11-29',10234),(14,10112,30000,'2013-11-29',10235);

/*Table structure for table `ttotal` */

DROP TABLE IF EXISTS `ttotal`;

CREATE TABLE `ttotal` (
  `id_total` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_total`),
  KEY `nis` (`nis`),
  CONSTRAINT `ttotal_ibfk_1` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `ttotal` */

insert  into `ttotal`(`id_total`,`nis`,`total`) values (7,10112,1130000),(8,10113,230000),(9,10111,480000),(10,10115,55098),(11,10114,200000);

/*Table structure for table `ttu` */

DROP TABLE IF EXISTS `ttu`;

CREATE TABLE `ttu` (
  `id_tu` int(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  PRIMARY KEY (`id_tu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ttu` */

insert  into `ttu`(`id_tu`,`nama`,`password`,`tanggal`) values (10232,'admin','21232f297a57a5a743894a0e4a801fc3','2013-11-22'),(10234,'Handoyo','ce65f40e3a20ad19fe352c52ce3bcf51','2013-11-22'),(10235,'Hasan','81dc9bdb52d04dc20036dbd8313ed055','2013-11-22'),(10236,'tes','28b662d883b6d76fd96e4ddc5e9ba780','2013-11-22'),(10256,'ujang','db510282fbf0edc97f0b63ab19e00c6a','2013-11-29');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
