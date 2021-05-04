-- ====================================================================
-- Script : 02_utilisateurs_ChampChess.sql
-- Objet  : Création des utilisateurs BDD ChampChess sur SGBD Oracle en Local (HEGLOCAL)
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     GA   26.03.07    Création utilisateurs
-- ====================================================================
-- =============================================================================================
-- Suppression des roles, utilisateurs et profil
-- =============================================================================================
-- Suppression des utilisateurs
DROP USER ChampChess_data CASCADE;
DROP USER ChampChess_user CASCADE;

-- Suppression des roles
DROP ROLE role_ChampChess_data;
DROP ROLE role_ChampChess_user;

-- Suppression du profil
DROP PROFILE ChampChess_profil;

-- =============================================================================================
-- Création du profil
-- =============================================================================================
-- Creation du profil ChampChess_profil
CREATE PROFILE ChampChess_profil LIMIT
	SESSIONS_PER_USER 3
	FAILED_LOGIN_ATTEMPTS 3 
	PASSWORD_LOCK_TIME 1/24
	PASSWORD_LIFE_TIME 180 
	PASSWORD_REUSE_TIME 180 
	PASSWORD_REUSE_MAX UNLIMITED
	PASSWORD_GRACE_TIME 7;

-- =============================================================================================
-- Création du role role_ChampChess_data (role de l'utilisateur propriétaire des objets de la base)
-- =============================================================================================
-- Creation du role role_EasyCooking_data
CREATE ROLE role_ChampChess_data;

-- droit de se connecter à la BDD
GRANT CONNECT TO role_ChampChess_data;

-- droit de créer des triggers, séquence, tables, packages, ...
GRANT RESOURCE TO role_ChampChess_data;

-- droit de créer des vues
GRANT CREATE VIEW TO role_ChampChess_data;

-- droit de créer des synonymes
-- GRANT CREATE ANY SYNONYM TO role_ChampChess_data;
-- ! fonctionne mais donne trop de privilèges, à éviter

-- ===============================
-- Création du role role_ChampChess_user (role de l'utilisateur de l'application)
-- ===============================
-- Creation du role role_ChampChess_user
CREATE ROLE role_ChampChess_user;

-- droit de se connecter à la BDD
GRANT CREATE SESSION TO role_ChampChess_user;

-- ===================================
-- Cr�ation de l'utilisateur ChampChess_data (propri�taire des objets de sch�ma de la base)
-- ===================================
-- Creation de l'utilisateur ChampChess_data 
CREATE USER ChampChess_data
	PROFILE ChampChess_profil
	IDENTIFIED BY ChampChess_data
	DEFAULT TABLESPACE USERS
	TEMPORARY TABLESPACE TEMP
;
GRANT role_ChampChess_data TO ChampChess_data;
ALTER USER ChampChess_data quota unlimited ON USERS;

--===================================
--Création de l'utilisateur ChampChess_user (utilisateur de l'application)
--===================================
CREATE USER ChampChess_user
	PROFILE ChampChess_profil
	IDENTIFIED BY ChampChess_user
;
GRANT role_ChampChess_user TO EChampChess_user;
