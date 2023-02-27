
DROP TABLE IF EXISTS cities;
DROP TABLE IF EXISTS countries;

CREATE TABLE countries 
(
	country_code CHAR(2),
	country_name VARCHAR(100) NOT NULL
	PRIMARY KEY (country_code)
);


CREATE TABLE cities
(
	city_id INT,
	city_name VARCHAR(100),
	country_code CHAR(2) NOT NULL
	PRIMARY KEY (city_id)
);

ALTER
