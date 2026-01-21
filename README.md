# Inventory-web-application


--- Setting up project ---

dotnet --version
dotnet new sln -n InventoryManager
dotnet new webapi -n Inventory.API --use-controllers
dotnet sln add Inventory.API
cd Inventory.API
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Swashbuckle.AspNetCore //For swagger

dotnet add package Microsoft.EntityFrameworkCore.SqlServer //For DB

To run this app you need to write to terminal dotnet run, CTRL+C to end


Iam using SQL Server 2022 Express