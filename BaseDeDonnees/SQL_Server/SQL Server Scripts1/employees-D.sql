-- use employees;

/* 1. S�lectionner le nom, pr�nom et salaire de tous les employ�s tri�s 
	par date d�embauche de la plus ancienne � la plus r�cente.*/

SELECT emp_lastname, emp_firstname, emp_salary, emp_hiredate FROM employees
ORDER BY emp_hiredate ASC;

/*2. S�lectionner le nom, salaire, date d�embauche de tous les employ�s tri�s 
	par identifiant de manager (croissant) puis par nom (ordre alphab�tique).*/

SELECT emp_lastname, emp_salary, emp_hiredate, emp_manager_id FROM employees
ORDER BY emp_manager_id ASC, emp_lastname ASC;

/*3. S�lectionner le nom, pr�nom, salaire, date d�embauche, 
	nom et pr�nom du manager de tous les employ�s. Trier la liste par 
	nom de manager (ordre croissant) puis par date d�embauche de la plus r�cente � la plus ancienne.*/

SELECT  
Emp1.emp_lastname,
Emp1.emp_firstname,
Emp1.emp_salary, 
Emp1.emp_hiredate, 
Emp1.emp_manager_id,
Emp2.emp_id AS 'Manager id',
Emp2.emp_lastname AS 'Manager Last name',
Emp2.emp_firstname AS 'Manager First name'
FROM employees AS Emp1 LEFT JOIN employees AS Emp2 ON Emp1.emp_manager_id = Emp2.emp_id
ORDER BY Emp2.emp_lastname ASC, Emp1.emp_hiredate DESC;

/*4. S�lectionner les employ�s sans manager.*/

SELECT * FROM employees WHERE emp_manager_id IS NULL;

/*5. S�lectionner le pr�nom et nom de tous les managers avec, pour chacun, 
	le nombre de leur subordonn�s. 
		Les managers avec le moins de subordonn�s apparaissent en 1er.*/

SELECT 
Man1.emp_lastname,
Man1.emp_firstname,
COUNT(Emp1.emp_id) as 'Manager count'
FROM employees as Man1
JOIN employees as Emp1 ON Man1.emp_id = Emp1.emp_manager_id
GROUP BY
Man1.emp_lastname,
Man1.emp_firstname
ORDER BY
'Manager count' ASC;

/*
SELECT COUNT (*)
FROM employees
WHERE employees.emp_manager_id = 5;
*/


/* 6. S�lectionner le nom de tous les managers avec, pour chacun, la moyenne des salaires de leur subordonn�s. 	Trier le r�sultat selon la valeur de la moyenne par ordre d�croissant. */--SELECT