CREATE DATABASE IF NOT EXISTS `exercise_database`; 
USE `exercise_database`;

CREATE TABLE employees (
	id INT PRIMARY KEY AUTO_INCREMENT,
	first_name VARCHAR(30),
    last_name VARCHAR(50),
    job_title VARCHAR(30),
    department VARCHAR(30),
    home_office BOOLEAN,
    salary INT(50)
);

INSERT INTO `employees` (`first_name`,`last_name`, `job_title`,`department`,`home_office`,`salary`) VALUES
('John', 'Doe', 'Manager', 'Sales', false, 5000),
('Jane', 'Smith', 'Developer', 'IT', false, 4000),
('Mike', 'Johnson', 'Analyst', 'Finance', false, 4500),
('Sarah', 'Anderson', 'HR Manager', 'HR', false, 5500),
('David', 'Wilson', 'Designer', 'Marketing', false, 3800),
('Emily', 'Thompson', 'Accountant', 'Finance', false, 4200),
('Daniel', 'Lee', 'Sales Rep', 'Sales', false, 3200),
('Olivia', 'Davis', 'Engineer', 'IT', true, 4800),
('Sophia', 'Maretinez', 'Marketer', 'Marketing', true, 3900),
('Matthew', 'Garcia', 'Analist', 'Finance', false, 4300);


	
	