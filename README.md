# ASP.NET DBConnection Test

## Overview

This project is a simple ASP.NET WebForms application designed to demonstrate how to test a connection to an SQL Server database. The project includes code examples for establishing and verifying a database connection using C# and ASP.NET.

## Features

- Establishes a connection to a Microsoft SQL Server database.
- Provides a user interface with a button to test the connection.
- Displays the status of the connection (successful or failed) to the user.
- Demonstrates the use of `SqlConnection` and `WebConfigurationManager` in ASP.NET.

## Requirements

- **ASP.NET Framework**: .NET Framework 4.x
- **Development Environment**: Visual Studio 2019 or later
- **SQL Server**: SQL Server 2016 or later



## Setup Instructions

1.Clone the Repository:

git clone https://github.com/your-username/ASP.NET-DBConnection-Test.git
cd ASP.NET-DBConnection-Test


2.Open the project in Visual Studio:
-Navigate to the project folder and open the .sln file.


3.Configure the database connection:
-Open Web.config.
-Update the connection string under <connectionStrings> with your database details:

<connectionStrings>
  <add name="LoginDBConnectionString" connectionString="Data Source=your_server_name;Initial Catalog=Login;Integrated Security=True;" providerName="System.Data.SqlClient"/>
</connectionStrings>


4.Run the project:
-Press F5 to run the project in Visual Studio.
-Click the "Test Connection" button to check the database connection.


