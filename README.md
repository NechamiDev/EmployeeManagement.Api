# Employee Management API

A RESTful Web API built with ASP.NET Core 8 for managing employees.

## Overview

Employee Management API is a backend application that provides CRUD operations for employee management.

The project demonstrates building a clean .NET Web API using Entity Framework Core, SQL Server, and Swagger documentation.

## Technologies

- C#
- ASP.NET Core 8 Web API
- Entity Framework Core 8
- SQL Server LocalDB
- Swagger / OpenAPI
- Git

## Features

- Create new employees
- Retrieve all employees
- Update employee details
- Delete employees
- Data validation using Data Annotations
- Database management using Entity Framework Core migrations

## Project Structure

EmployeeManagement.Api

├── Controllers  
│   └── EmployeesController.cs  

├── Models  
│   └── Employee.cs  

├── Data  
│   └── AppDbContext.cs  

├── Migrations  

└── Program.cs  


## Database

The project uses SQL Server LocalDB with Entity Framework Core.

Database creation is handled using Entity Framework Core migrations.

Example connection:

Server=(localdb)\MSSQLLocalDB;
Database=EmployeeManagementDb;


## Running the Project

### 1. Clone the repository

git clone (https://github.com/NechamiDev/EmployeeManagement.Api.git)


### 2. Restore dependencies

dotnet restore


### 3. Apply database migrations

Update-Database


### 4. Run the application

dotnet run


### 5. Open Swagger

https://localhost:7121/swagger


## API Endpoints

### Get all employees

GET /api/Employees


### Create employee

POST /api/Employees


### Update employee

PUT /api/Employees/{id}


### Delete employee

DELETE /api/Employees/{id}


## Example Request

{
  "firstName": "David",
  "lastName": "Cohen",
  "email": "david@test.com",
  "department": "IT",
  "position": "Developer",
  "salary": 15000,
  "hireDate": "2026-07-28"
}


## Architecture

The project follows a layered architecture:

Controller Layer  
Handles HTTP requests and responses.

Service Layer  
Contains business logic.

Repository Layer  
Handles database operations.

Data Layer  
Manages Entity Framework Core database context.


## Author

Nachama Lorentz
