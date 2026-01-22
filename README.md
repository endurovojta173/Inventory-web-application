# Inventory-web-application
## --- About this project --- ##
This project is created for purpose of learning how to use C#, .NET and for presenting this on my CV. I would like to keep this project completely public. People just have to set up/connect their own database and they can run this app.<br>
This should be app for inventory check for firms. People should be able to manage items and people in their firm. They have very much options. There is build-in borrowing, assignment to room, assignment to people, item and people history, home-office option included, assigmnent people to rooms. Admin can manage all items for everyone, manager can manage items of his employees and employees can manage items which are assigned to them. We even thought about items like furniture and more, you just can use this for everything in your firm. This app should work even for large corporates - i have included buildings.<br> Whole backend is programmed by using C# and Entity framework core. Frontend is programmed in react? Maybe something more/else, i will see.    

## --- Setting up project ---

dotnet --version<br>
dotnet new sln -n InventoryManager<br>
dotnet new webapi -n Inventory.API --use-controllers<br>
dotnet sln add Inventory.API<br>
cd Inventory.API<br>
dotnet add package Microsoft.EntityFrameworkCore.Sqlite<br>
dotnet add package Microsoft.EntityFrameworkCore.Tools<br>
dotnet add package Microsoft.EntityFrameworkCore.Design<br>
dotnet add package Swashbuckle.AspNetCore //For swagger<br>
dotnet add package Microsoft.EntityFrameworkCore.SqlServer //For DB<br>


To run this app you need to write to terminal dotnet run, CTRL+C to end<br>

Iam using SQL Server 2022 Express<br>

## --- Database ---

I have used dbdiagram.io for creating database diagram. It is just logical. Names of each table is different in app. Diagram is made in snake_case notation and real database is in CamelCase because of C# standarts. Documentation of database + diagram is available here [DB Docs](https://dbdocs.io/vojtechbrenek173/Inventory-web-application-database)<br>

dotnet ef migrations add InitialCreate<br>
dotnet ef database update<br>
dotnet run<br>

How to create your own local db? Just write into the console **dotnet ef database update**. You can configure what you exactly want to generate in *Data/DbInitializier.cs*.

## --- Project structure ---
.gitattributes<br>
│   .gitignore<br>
│   InventoryManager.slnx<br>
│   README.md<br>
│<br>
└───Inventory.API
    │   appsettings.Development.json<br>
    │   appsettings.json<br>
    │   Inventory.API.csproj<br>
    │   Inventory.API.http<br>
    │   Program.cs<br>
    │   WeatherForecast.cs<br>
    │<br>
    ├───bin //Not commited on github<br>
    │  <br>
    │<br>
    ├───Controllers<br>
    │       WeatherForecastController.cs<br>
    │<br>
    ├───Data<br>
    │       DbInitializier.cs<br>
    │       InventoryContext.cs<br>
    │<br>
    ├───Migrations<br>
    │       20260122143405_InitialCreate.cs<br>
    │       20260122143405_InitialCreate.Designer.cs<br>
    │       InventoryContextModelSnapshot.cs<br>
    │<br>
    ├───Models<br>
    │       Building.cs<br>
    │       Department.cs<br>
    │       Employee.cs<br>
    │       EmployeeInventoryRole.cs<br>
    │       Floor.cs<br>
    │       Item.cs<br>
    │       ItemHasStatus.cs<br>
    │       ItemHistory.cs<br>
    │       ItemManipulationType.cs<br>
    │       ItemStatus.cs<br>
    │       ItemType.cs<br>
    │       Job.cs<br>
    │       Room.cs<br>
    │<br>
    ├───obj //Not commited on github<br>
    │<br>
    └───Properties<br>
            launchSettings.json<br>
### Controllers

### Date

### Migrations
Recipe for cooking DB

### Models
Here are models which mirrors DB. Entity framework core is set up here.



### Program.cs
Main setup file for this project

