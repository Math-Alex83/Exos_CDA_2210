-- use employees

DROP TABLE IF EXISTS employees;

CREATE TABLE employees
(
	emp_id INT IDENTITY,
	emp_lastname VARCHAR (50) NOT NULL,
	emp_firstname VARCHAR (50)NOT NULL,
	emp_salary INT NOT NULL,
	emp_hiredate DATE NOT NULL,
	emp_manager_id INT

);

ALTER TABLE employees
	ADD CONSTRAINT PK_emp PRIMARY KEY (emp_id), 
	CONSTRAINT FK_emp FOREIGN KEY (emp_manager_id) REFERENCES employees(emp_id);

INSERT INTO employees
(emp_manager_id,emp_lastname,emp_firstname,emp_salary,emp_hiredate)
VALUES
(NULL,'Holems', 'Cathy' ,100000, '2010-01-09')
,( 1, 'Mannheim', 'Luc', 87500, '2017-06-17')
,( 2, 'Kipr�', 'Abdou' ,42800 ,'2017-10-09')
,( 2, 'Martin', 'Val�rie', 39500, '2018-03-30')
,( 1, 'Slezak', 'Daniel', 75000 ,'2011-09-09')
,( 5, 'Bahl', 'Tarik', 60000, '2014-04-08')
,( 5, 'Armanetti', 'Micha�l', 60000, '2014-05-06')
,( 5, 'Goldman' ,'Estelle', 55000, '2016-04-20')
,( 5, 'Durand', 'Gabriel', 55000 ,'2016-12-02')
,( 8, 'Morel', 'Audrey', 46500, '2012-07-01')
,( 8, 'Carpentier', 'Guillaume', 58500, '2010-02-03')
,( 9, 'Lefebvre', 'Hugo', 42000, '2015-10-11')
,( 9, 'Sharif', 'Sonia', 54500, '2011-01-23')
,( 15, 'Fournier', 'Sabrina', 42000, '2017-10-27')
,( 5, 'Bower', 'Sarah', 49500, '2018-05-22')
,( 8, 'Dimario', 'Jordan' ,32500, '2019-06-30')
,( 9, 'Macdowel', 'Cindy', 32500, '2019-11-04')

