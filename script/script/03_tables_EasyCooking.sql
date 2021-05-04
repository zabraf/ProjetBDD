-- ====================================================================
-- Script : 03_tables_EasyCooking.sql
-- Objet  : Création et suppression des tables EasyCooking 
-- ====================================================================
-- ====================================================
-- Suppression des tables
-- ====================================================
DROP TABLE eco_contient CASCADE CONSTRAINT;
DROP TABLE eco_comporte CASCADE CONSTRAINT;
--DROP TABLE eco_favoris CASCADE CONSTRAINT;
DROP TABLE eco_recette CASCADE CONSTRAINT;
DROP TABLE eco_ingredient CASCADE CONSTRAINT;
DROP TABLE eco_ami CASCADE CONSTRAINT;
DROP TABLE eco_achat CASCADE CONSTRAINT;
-- ====================================================
-- Création des tables
-- ====================================================
-- ====================================================
-- Table : eco_AMI
-- ====================================================
CREATE TABLE eco_ami (
		ami_no NUMBER(8) CONSTRAINT pk_eco_ami PRIMARY KEY,
    ami_nom VARCHAR2(30),
		ami_pre VARCHAR2(30),
		ami_mai VARCHAR2(50)		
);
-- ====================================================
-- Table : eco_FAVORIS
-- ====================================================
--CREATE TABLE eco_favoris (
--		fav_no NUMBER(8) CONSTRAINT pk_eco_favoris PRIMARY KEY
--);
-- ====================================================
-- Table : eco_RECETTE
-- ====================================================
CREATE TABLE eco_recette (
    rec_no NUMBER(8) CONSTRAINT pk_eco_recette PRIMARY KEY,
		rec_nom VARCHAR2(50),
		rec_the VARCHAR2(20),
		rec_cou NUMBER(8),
		rec_dif VARCHAR2(20),
		rec_tem NUMBER(8),
		rec_pre CLOB,
		rec_ima BLOB,
    rec_fav NUMBER(1)
		--fav_no NUMBER(8) CONSTRAINT fk_eco_recette_eco_favoris REFERENCES eco_favoris (fav_no)
);
-- ====================================================
-- Table : eco_INGREDIENT
-- ====================================================
CREATE TABLE eco_ingredient (
		ing_no NUMBER(8) CONSTRAINT pk_eco_ingredient PRIMARY KEY,
    ing_nom VARCHAR2(30), 
		ing_ima BLOB  
);
-- ====================================================
-- Table : eco_ACHAT
-- ====================================================
CREATE TABLE eco_achat (
		ach_no NUMBER(8) CONSTRAINT pk_eco_achat PRIMARY KEY
);
-- ====================================================
-- Table : eco_COMPORTE
-- ====================================================
CREATE TABLE eco_comporte (
		rec_no NUMBER(8) NOT NULL CONSTRAINT fk_eco_comporte_eco_recette REFERENCES eco_recette (rec_no),
		ing_no NUMBER(8) NOT NULL CONSTRAINT fk_eco_comporte_eco_ingredient REFERENCES eco_ingredient (ing_no),
    com_qua VARCHAR2(50),
    CONSTRAINT pk_eco_comporte PRIMARY KEY (ing_no, rec_no)  
);
-- ====================================================
-- Table : eco_CONTIENT
-- ====================================================
CREATE TABLE eco_contient (
		ing_no NUMBER(8) NOT NULL CONSTRAINT fk_eco_contient_eco_ingredient REFERENCES eco_ingredient (ing_no),
		ach_no NUMBER(8) NOT NULL CONSTRAINT fk_eco_contient_eco_achat REFERENCES eco_achat (ach_no),
    con_qua VARCHAR2(50),
    CONSTRAINT pk_eco_contient PRIMARY KEY (ach_no, ing_no)    
);





 









