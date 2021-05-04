-- ====================================================================
-- Script : 04_insertions_EasyCooking.sql
-- Objet  : Insertions de données sur les tables EasyCooking 
-- ====================================================================
-- ====================================================
-- Insertion Table : eco_AMI
-- ====================================================
INSERT INTO eco_ami VALUES (1, 'Dupont', 'Jean', 'dupont86@gmail.com');
INSERT INTO eco_ami VALUES (2, 'Sinclair', 'François', 'sinclair@bluewin.ch');
INSERT INTO eco_ami VALUES (3, 'Blaise', 'Pascal', 'blaise345@caramail.com');
INSERT INTO eco_ami VALUES (4, 'Coste', 'Jeanne', 'costej@msn.com');
INSERT INTO eco_ami VALUES (5, 'Schmidt', 'Pascal', 'pascals@hotmail.com');
INSERT INTO eco_ami VALUES (6, 'Martin', 'Elodie', 'elodie.martin@gmail.com');
INSERT INTO eco_ami VALUES (7, 'Nicolet', 'Anne', 'nico.anne@caramail.com');
INSERT INTO eco_ami VALUES (8, 'Bergeret', 'Laurent', 'laurent456@gmail.com');
INSERT INTO eco_ami VALUES (9, 'Ingold', 'Samuel', 'samingold@bluewin.ch');
INSERT INTO eco_ami VALUES (10, 'Maret', 'Alexandre', 'alex.maret@gmai.com');

COMMIT;
-- ====================================================
-- Insertion Table : eco_INGREDIENT
-- ====================================================
INSERT INTO eco_ingredient VALUES (1, 'beurre', NULL);
INSERT INTO eco_ingredient VALUES (2, 'carotte', NULL);
INSERT INTO eco_ingredient VALUES (3, 'farine', NULL);
INSERT INTO eco_ingredient VALUES (4, 'huile', NULL);
INSERT INTO eco_ingredient VALUES (5, 'lait', NULL);
INSERT INTO eco_ingredient VALUES (6, 'penne', NULL);
INSERT INTO eco_ingredient VALUES (7, 'petit-pois', NULL);
INSERT INTO eco_ingredient VALUES (8, 'poivre', NULL);
INSERT INTO eco_ingredient VALUES (9, 'riz-blanc', NULL);
INSERT INTO eco_ingredient VALUES (10, 'sel', NULL);
INSERT INTO eco_ingredient VALUES (11, 'tomate', NULL);
INSERT INTO eco_ingredient VALUES (12, 'vin rouge', NULL);
INSERT INTO eco_ingredient VALUES (13, 'pecorino', NULL);
INSERT INTO eco_ingredient VALUES (14, 'vin blanc', NULL);
INSERT INTO eco_ingredient VALUES (15, 'ail', NULL);
INSERT INTO eco_ingredient VALUES (16, 'oignon', NULL);
INSERT INTO eco_ingredient VALUES (17, 'blanc de poulet', NULL);
INSERT INTO eco_ingredient VALUES (18, 'calamar', NULL);
INSERT INTO eco_ingredient VALUES (19, 'chorizo', NULL);
INSERT INTO eco_ingredient VALUES (20, 'citron', NULL);
INSERT INTO eco_ingredient VALUES (21, 'coriandre', NULL);
INSERT INTO eco_ingredient VALUES (22, 'crème-fraîche', NULL);
INSERT INTO eco_ingredient VALUES (23, 'cumin', NULL);
INSERT INTO eco_ingredient VALUES (24, 'noix de muscade', NULL);
INSERT INTO eco_ingredient VALUES (25, 'épinard', NULL);
INSERT INTO eco_ingredient VALUES (26, 'pomme de terre', NULL);
INSERT INTO eco_ingredient VALUES (27, 'fjord', NULL);
INSERT INTO eco_ingredient VALUES (28, 'huile d´olive', NULL);
INSERT INTO eco_ingredient VALUES (29, 'spaghetti', NULL);
INSERT INTO eco_ingredient VALUES (30, 'curry', NULL);
INSERT INTO eco_ingredient VALUES (31, 'lard', NULL);
INSERT INTO eco_ingredient VALUES (32, 'noix de coco', NULL);
INSERT INTO eco_ingredient VALUES (33, 'oeuf', NULL);
INSERT INTO eco_ingredient VALUES (34, 'parmesan', NULL);
INSERT INTO eco_ingredient VALUES (35, 'basilic', NULL);


COMMIT;

-- ====================================================
-- Insertion Table : eco_FAVORIS
-- ====================================================
--INSERT INTO eco_favoris VALUES (1);

