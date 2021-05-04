-- ====================================================================
-- Script : 06_triggers_EasyCooking.sql
-- Objet  : Création des triggers EasyCooking sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     GA   2.05.08    Création trigers
-- ====================================================================

-- ====================================================
-- Trigger Recette
-- ====================================================

 CREATE SEQUENCE   sq_recette  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 6 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_recette 
  before insert on eco_recette               
  for each row  
begin   
    select sq_recette.nextval into :NEW.rec_no from dual; 
end; 

/
ALTER TRIGGER  tr_recette ENABLE
/

-- ====================================================
-- Trigger Ingredient
-- ====================================================

 CREATE SEQUENCE   sq_ingredient MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 36 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_ingredient
  before insert on eco_ingredient              
  for each row  
begin   
    select sq_ingredient.nextval into :NEW.ing_no from dual; 
end; 

/
ALTER TRIGGER  tr_ingredient ENABLE
/
-- ====================================================
-- Trigger Ami
-- ====================================================

 CREATE SEQUENCE   sq_ami  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 11 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_ami 
  before insert on eco_ami              
  for each row  
begin   
    select sq_ami.nextval into :NEW.ami_no from dual; 
end; 

/
ALTER TRIGGER  tr_ami ENABLE
/












