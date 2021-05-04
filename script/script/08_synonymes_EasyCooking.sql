-- ======================================================================
--  Script: 07_synonymes_EasyCooking.sql 
--  Objet : Création des synonymes de la base EasyCooking 
-- ======================================================================

CREATE OR REPLACE SYNONYM EasyCooking_user.vw_ami FOR EasyCooking_data.vw_ami;
CREATE OR REPLACE SYNONYM EasyCooking_user.vw_ingredient FOR EasyCooking_data.vw_ingredient;
CREATE OR REPLACE SYNONYM EasyCooking_user.vw_recette FOR EasyCooking_data.vw_recette;
CREATE OR REPLACE SYNONYM EasyCooking_user.vw_achat FOR EasyCooking_data.vw_achat;
CREATE OR REPLACE SYNONYM EasyCooking_user.pkg_insert_Blob FOR EasyCooking_data.pkg_insertBlob;

CREATE OR REPLACE SYNONYM EasyCooking_user.sq_recette FOR EasyCooking_data.sq_recette;
CREATE OR REPLACE SYNONYM EasyCooking_user.sq_ingredient_Blob FOR EasyCooking_data.sq_ingredient;
CREATE OR REPLACE SYNONYM EasyCooking_user.sq_ami FOR EasyCooking_data.sq_ami;