--COMMIT;
-- ====================================================
-- Insertion Table : eco_RECETTE
-- ====================================================
INSERT INTO eco_recette VALUES (1, 'Gratin de pâtes aux épinards', 'Standard', 9 , 'Facile', 60 , 
'Faites cuire les pâtes dans un grand volume d’eau bouillante salée le temps indiqué sur le paquet. Les pâtes doivent être al dente. Égouttez et réservez.
Lavez et équeutez les épinards, faites-les cuire à l’eau bouillante salée pendant 10 min. Égouttez-les à fond en les pressant entre les mains. Coupez-les grossièrement à l’aide d’un couteau. Mélangez les épinards et les pâtes cuites. Beurrez un plat à gratin, étalez le mélange épinards-pâtes.
Allumez le four à 180°.Dans une casserole faites fondre la moitié du beurre , saupoudrez de farine , laissez cuire 3 min en mélangeant, puis délayez avec le lait. Salez, poivrez, ajoutez un peu de noix muscade.
Versez sur le mélange épinards-pâtes. Parsemez de chapelure et du reste de beurre coupé en petits morceaux et enfournez. Laissez cuire 15 min. Le dessus du gratin doit être brun.
Laissez refroidir et démoulez. Servez en parts individuelles accompagnées de mesclun. On peut ajouter 80 g de pignons ou de noisettes en poudre à ce gratin à la fin de la béchamel.' 
, NULL, 0);

INSERT INTO eco_recette VALUES (2, 'Penne aux calamars et aux tomates', 'Méditerranéen', 17, 'Dificille', 55, 
'Mettez les calamars dans une sauteuse. Arrosez-les d’huile et faites chauffer à feu vif 10 minutes en remuant de temps en temps.
Pendant ce temps, pelez et hachez l’ail.
Ajoutez l’ail dans la sauteuse, couvrez, baissez le feu et poursuivez la cuisson 15 minutes.
Faites cuire les pâtes dans l’eau bouillante salée le temps indiqué sur le paquet.
Lavez les tomates et coupez-les en petits dés.
Lavez, séchez, effeuillez et ciselez le basilic.
Egouttez les pâtes et ajoutez les dans la sauteuse quand le temps de cuisson des calamars est arrivé à son terme.
Mélangez bien, ajoutez les tomates et le basilic, rectifiez l’assaisonnement. Mélangez et retirez du feu. Servez aussitôt.'
, NULL, 0);

INSERT INTO eco_recette VALUES (3, 'Spaghetti à la carbonara', 'Méditerranéen', 10, 'Moyen', 30, 
'Portez à ébullition 3 l d’eau, additionnée d’une c. à café et demie de sel et d’une c. à soupe d’huile. Plongez-y les spaghettis, défaites-les délicatement à la fourchette et faites-les cuire al dente, pendant 8 min environ. Egouttez-les ensuite dans une passoire.
Taillez le lard en fines lanières. Pelez les gousses d’ail et coupez-les en quatre, dans leur longueur. Faites revenir l’ail dans l’huile d’olive. Retirez ensuite l’ail de la poêle pour lui substituer le lard, que vous laissez dorer pendant quelques minutes. Cassez les oeufs dans un plat creux chaud. Battez-les avec la crème fraîche. Ajoutez-y le fromage. Salez et poivrez.
Ajoutez les spaghettis au lard, dans la poêle, sur feu doux. Laissez-les chauffer pendant quelques minutes. Versez les pâtes et le lard dans le plat creux. Mélangez le tout. Servez aussitôt.'
, NULL, 0);

INSERT INTO eco_recette VALUES (4, 'Curry de poulet en crumble', 'Asiatique', 20, 'Moyen', 130, 
'Préchauffez le four Th7 (200°C)
Détaillez les blancs de poulet en lanières. Versez dans un plat creux, salez, poivrez et saupoudrez de curry et de cumin.
Ajoutez le Fjord, le jus de citron et les feuilles de coriandre ciselées. Placez au froid pendant 1 heure.
Pendant ce temps, préparez la pâte à crumble en versant le beurre mou, la farine, le parmesan et la noix de coco râpée dans un saladier. Malaxez le tout du bout des doigts pour obtenir une pâte homogène et “sableuse”. Conservez au froid.
Éliminez les tiges vertes des oignons pour n’en conserver que quelques centimètres et coupez les oignons nouveaux en deux ou en quatre selon leur taille. Metez une poêle à chauffer avec un filet d’huile d’olive et faites revenir les oignons jusqu’à ce qu’ils soient légèrement translucides.
Mélangez les oignons au poulet et versez dans un plat à gratin. Recouvrez de pâte en l’émiettant sur le dessus du
bout des doigts.
Enfournez et laissez cuire 40 min.
Servez chaud.' 
, NULL, 1);

INSERT INTO eco_recette VALUES (5, 'Tortilla à l´espagnole', 'Méditerranéen', 8, 'Facile', 30, 
'Epluchez les pommes de terre et les oignons et découpez-les en fines rondelles.
Coupez le chorizo en rondelles.
Dans une grande poêle, mettez l´huile d´olive et faites frire les pommes de terre et les oignons, sans les faire bruler mais jusqu´à ce qu´ils deviennent fondants.
Jetez le trop plein d´huile, ajoutez le chorizo et faites revenir.
Pendant ce temps, battez les oeufs, salez et poivrez.
Egouttez bien les pommes de terre et le chorizo et mélangez-les aux oeufs puis versez le tout dans la poêle et faites cuire le tout 5 min. Puis retournez délicatement l´omelette en vous servant d´une grande assiette, puis faites-la glisser à nouveau dans la poêle et laissez cuire 3 min.
Rectifiez l´assaisonnement et servez.'
,NULL, 1);

