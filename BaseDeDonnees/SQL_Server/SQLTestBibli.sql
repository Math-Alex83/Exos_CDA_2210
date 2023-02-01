use bibli_2210_akn;

/*
	DQL : Data Query Language
		SELECT
*/
-- Sélectionne
SELECT * FROM etats_livres;

SELECT * FROM etats_livres WHERE etat_id = 6;

SELECT * FROM etats_livres WHERE etat_id < 6 AND etat_id > 3;

SELECT * FROM etats_livres WHERE etat_id <> 5;

SELECT * FROM etats_livres WHERE etat_id =1 OR etat_id = 2 OR etat_id = 5;

SELECT * FROM etats_livres WHERE etat_id NOT IN (1,2,5); -- condition boolean NOT IN = (!IN)

SELECT * FROM etats_livres WHERE etat_id IN (1,2,5);

SELECT * FROM etats_livres WHERE etat_id BETWEEN 1 AND 4;

SELECT * FROM etats_livres WHERE etat_libelle LIKE '%b%'; -- LIKE '%b%' = qui contient la lettre b.

SELECT * FROM etats_livres WHERE etat_libelle LIKE '%a'; -- LIKE '%a' = qui se termine par la lettre a.

SELECT * FROM etats_livres WHERE etat_libelle LIKE 'n%'; -- LIKE 'n%' = qui commence par la lettre n.

SELECT * FROM etats_livres WHERE etat_libelle LIKE '%'; -- LIKE 'n%' = qui commence par la lettre n.
