-- use hebergement;

INSERT INTO Roles
(role_id)
VALUES
('ADMIN'), --1
('Directeur'), --2
('M�decin'), --3
('�ducateur'), --4
('R�sident'); --5

INSERT INTO Personnes
(
	personne_nom, personne_prenom, personne_ddn, role_id
)
VALUES
('DEV','Mike','1981-11-12', 1);