COMMIT;

-- ====================================================
-- Insertion Table : eco_COMPORTE
-- ====================================================
INSERT INTO eco_comporte VALUES (1, 25, '1 kilo');
INSERT INTO eco_comporte VALUES (1, 6, '500 grammes');
INSERT INTO eco_comporte VALUES (1, 1, '60 grammes');
INSERT INTO eco_comporte VALUES (1, 5, '1 demi-litre');
INSERT INTO eco_comporte VALUES (1, 3, '2 cuillères à soupe');
INSERT INTO eco_comporte VALUES (1, 24, ' ');
INSERT INTO eco_comporte VALUES (1, 10, ' ');
INSERT INTO eco_comporte VALUES (1, 8, ' ');

INSERT INTO eco_comporte VALUES (2, 6, '500 grammes');
INSERT INTO eco_comporte VALUES (2, 29, '150 grammes');
INSERT INTO eco_comporte VALUES (2, 18, '900 grammes');
INSERT INTO eco_comporte VALUES (2, 11, '6');
INSERT INTO eco_comporte VALUES (2, 15, '3 gousses');
INSERT INTO eco_comporte VALUES (2, 35, '5 tiges');
INSERT INTO eco_comporte VALUES (2, 28, '6 cuillères à soupe');
INSERT INTO eco_comporte VALUES (2, 10, ' ');
INSERT INTO eco_comporte VALUES (2, 8, ' ');

INSERT INTO eco_comporte VALUES (3, 29, '500 grammes');
INSERT INTO eco_comporte VALUES (3, 31, '50 grammes');
INSERT INTO eco_comporte VALUES (3, 13, '50 grammes');
INSERT INTO eco_comporte VALUES (3, 33, '2');
INSERT INTO eco_comporte VALUES (3, 15, '2 gousses');
INSERT INTO eco_comporte VALUES (3, 4, '1 cuillère à soupe');
INSERT INTO eco_comporte VALUES (3, 28, '1 cuillère à soupe');
INSERT INTO eco_comporte VALUES (3, 22, '4 cuillères à soupe');
INSERT INTO eco_comporte VALUES (3, 10, ' ');
INSERT INTO eco_comporte VALUES (3, 8, ' ');

INSERT INTO eco_comporte VALUES (4, 17, '500 grammes');
INSERT INTO eco_comporte VALUES (4, 27, '1 pot');
INSERT INTO eco_comporte VALUES (4, 16, '1 botte');
INSERT INTO eco_comporte VALUES (4, 20, 'jus d´un demi citron');
INSERT INTO eco_comporte VALUES (4, 30, '1 cuillère à café');
INSERT INTO eco_comporte VALUES (4, 23, 'une demi cuillère à café');
INSERT INTO eco_comporte VALUES (4, 21, 'une demi botte');
INSERT INTO eco_comporte VALUES (4, 28, '1 cuillère à soupe');
INSERT INTO eco_comporte VALUES (4, 1, '50 grammes');
INSERT INTO eco_comporte VALUES (4, 34, '75 grammes');
INSERT INTO eco_comporte VALUES (4, 3, '50 grammes');
INSERT INTO eco_comporte VALUES (4, 32, '50 grammes');
INSERT INTO eco_comporte VALUES (4, 10, ' ');
INSERT INTO eco_comporte VALUES (4, 8, ' ');

INSERT INTO eco_comporte VALUES (5, 33, '8');
INSERT INTO eco_comporte VALUES (5, 35, '4');
INSERT INTO eco_comporte VALUES (5, 16, '1 gros');
INSERT INTO eco_comporte VALUES (5, 19, '1');
INSERT INTO eco_comporte VALUES (5, 28, '6 cuillères à soupe');
INSERT INTO eco_comporte VALUES (5, 10, ' ');
INSERT INTO eco_comporte VALUES (5, 8, ' ');

-- ====================================================
-- Insertion Table : eco_ACHAT
-- ====================================================
INSERT INTO eco_achat VALUES (1);

COMMIT;
-- ====================================================
-- Insertion Table : eco_CONTIENT
-- ====================================================
INSERT INTO eco_contient VALUES (33, 1, '10');
INSERT INTO eco_contient VALUES (20, 1, '5');
INSERT INTO eco_contient VALUES (16, 1, '5');
INSERT INTO eco_contient VALUES (28, 1, '1 bouteille');
INSERT INTO eco_contient VALUES (11, 1, '8');

COMMIT;

-- SELECT * FROM eco_recette;
-- SELECT * FROM eco_contient;
-- SELECT * FROM eco_comporte;
-- SELECT * FROM eco_ingredient;
-- SELECT * FROM eco_ami;
-- SELECT * FROM eco_favoris;
















