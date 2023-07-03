--1. Sélectionner le nom et le numéro d’immatriculation de toutes les voitures triées par immatriculation (ordre croissant).

SELECT car_id, car_name, car_registration 
FROM Cars 
ORDER BY car_id ASC
;
 --OK

/* 2. Sélectionner toutes les informations de toutes les voitures, incluant le nom de la marque ainsi que le nom et prénom du 
propriétaire. Trier la liste par nom de marque (ordre croissant) puis par nom de propriétaire (ordre croissant).*/

SELECT * 
FROM Brands -- OK avec auto-incrémentation brand_id.

SELECT car_name, car_registration
FROM Cars
;
