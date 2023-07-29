CREATE DATABASE IF NOT EXISTS `address_database`; 
USE `address_database`;

CREATE TABLE addresses (
	street_number VARCHAR(20),
    street_name VARCHAR(80),
    area VARCHAR(80),
    town VARCHAR(80),
    district VARCHAR(80),
    country VARCHAR(50),
    continent VARCHAR(50)
);
ALTER TABLE `addresses`
ADD COLUMN isCapital BOOLEAN;

INSERT INTO `addresses` (`street_number`,`street_name`,`area`,`town`,`district`,`country`,`continent`, `isCapital`) VALUES
('10',  'Main Street', 'Downtown', 'New York City', 'Manhattan', 'United States', 'North America', FALSE),
('25A', 'Elm Avenue', 'West End', 'London', 'Westminster', 'United Kingdom', 'Europe', TRUE),
('7', 'Rue de la Paix', 'Le Marais', 'Paris', 'Ile-de-France', 'France', 'Europe', TRUE),
('1234', 'Oak Lane', 'Green Meadows', 'Los Angeles', 'California', 'United States', 'North America', FALSE),
('42', 'High Street', 'City Center', 'Sydney', 'New South Wales', 'Australia', 'Australia & Oceania', TRUE),
('56B', 'Maple Road', 'Northside', 'Toronto', 'Ontario', 'Canada', 'North America', FALSE),
('9', 'Kaiserstrasse', 'Mitte', 'Berlin', 'Berlin', 'Germany', 'Europe', TRUE),
('17', 'Plaza Mayor', 'Centro', 'Madrid', 'Madrid', 'Spain', 'Europe', TRUE),
('3', 'Piazza San Marco', 'San Marco', 'Venice', 'Veneto', 'Italy', 'Europe', FALSE),
('1001', 'Avenida Paulista', 'Jardins', 'Sao Paulo', 'Sao Paulo', 'Brazil', 'South America', FALSE),
('8/15', 'Princes Street', 'New Town', 'Edinburgh', 'Edinburgh', 'United Kingdom', 'Europe', FALSE),
('27', 'Koningsplein', 'Centrum', 'Amsterdam', 'North Holland', 'Netherlands', 'Europe', TRUE),
('42A', 'Hauptstrasse', 'Mitte', 'Vienna', 'Vienna', 'Austria', 'Europe', TRUE),
('100', 'Collins Street', 'CBD', 'Melbourne', 'Victoria', 'Australia', 'Oceania', FALSE),
('123', 'Rua da Boavista', 'Baixa', 'Porto', 'Porto', 'Portugal', 'Europe', FALSE),
('5', 'Knez Mihailova', 'Stari Grad', 'Belgrade', 'Belgrade', 'Serbia', 'Europe', TRUE),
('9876', 'Ginza', 'Chuo', 'Tokyo', 'Tokyo', 'Japan', 'Asia', TRUE),
('18', 'Connell Street', 'North City', 'Dublin', 'Dublin', 'Ireland', 'Europe', TRUE),
('75C', 'Friedrichstrasse', 'Kreuzberg', 'Berlin', 'Berlin', 'Germany', 'Europe', TRUE),
('22', 'Gran Via', 'Malasana', 'Madrid', 'Madrid', 'Spain', 'Europe', TRUE);



