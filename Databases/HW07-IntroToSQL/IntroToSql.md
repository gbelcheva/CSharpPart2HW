## Structured Query Language (SQL)
### _Homework_

1.	What is SQL? What is DML? What is DDL? Recite the most important SQL commands.

    * SQL stands for Structured Query Language. It is used for querying databases - selecting, inserting, updating and deleting data.
    * DML stands for Data Manipulation Language. It is part of the SQL syntax that is used to manipulate the data. Sample commands: SELECT, INSERT, UPDATE, DELETE.
    * DDL stands for Data Definition Language. It is part of the SQL syntax that is used to manipulate the schema(design) of the database. Sample commands: CREATE, DROP, ALTER, GRANT, REVOKE.
    * Most important commands - SELECT, INSERT, UPDATE, DELETE

2.	What is Transact-SQL (T-SQL)?

    Transact-SQL is high-level extension of SQL. It is standardly used in MS SQL Server. Some of the extended features are if-statements, loops and exceptions. It allows writing stored procedures, triggers, etc.

3.	Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.

4.	Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

    ```SQL
    SELECT * 
    FROM TelerikAcademy.dbo.Departments
    ```


5.	Write a SQL query to find all department names.

    ```SQL
    SELECT d.Name 
    FROM TelerikAcademy.dbo.Departments d
    ```

6.	Write a SQL query to find the salary of each employee.

    ```SQL
    SELECT e.Salary 
    FROM TelerikAcademy.dbo.Employees e
    ```
    
7.	Write a SQL to find the full name of each employee.
    
    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name' 
    FROM TelerikAcademy.dbo.Employees e
    ```
    
8.	Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

    ```SQL
    SELECT e.FirstName + e.LastName + '@telerik.com' AS 'Full Email Addresses'
    FROM TelerikAcademy.dbo.Employees e
    ```
    
9.	Write a SQL query to find all different employee salaries.

    ```SQL
    SELECT DISTINCT e.Salary 
    FROM TelerikAcademy.dbo.Employees e
    ```
    
10.	Write a SQL query to find all information about the employees whose job title is Sales Representative.
    
    ```SQL
    SELECT *
    FROM TelerikAcademy.dbo.Employees e
    WHERE e.JobTitle = 'Sales Representative'
    ```
11.	Write a SQL query to find the names of all employees whose first name starts with "SA".

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name'
    FROM TelerikAcademy.dbo.Employees e
    WHERE e.FirstName LIKE 'Sa%'
    ```
    
12.	Write a SQL query to find the names of all employees whose last name contains "ei".

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name'
    FROM TelerikAcademy.dbo.Employees e
    WHERE e.LastName LIKE '%ai%'
    ```

13.	Write a SQL query to find the salary of all employees whose salary is in the range [2000030000].

    ```SQL
    SELECT e.Salary
    FROM TelerikAcademy.dbo.Employees e
    WHERE (20000 <= e.Salary) AND (e.Salary <= 30000)
    ```

14.	Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', e.Salary
    FROM TelerikAcademy.dbo.Employees e
    WHERE e.Salary IN (25000, 14000, 12500, 23600)
    ```
    
15.	Write a SQL query to find all employees that do not have manager.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', e.ManagerID
    FROM TelerikAcademy.dbo.Employees e
    WHERE e.ManagerID IS NULL
    ```
    
16.	Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', e.Salary
    FROM TelerikAcademy.dbo.Employees e
    WHERE e.Salary > 50000
    ORDER BY e.Salary DESC
    ```
    
17.	Write a SQL query to find the top 5 best paid employees.

    ```SQL
    SELECT TOP(5) e.FirstName + ' ' + e.LastName AS 'Full Name', e.Salary
    FROM TelerikAcademy.dbo.Employees e
    ORDER BY e.Salary DESC
    ```

18.	Write a SQL query to find all employees along with their address. Use inner join with `ON` clause.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', a.AddressText
    FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Addresses a
	ON e.AddressID = a.AddressID
    ```
    
19.	Write a SQL query to find all employees and their address. Use equijoins (conditions in the `WHERE` clause).

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', a.AddressText
    FROM TelerikAcademy.dbo.Employees e, TelerikAcademy.dbo.Addresses a
	WHERE e.AddressID = a.AddressID
    ```
    
20.	Write a SQL query to find all employees along with their manager.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Employee Full Name', 
		m.FirstName + ' ' + m.LastName AS 'Manager Full Name'
    FROM TelerikAcademy.dbo.Employees e 
    JOIN TelerikAcademy.dbo.Employees m
	ON e.ManagerID = m.EmployeeID
    ```
    
21.	Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: `Employees e`, `Employees m` and `Addresses a`.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Employee Full Name', 
		m.FirstName + ' ' + m.LastName AS 'Manager Full Name',
		a.AddressText
    FROM TelerikAcademy.dbo.Employees e 
	JOIN TelerikAcademy.dbo.Employees m
	ON e.ManagerID = m.EmployeeID
	JOIN TelerikAcademy.dbo.Addresses a
	ON e.AddressID = a.AddressID

    ```
    
22.	Write a SQL query to find all departments and all town names as a single list. Use `UNION`.

    ```SQL
    SELECT d.Name
    FROM TelerikAcademy.dbo.Departments d
    UNION
    SELECT t.Name
    FROM TelerikAcademy.dbo.Towns t
    ```
23.	Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name',
		m.FirstName + ' ' + m.LastName AS 'Manager Full Name'
	FROM TelerikAcademy.dbo.Employees m
	RIGHT OUTER JOIN TelerikAcademy.dbo.Employees e
	ON e.ManagerID = m.EmployeeID
    ```

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name',
		m.FirstName + ' ' + m.LastName AS 'Manager Full Name'
	FROM TelerikAcademy.dbo.Employees e
	LEFT OUTER JOIN TelerikAcademy.dbo.Employees m
	ON e.ManagerID = m.EmployeeID
    ```
    
24.	Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

    ```SQL
    SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', 
		e.HireDate, 
		d.Name AS 'Department'
	FROM TelerikAcademy.dbo.Employees e
    JOIN TelerikAcademy.dbo.Departments d
    ON e.DepartmentID = d.DepartmentID
	WHERE d.Name IN ('Sales', 'Finance') AND
		1995 <= YEAR(e.HireDate) AND YEAR(e.HireDate) <= 2005
    ```
