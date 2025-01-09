Created with <a href="https://github.com/Dawideg">@Dawideg</a>

Restaurant API (v1)
Welcome to the Restaurant API! This project serves as a comprehensive backend system for restaurant management, built with the latest and most reliable technologies.

Technologies Used
CQRS ✔️

Vertical Architecture ✔️

Dotnet Entity Framework Core ✔️

ASP.NET Core Identity in .NET 8 (Work in progress)

Fluent Validator (Work in progress)

Docker ✔️

Azure Blob Storage for Pictures ✔️

Endpoints Overview
Reservations: Create, Edit, Delete

Dishes: Create, Get All, Delete, Get by ID, Update

Orders: Create, Get All, Update Status

Files: Upload Picture, Delete Picture, Get by ID

Supplies: Add, Browse, Delete, Get by ID, Update

Tables: Create, Browse, Update Reservation Status

Users: Get Logged-in User, Log in, Log out, Register

How to Run
Clone the Repository:
sh
git clone https://github.com/yourusername/restaurant-api.git
Build the Docker Image:
sh
docker build -t restaurant-api .
Run the Docker Container:
sh
docker run -p 5001:5001 restaurant-api
Database Migrations
To perform database migrations, execute the following commands:

sh
dotnet ef migrations remove
dotnet ef migrations add Init
dotnet ef database drop
dotnet ef database update
Make sure to change the server connection string in your appsettings.json file from:

json
"DefaultConnection": "Server=restauracja.database;Database=restauracja;User Id=restauracja;Password=restauracja;"
to:

json
"DefaultConnection": "Server=localhost;Database=restauracja;User Id=restauracja;Password=restauracja;"
Contact


