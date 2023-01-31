/* 
commentaire multi lignes 
*/

-- Sélection de la base de donnée exemple => "use bibli_2210_akn;" puis saut de ligne et "Go;" 

/* 
DDL : (DATA DEFINITION LANGAGE)
	CREATE : créer une structure de donnée (TABLE , VUE ...)
	ALTER : Modifier une structure de donnée
	DROP : Supprimer une structure de donnée 
*/

/*
CREATE TABLE editeurs
(
	editeur_id INT PRIMARY KEY IDENTITY(1,1) -- SQLSERVER
	editeur_id INT PRIMARY KEY AUTO_INCREMENT -- MYSQL ou MariaDB
	editeur_id INT PRIMARY KEY SERIAL -- postgresql
	editeur_id INT PRIMARY KEY AUTOINCREMENT -- sqlite
);
*/
-- pour suprimer une table ancienne qui porte le même nom.
DROP TABLE IF EXISTS livres_auteurs;
DROP TABLE IF EXISTS livres;
DROP TABLE IF EXISTS etats_livres;
DROP TABLE IF EXISTS auteurs;
DROP TABLE IF EXISTS editeurs; 

-- Création des tables de données
CREATE TABLE editeurs
(
	editeur_id INT PRIMARY KEY IDENTITY(1,1),
	editeur_nom VARCHAR(100) NOT NULL -- Défault 'éditeur inconnu'
);

CREATE TABLE auteurs 
(
	auteur_id INT IDENTITY(1,1),
	auteur_nom VARCHAR(100) NOT NULL,
	auteur_prenom VARCHAR(100) NULL,
	PRIMARY KEY (auteur_id) -- Syntaxe recommandée
);

CREATE TABLE etats_livres
(
	etat_id INT IDENTITY(1,1),
	etat_libelle VARCHAR(50),
	PRIMARY KEY (etat_id)
);

CREATE TABLE livres
(
	livre_id INT IDENTITY(1,1),
	livre_isbn CHAR(17) NOT NULL,
	livre_titre VARCHAR(255) NOT NULL,
	livre_date_achat DATE NOT NULL DEFAULT CURRENT_TIMESTAMP, -- renvoie la date et l'heure actuel par default
	livre_etat_commantaire VARCHAR(1000) NULL,
	etat_id INT NOT NULL,
	editeur_id INT NOT NULL,
	PRIMARY KEY (livre_id),
	FOREIGN KEY (etat_id) REFERENCES etats_livres(etat_id),-- FOREIGN KEY clé étrangère
	CONSTRAINT FK_livres_editeur FOREIGN KEY (editeur_id) REFERENCES editeurs(editeur_id)
);

CREATE TABLE livres_auteurs
(
	auteur_id INT,
	livre_id INT,
	PRIMARY KEY (auteur_id, livre_id)
);

ALTER TABLE livres_auteurs
	ADD FOREIGN KEY (auteur_id) REFERENCES auteurs(auteur_id),
	CONSTRAINT FK_TOTO FOREIGN KEY (livre_id) REFERENCES livres(livre_id);

--ALTER TABLE auteursADD PRIMARY KEY (auteur_id);