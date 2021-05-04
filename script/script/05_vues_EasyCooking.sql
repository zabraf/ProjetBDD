-- ======================================================================
--  Script: 05_vues_EasyCooking.sql 
--  Objet : Création des vues schéma de la base EasyCooking
--  Objectif : créer des vues et tester l'interrogation et la mise-à-jour à travers ces vues. 
-- ======================================================================

-- ====================================================
-- Création des VUES
-- ====================================================
-- ====================================================
-- Vue d'affichage des amis
-- ====================================================
CREATE OR REPLACE VIEW vw_ami(Nom, Prénom, Adresse_Mail) AS
       SELECT ami_nom, ami_pre, ami_mai
       FROM eco_ami 
         ORDER BY ami_nom
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_ami TO EasyCooking_user;
-- ====================================================
-- Vue d'affichage des ingrédients
-- ====================================================
CREATE OR REPLACE VIEW vw_ingredient(Numero, Nom, Image) AS
       SELECT ing_no, ing_nom, ing_ima
       FROM eco_ingredient 
         ORDER BY ing_nom
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_ami TO EasyCooking_user;
-- ====================================================
-- Vue d'affichage des recettes 
--               + leurs ingrédients
--               + leur lien avec la liste de favoris
-- ====================================================
CREATE OR REPLACE VIEW vw_recette(Numero, Nom, Thème, Difficulté, Coût_frs, Temps_requis, Image, Préparation, Favoris, Ingrédient, Quantité) AS
       SELECT eco_recette.rec_no, rec_nom, rec_the, rec_dif, rec_cou, rec_tem, rec_ima, rec_pre, rec_fav, ing_nom, com_qua
       FROM eco_recette
       INNER JOIN eco_comporte ON eco_comporte.rec_no = eco_recette.rec_no 
       INNER JOIN eco_ingredient ON eco_ingredient.ing_no = eco_comporte.ing_no
      -- FULL JOIN eco_favoris ON eco_favoris.fav_no = eco_recette.fav_no
         ORDER BY rec_nom
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_ami TO EasyCooking_user;
-- ====================================================
-- Vue d'affichage de la liste d'achat
-- ====================================================
CREATE OR REPLACE VIEW vw_achat(Quantité, Produit) AS
       SELECT con_qua, ing_nom
       FROM eco_ingredient
       INNER JOIN eco_contient ON eco_contient.ing_no = eco_ingredient.ing_no
       INNER JOIN eco_achat ON eco_achat.ach_no = eco_contient.ach_no
         ORDER BY ing_nom
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_ami TO EasyCooking_user;


-- SELECT * FROM vw_ami;
-- SELECT * FROM vw_ingredient;
-- SELECT * FROM vw_recette;
-- SELECT * FROM vw_achat;
  
