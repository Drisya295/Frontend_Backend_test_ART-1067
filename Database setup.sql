CREATE DATABASE cafe_employee_management;

USE cafe_employee_management;

CREATE TABLE Cafes (
    Id CHAR(36) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(256),
    Logo VARCHAR(255),
    Location VARCHAR(100) NOT NULL
);

CREATE TABLE Employees (
    Id VARCHAR(10) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    EmailAddress VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(8) NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    StartDate DATETIME NOT NULL,
    CafeId CHAR(36),
    FOREIGN KEY (CafeId) REFERENCES Cafes(Id)
);
