use bibli_2210_akn;

/*
	DML : Data Modeling Language
		INSERT : insérer des données dans la table
		UPDATE : modifier des données existantes dans une table
		DELETE : suprimer des données d'une table
		TRUNCATE : vider une table et réinitialiser les compteurs (auto incrément)
*/
-- vider une table et réinitialiser les compteurs
--TRUNCATE TABLE editeurs;
--TRUNCATE TABLE auteurs;

-- Supprimer les données d'une tables
-- les 2 instructions suivantes remplacent le TRANCATE (uniquement SQLSERVER)
DELETE FROM editeurs; -- Supprime toutes les données de la table
DBCC CHECKIDENT('editeurs', RESEED, 0); -- réinitialise la colonne auto-incrémentée.

INSERT INTO editeurs
VALUES
('Mathieu')
,('Rody')
,('Gérard')
,('François')
;


DELETE FROM auteurs; -- Supprime toutes les données de la table
DBCC CHECKIDENT('auteurs', RESEED, 0); -- réinitialise la colonne auto-incrémentée.

INSERT INTO auteurs
(auteur_nom, auteur_prenom) -- plus de travail lors de la requette mais plus simple à comprendre
VALUES
('SAINT','Mathieu')
,('Devoldère','Mike')
;

/*
-- plus simple mais oblige à se rappeler de l'ordre d'insertion des informatios.
INSERT INTO auteurs
VALUES 
('Aknouche','Mathieu'); 
*/
DELETE FROM etats_livres; 
DBCC CHECKIDENT('etats_livres', RESEED, 0); -- réinitialise la colonne auto-incrémentée.

INSERT INTO etats_livres
(etat_libelle)
VALUES
('neuf') --1
,('très bon')
,('moyen')
,('très abimé')
,('c''est de la merde')
,('poubelle')
;

DELETE FROM livres; 
DBCC CHECKIDENT('livres', RESEED, 0); -- réinitialise la colonne auto-incrémentée.

INSERT INTO 















-- Mettre à jour un enregistrement
UPDATE auteurs 
SET auteur_nom='Jack' 
WHERE auteur_id = 2; 

UPDATE auteurs 
SET auteur_nom='Jacky&', auteur_prenom='Michel' 
WHERE auteur_id = 1; -- <>  veut dire "est différent de"

SELECT * FROM editeurs;
SELECT * FROM auteurs;
