
DROP TABLE IF EXISTS cars;
DROP TABLE IF EXISTS brands;
DROP TABLE IF EXISTS owners;

CREATE TABLE owners
(
	owner_id INT
	,owner_lastname VARCHAR (50) NOT NULL
	,owner_firstname VARCHAR (50) NOT NULL
	,PRIMARY KEY (owner_id)
);


CREATE TABLE brands
(
	brand_id INT 
	, brand_name VARCHAR (50) NOT NULL
	, brand_slogan VARCHAR(255)
	, PRIMARY KEY (brand_id)
);


CREATE TABLE cars
(
	car_id INT
	,car_name VARCHAR (100) NOT NULL
	,car_registration CHAR(9) NOT NULL
	,car_owner_id INT
	,brand_id INT
	,PRIMARY KEY (car_id)
);

ALTER TABLE cars
ADD
CONSTRAINT FK_cars_owner FOREIGN KEY (car_owner_id)
REFERENCES owners (owner_id),
CONSTRAINT FK_cars_brands FOREIGN KEY (brand_id)
REFERENCES brands (brand_id);

