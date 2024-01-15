DROP DATABASE nyiltnap 
CREATE DATABASE nyiltnap DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

USE nyiltnap;
CREATE TABLE tantargy (id int,(10) AUTO_INCREMENT PRIMARY KEY,nev varchar(50));

CREATE TABLE oktato (id int,(10) AUTO_INCREMENT PRIMARY KEY,nev varchar(50));

CREATE TABLE agazat(id int,(10) AUTO_INCREMENT PRIMARY KEY,nev varchar(50));

CREATE TABLE osztaly (id int,(10) AUTO_INCREMENT PRIMARY KEY,nev varchar(50), evfolam int, betujel varchar(10);

CREATE TABLE oktato2tantargy (id int,(10) AUTO_INCREMENT PRIMARY KEY,nev varchar(50), oktatoid int,tantargyid int);
CREATE TABLE osztaly2agazat (id int,(10) AUTO_INCREMENT PRIMARY KEY,nev varchar(50), osztalyid int, agazatid int);

CREATE TABLE idopont (id int,(10) AUTO_INCREMENT PRIMARY KEY,nev varchar(50));

CREATE TABLE osztaly(id int(10) AUTO_INCREMENT PRIMARY KEY, datum DATE, osztalyid int, oktato2tantargyid int);)