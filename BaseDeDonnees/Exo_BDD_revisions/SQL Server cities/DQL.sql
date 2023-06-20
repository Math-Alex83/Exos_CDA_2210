-- 1. S�lectionner le nom de toutes les villes

SELECT city_name FROM cities;

-- 2. S�lectionner l�identifiant et le nom de toutes les villes tri�es par nom de ville et par ordre alphab�tique.

SELECT city_id, city_name 
	FROM cities
		ORDER BY city_name ASC;

-- 3. S�lectionner toutes les villes avec le nom du pays associ� � chaque ville. Trier la liste par code pays et par ordre alphab�tique inverse.

SELECT 
city_name as Villes
,country_name as 'Nom du pays' 
,countries.country_code as 'Code iso du pays' 
FROM cities JOIN countries ON countries.country_code = cities.country_code 
ORDER BY countries.country_code DESC;

-- 4. S�lectionner le code ISO et le nom de tous les pays avec le nombre de villes par pays. Les pays avec le moins de villes apparaissent en 1er.SELECTcountries.country_code as 'code ISO du pays',country_name as 'Nom du pays',COUNT (cities.city_id) as 'nbr de villes/pays'FROM countries JOIN cities ON countries.country_code = cities.country_codeGROUP BY countries.country_code,country_name;SELECTCOUNT (*) as 'nbrs de villes'FROM cities WHERE cities.country_code = 'FR';