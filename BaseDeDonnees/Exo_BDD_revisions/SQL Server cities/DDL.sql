
DROP TABLE IF EXISTS cities;
DROP TABLE IF EXISTS countries;

CREATE TABLE countries
(
	country_code CHAR(2) NOT NULL
	,country_name VARCHAR (100) NOT NULL
	,PRIMARY KEY (country_code)
);

CREATE TABLE cities
(
	city_id INT IDENTITY
	, city_name VARCHAR (100) NOT NULL
	, country_code CHAR(2) NOT NULL
	,PRIMARY KEY (city_id)
);

ALTER TABLE cities
ADD
CONSTRAINT FK_cities FOREIGN KEY (country_code) 
REFERENCES countries(country_code);