-- 1. Employee Address
SELECT e.employee_id,e.job_title,e.address_id,a.address_text FROM employees AS e
INNER JOIN addresses AS a
ON e.address_id = a.address_id
ORDER BY address_id ASC
LIMIT 5;

-- 2. Addresses with Towns

SELECT e.first_name, e.last_name,t.name AS 'town',a.address_text FROM employees AS e
INNER JOIN addresses AS a
ON e.address_id = a.address_id
INNER JOIN towns AS t
ON a.town_id = t.town_id
ORDER BY e.first_name ASC, e.last_name
LIMIT 5;

-- 3.Sales Employee

SELECT e.employee_id,e.first_name,e.last_name,d.name AS 'department_name' FROM employees AS e
INNER JOIN departments AS d
ON e.department_id = d.department_id
AND d.name = 'Sales'
ORDER BY employee_id DESC;

-- 4. Employee Departments
SELECT e.employee_id,e.first_name,e.salary,d.name AS 'department_name' FROM employees AS e
INNER JOIN departments AS d
ON e.department_id = d.department_id
AND e.salary > 15000
ORDER BY e.department_id DESC
LIMIT 5;

-- 5. Employee Without Project

	SELECT e.employee_id, e.first_name FROM employees AS e
	LEFT OUTER JOIN employees_projects AS ep
	ON e.employee_id = ep.employee_id
	WHERE ep.project_id IS NULL
	ORDER BY e.employee_id DESC
	LIMIT 3;
    
    
-- 6.Employees Hired After

SELECT e.first_name,e.last_name, e.hire_date, d.name AS 'dept_name' FROM employees AS e
INNER JOIN departments AS d
ON e.department_id = d.department_id 
AND d.name IN ('Finance','Sales')
AND DATE(e.hire_date) > '1999/1/1'
ORDER BY e.hire_date;

-- 7. Employees with project
SELECT e.employee_id, e.first_name, p.name AS 'project_name' FROM employees AS e
INNER JOIN employees_projects AS ep
ON e.employee_id = ep.employee_id
INNER JOIN projects AS p
ON ep.project_id = p.project_id
AND DATE(p.start_date) > '2002/8/13' AND
p.end_date IS NULL
ORDER BY e.first_name ASC, p.name ASC
LIMIT 5;


-- 8. Employees 24
SELECT e.employee_id,e.first_name,
CASE
	WHEN YEAR(p.start_date) >= 2005 THEN NULL
    ELSE p.name
    END AS 'project_name'
 FROM employees AS e
INNER JOIN employees_projects AS ep
ON e.employee_id = ep.employee_id AND e.employee_id = 24
INNER JOIN projects AS p
ON ep.project_id = p.project_id
ORDER BY `project_name`;

-- 9. Employee Manager

SELECT e.employee_id, e.first_name,e.manager_id,m.first_name AS 'manager_name' FROM employees AS e
INNER JOIN employees AS m
ON  e.manager_id = m.employee_id
AND e.manager_id IN (3,7)
ORDER BY e.first_name ASC;

-- 10.Employee Summary

SELECT e.employee_id, CONCAT(e.first_name," ",e.last_name)AS employee_name,CONCAT(m.first_name," ",m.last_name) AS 'manager_name',d.name AS 'department_name'
FROM employees AS e
INNER JOIN employees AS m
ON e.manager_id = m.employee_id
INNER JOIN departments AS d
ON e.department_id = d.department_id
ORDER BY e.employee_id
LIMIT 5;

-- 11. Min Avg Salary

	-- first option
SELECT MIN(a.avg) AS 'min_average_salary' FROM(
      SELECT AVG(e.salary) AS 'avg' FROM employees AS e
	    GROUP BY e.department_id)   AS a;

	-- second option
SELECT AVG(e.`salary`) AS 'min_average_salary'
FROM `employees` AS e
GROUP BY e.`department_id`
ORDER BY min_average_salary
LIMIT 1;

-- DATABASE ''GEOGRAPHY''


-- 12. Highest Peaks In Bulgaria
SELECT c.country_code, m.mountain_range,p.peak_name, p.elevation FROM countries AS c
INNER JOIN mountains_countries AS mc
ON c.country_code = mc.country_code
AND c.country_code = 'BG'
INNER JOIN mountains AS m
ON mc.mountain_id = m.id
INNER JOIN peaks AS p
ON m.id = p.mountain_id
AND p.elevation > 2835
ORDER BY p.elevation DESC;

-- 13. Count Mountain Ranges
SELECT c.country_code, COUNT(mc.mountain_id) AS 'mountain_range'
FROM countries AS c
INNER JOIN mountains_countries AS mc
ON c.country_code = mc.country_code
WHERE c.country_name IN('United States', 'Russia', 'Bulgaria')
GROUP BY(c.country_code)
ORDER BY `mountain_range` DESC; 