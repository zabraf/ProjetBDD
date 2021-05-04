create or replace package pkg_insertBlob
AS
       PROCEDURE BlobInsert(nom_table IN VARCHAR, param_no IN NUMBER, BlobParam IN BLOB);
       FUNCTION BlobGet(nom_table IN VARCHAR, param_no IN NUMBER)RETURN BLOB;         
END pkg_insertBlob;
/
create or replace package body pkg_insertBlob
AS

PROCEDURE BlobInsert(nom_table IN VARCHAR, param_no IN NUMBER, BlobParam IN BLOB)
AS
BEGIN
          IF nom_table = 'eco_recette' THEN 
             UPDATE eco_recette SET rec_ima = BlobParam WHERE rec_no = param_no;
          ELSE 
             UPDATE eco_ingredient SET ing_ima = BlobParam WHERE ing_no = param_no;
          END IF;
END BlobInsert;

FUNCTION BlobGet(nom_table IN VARCHAR, param_no IN NUMBER)RETURN BLOB
AS
         v_image BLOB;
BEGIN
         IF nom_table = 'eco_recette' THEN
            SELECT rec_ima INTO v_image FROM eco_recette WHERE rec_no = param_no;
         ELSE
            SELECT ing_ima INTO v_image FROM eco_ingredient WHERE ing_no = param_no;
         END IF;
         RETURN v_image;
END BlobGet;
END pkg_insertBlob;
/
GRANT EXECUTE ON pkg_insertBlob TO role_EasyCooking_user;