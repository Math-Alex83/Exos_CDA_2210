-- CREATE, DROP, ALTER

DROP TABLE IF EXISTS production_done;
DROP TABLE IF EXISTS production_lines;
DROP TABLE IF EXISTS products;

CREATE TABLE products
(
	product_id INT NOT NULL
	, product_name VARCHAR(128) NOT NULL
	, product_value INT NOT NULL
	, PRIMARY KEY (product_id) 
);

CREATE TABLE production_lines
(
	line_id CHAR(3) NOT NULL
	, line_label VARCHAR (50) NOT NULL
	, product_id INT NOT NULL
	, PRIMARY KEY (line_id)
);

CREATE TABLE production_done
(
	forge_id INT NOT NULL
	, forge_date DATE NOT NULL
	, forge_quantity INT NOT NULL
	, product_id INT NOT NULL
	, line_id CHAR(3) NOT NULL
	, PRIMARY KEY (forge_id)
);

ALTER TABLE production_lines
ADD 
CONSTRAINT FK_product_id_1 FOREIGN KEY (product_id) REFERENCES products (product_id);

ALTER TABLE production_done
ADD
CONSTRAINT FK_product_id_2 FOREIGN KEY (product_id) REFERENCES products (product_id),
CONSTRAINT FK_line_id FOREIGN KEY (line_id) REFERENCES production_lines (line_id);