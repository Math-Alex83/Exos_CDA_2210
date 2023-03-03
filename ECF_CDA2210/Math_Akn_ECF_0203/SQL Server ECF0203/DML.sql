-- INSERT INTO, UPDATE, DELETE

INSERT INTO products
(product_id, product_name, product_value)
VALUES
(1, 'Raysen 3 3200G', 124)
, (2,'Raysen 3 4100', 133)
, (3,'Raysen 5 PRO', 219)
, (4,'Raysen 5 5600', 289)
, (5,'Raysen 7 5700X', 369)
, (6,'Raysen 7 5800', 579)
, (7,'Raysen 9 5950X', 759)
;

INSERT INTO production_lines
(line_id, line_label, product_id)
VALUES
('R3A', 'Ryzen LEGACY',1)
,('R3B','Ryzen MID',2)
,('R5A','Ryzen PRO',3)
,('R5B','Ryzen PRISM',4)
,('R7A','Ryzen XCOM',5)
,('R7B','Ryzen XD3',6)
,('R9Z','Ryzen LATEST',7)
;

INSERT INTO production_done
(forge_id,product_id, line_id, forge_date ,forge_quantity)
VALUES
(3142, 1,'R3A' ,'2022-04-29', 27)
,(3143,2 ,'R5A' ,'2022-04-29', 31)
,(3144,3 ,'R5A' ,'2022-05-02', 34)
,(3145,4 ,'R5B' ,'2022-05-02', 16)
;