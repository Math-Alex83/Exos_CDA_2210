--1. S�lectionner le nom et le num�ro d�immatriculation de toutes les voitures tri�es par immatriculation (ordre croissant).

SELECT car_id, car_name, car_registration 
FROM Cars 
ORDER BY car_id ASC
;
 --OK

/* 2. S�lectionner toutes les informations de toutes les voitures, incluant le nom de la marque ainsi que le nom et pr�nom du 
propri�taire. Trier la liste par nom de marque (ordre croissant) puis par nom de propri�taire (ordre croissant).*/

SELECT * 
FROM Brands -- OK avec auto-incr�mentation brand_id.

SELECT car_name, car_registration
FROM Cars
;
