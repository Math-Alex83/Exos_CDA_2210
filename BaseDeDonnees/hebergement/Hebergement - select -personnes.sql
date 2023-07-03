-- use Hebergement;

SELECT * FROM Personnes;

SELECT
personne_id AS 'identifiant', 
personne_nom AS 'son pr�nom',
personne_prenom AS 'son nom'
FROM Personnes;

-- ASC (ordre croissant)
-- DESC (ordre d�croissant)
SELECT * FROM Personnes ORDER BY personne_prenom ASC;
WHERE personne_ddn >= '2000-01-01' AND personne_ddn <= '2005-12-31';

SELECT FROM PersonnesWHERE personne_ddn BETWEEN '2000-01-01' AND '2005-12-31';