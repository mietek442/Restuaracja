
![Restaurant API Logo](your-image-path.png)

Created with <a href="https://github.com/Dawideg">@Dawideg</a>
# Wersja  API na serwerze  (v1.0)
[Przejdź do dokumentacji aplikacji](https://backendrestauracja.jakubchrzastek.pl/swagger/index.html)


# Restaurant API (v1)

Welcome to the Restaurant API! This project serves as a comprehensive backend system for restaurant management, built with the latest and most reliable technologies.

## Technologies Used
- CQRS ✔️
- Vertical Architecture ✔️
- Dotnet Entity Framework Core ✔️
- ASP.NET Core Identity in .NET 8 (Work in progress)
- Fluent Validator (Work in progress)
- Docker ✔️
- Azure Blob Storage for Pictures ✔️

## Endpoints Overview
- **Reservations**: Create, Edit, Delete
- **Dishes**: Create, Get All, Delete, Get by ID, Update
- **Orders**: Create, Get All, Update Status
- **Files**: Upload Picture, Delete Picture, Get by ID
- **Supplies**: Add, Browse, Delete, Get by ID, Update
- **Tables**: Create, Browse, Update Reservation Status
- **Users**: Get Logged-in User, Log in, Log out, Register

## How to Run

```bash
docker build -t restaurant-api .
docker run -p 5001:5001 restaurant-api
dotnet ef migrations remove
dotnet ef migrations add Init
dotnet ef database drop
dotnet ef database update
```







Make sure to change the server connection when you make migration string in your, after migrations you change defaultconnection string back `appsettings.json` file from:

```json
"DefaultConnection": "Server=restauracja.database;Database=restauracja;User Id=restauracja;Password=restauracja;"
```

to:

```json
"DefaultConnection": "Server=localhost;Database=restauracja;User Id=restauracja;Password=restauracja;"
```

Docker Guid in English: 

Docker Poradnik po polsku:


Logowanie dockera za pomocą komendy:
```docker command
docker login -u uzytkownik -p haslo
```
wylogowanie sie z dockera za pomocą komendy:
```docker command
docker logout
```





Uruchomienie dockera:
```docker command
docker run -d -p 8808:8080 c429c59dae79
```
- docker run  - służy do uruchomienia dockera na serwerze, 🥴 - fajna emotka
-   -d   służy do tego w skórcie jak chcesz wyjsc z konsoli to nie zamykasz odpalonego obrazu 🥴
-   -p   służy do portowania   no jak go odpalimy docker run i tyle to obraz  się odpali wewntarz dockera na porcie np.  5522321 a nie zobaczymy go na kompuerze na localhost:5522321 🥴
-   8808 - port na którym go zobaczymy na komputerze 🥴
-   8080 port na dockerze na którym sie odpali obraz 🥴
-   c429c59dae79    id obrazu  🥴 
