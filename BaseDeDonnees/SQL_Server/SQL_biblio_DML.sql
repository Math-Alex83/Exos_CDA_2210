use bibli_2210_akn;

/*
	DML : Data Modeling Language
		INSERT : ins�rer des donn�es dans la table
		UPDATE : modifier des donn�es existantes dans une table
		DELETE : suprimer des donn�es d'une table
		TRUNCATE : vider une table et r�initialiser les compteurs (auto incr�ment)
*/
-- vider une table et r�initialiser les compteurs
--TRUNCATE TABLE editeurs;
--TRUNCATE TABLE auteurs;

-- Supprimer les donn�es d'une tables
-- les 2 instructions suivantes remplacent le TRANCATE (uniquement SQLSERVER)
DELETE FROM editeurs; -- Supprime toutes les donn�es de la table
DBCC CHECKIDENT('editeurs', RESEED, 0); -- r�initialise la colonne auto-incr�ment�e.

INSERT INTO editeurs
VALUES
('Mathieu')
,('Rody')
,('G�rard')
,('Fran�ois')
;


DELETE FROM auteurs; -- Supprime toutes les donn�es de la table
DBCC CHECKIDENT('auteurs', RESEED, 0); -- r�initialise la colonne auto-incr�ment�e.

INSERT INTO auteurs
(auteur_nom, auteur_prenom) -- plus de travail lors de la requette mais plus simple � comprendre
VALUES
('SAINT','Mathieu')
,('Devold�re','Mike')
;

/*
-- plus simple mais oblige � se rappeler de l'ordre d'insertion des informatios.
INSERT INTO auteurs
VALUES 
('Aknouche','Mathieu'); 
*/
DELETE FROM etats_livres; 
DBCC CHECKIDENT('etats_livres', RESEED, 0); -- r�initialise la colonne auto-incr�ment�e.

INSERT INTO etats_livres
(etat_libelle)
VALUES
('neuf') --1
,('tr�s bon')
,('moyen')
,('tr�s abim�')
,('c''est de la merde')
,('poubelle')
;

DELETE FROM livres; 
DBCC CHECKIDENT('livres', RESEED, 0); -- r�initialise la colonne auto-incr�ment�e.

INSERT INTO 















-- Mettre � jour un enregistrement
UPDATE auteurs 
SET auteur_nom='Jack' 
WHERE auteur_id = 2; 

UPDATE auteurs 
SET auteur_nom='Jacky&', auteur_prenom='Michel' 
WHERE auteur_id = 1; -- <>  veut dire "est diff�rent de"

SELECT * FROM editeurs;
SELECT * FROM auteurs;
