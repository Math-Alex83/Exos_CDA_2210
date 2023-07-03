
DROP TABLE IF EXISTS Cars;
DROP TABLE IF EXISTS Owners;
DROP TABLE IF EXISTS Brands;

CREATE TABLE Owners
(
	owner_id INT IDENTITY,
	owner_lastname VARCHAR(50) NOT NULL,
	owner_firstname VARCHAR(50) NOT NULL, 
	PRIMARY KEY (owner_id),
);

CREATE TABLE Brands
(
	brand_id INT IDENTITY (1,1),
	brand_name VARCHAR (50) NOT NULL,
	brand_slogan VARCHAR (255),
	PRIMARY KEY (brand_id),
);

CREATE TABLE Cars
(
	car_id INT IDENTITY,
	car_name VARCHAR (100) NOT NULL,
	car_registration CHAR (9) NOT NULL,
	car_owner_id INT,
	brand_id INT,
	PRIMARY KEY (car_id),
	
);

ALTER TABLE Cars

	ADD
	CONSTRAINT FK_car_owner_id 
	FOREIGN KEY (car_owner_id) 
	REFERENCES Owners(owner_id),

	CONSTRAINT FK_brand_id 
	FOREIGN KEY (brand_id) 
	REFERENCES Brands (brand_id);