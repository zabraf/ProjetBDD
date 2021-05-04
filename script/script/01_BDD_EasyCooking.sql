-- ====================================================================
-- Script : 01_ChampChess.sql
-- Objet  : Création BDD 01_ChampChess sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ---------------------------------------------
-- 1.0	     GA   28.04.21    Création
-- ====================================================================

SET ECHO ON
SET LINESIZE 200
SET PAGESIZE 60

-- Cràation des utilisateurs en tant que System
SPOOL .\Logs\02_utilisateurs_ChampChess.log
@.\02_utilisateurs_ChampChess.sql
SPOOL OFF

-- Connexion à HEGLOCAL en tant que ChampChess_data (propir�taires des objets de sch�ma)
CONNECT ChampChess_data/ChampChess_data@XEPDB1

-- Cr�ation des tables
SPOOL .\Logs\03_tables_ChampChess.log
@.\03_tables_ChampChess.sql
SPOOL OFF

-- Chargement des donn�es
SPOOL .\Logs\04_insertions_ChampChess.log
@.\04_insertions_ChampChess.sql;
SPOOL OFF

-- Cr�ation des vues
SPOOL .\Logs\05_vues_EasyCooking.log
@.\05_vues_EasyCooking.sql
SPOOL OFF

-- Cr�ation des triggers pour les clefs primaires
SPOOL .\Logs\06_triggers_EasyCooking.log
@.\06_triggers_EasyCooking.sql;
SPOOL OFF

-- Cr�ation des packages
SPOOL .\Logs\07_package_EasyCooking.log
@.\07_package_EasyCooking.sql;
SPOOL OFF

-- Connexion � HEGLOCAL en tant que system
CONNECT system/manager@XEPDB1

-- Cr�ation des synonymes
SPOOL .\Logs\08_synonymes_EasyCooking.log
@.\08_synonymes_EasyCooking.sql;
SPOOL OFF

SET ECHO OFF

EXIT;
