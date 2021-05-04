REM Fichier		: Installation.cmd
REM Objet		: Création de la BDD ChessChamp

mkdir .\Logs

REM Lancement du script 01_BDD_ChessChamp.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM/manager@XEPDB1 @%~dp0\01_BDD_ChessChamp.sql %~dp0
