-- use hebergement

CREATE TABLE Roles
(
	role_id INT IDENTITY (1, 1),
	role_nom VARCHAR(25) NOT NULL UNIQUE
);

CREATE TABLE PERSONNES
(
	personne_id INT IDENTITY (1, 1),
	personne_nom VARCHAR(50)NOT NULL,
	personne_prenom VARCHAR(50)NOT NULL,
	personne_ddn DATE NOT NULL,
	role_id INT NOT NULL,
	PRIMARY KEY (personne_id)
);
ALTER TABLE Personnes
	ADD FOREIGN KEY (role_id) REFERENCES Roles(roles_id);

CREATE TABLE etats
(
	etat_id INT IDENTITY (1,1),
	etat_intitule VARCHAR (25),
);

-- ALTER TABLE etats ADD PRIMARY KEY (etat_id);
ALTER TABLE etats ADD CONSTRAINT PK_etats PRIMARY KEY (etat_id);
-- ALTER TABLE etats DROP CONSTRAINT PK_etats;

