REM Fichier		: BDD_EasyCooking.cmd
REM Objet		: Désinstallation de la BDD EasyCooking 

mkdir .\Logs

REM Lancement du script uninstall_EasyCooking.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM/manager@XEPDB1 @%~dp0\uninstall_EasyCooking.sql @%~dp0