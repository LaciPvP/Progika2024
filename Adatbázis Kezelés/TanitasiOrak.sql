DROP DATABASE nyiltnap;
CREATE DATABASE nyiltnap DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

USE nyiltnap;
CREATE TABLE tantargy (id int(10) AUTO_INCREMENT PRIMARY KEY,nev VARCHAR(50));
CREATE TABLE oktato (id int(10) AUTO_INCREMENT PRIMARY KEY,nev VARCHAR(50));
CREATE TABLE agazat (id int(10) AUTO_INCREMENT PRIMARY KEY,nev VARCHAR(50));
CREATE TABLE oktato2tantargy (id int(10) AUTO_INCREMENT PRIMARY KEY,oktatoid INT,tantargyid INT);
CREATE TABLE osztaly2agazat (id int(10) AUTO_INCREMENT PRIMARY KEY,osztalyid INT,agazatid INT);
CREATE TABLE oszaly(id int(10) AUTO_INCREMENT PRIMARY KEY,evfolyam INT,betujel VARCHAR(10),osztalyfonokid int);
CREATE TABLE idopont(id int(10) AUTO_INCREMENT PRIMARY KEY,datum DATE,ora int,osztalyid int,oktato2tantargyid int);
CREATE TABLE eredeti(
id int(10),AUTO_INCREMENT primary key,
 ora int(10),
 osztaly varchar(50),
 agazat varchar(50), tantargy varhcar(50),
 tantargy varchar(50),
 oktato varchar(50),
 ofo varchar(50),
 datum DATE);
 
 INSERT INTO eredeti (ora,osztaly,agazat,tantargy,oktato,ofo,datum);
 VALUES(
 
 );