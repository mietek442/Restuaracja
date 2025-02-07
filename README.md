
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

# Docker Guid in English: 

# Docker Poradnik po polsku:


Logowanie dockera za pomocą komendy:
```docker command
docker login -u uzytkownik -p haslo
```
wylogowanie sie z dockera za pomocą komendy:
```docker command
docker logout
```

Bildowanie dockera:
```docker command
 docker build -t mietek442/restauracja:1.0 .
```
- docker build  - do buildowania dockera ,  🐈 - fajna emotka
- -t   to jest tylko do tagowania jak zrobi sie :  docker images  to pokazuje id obrazu kontenera, nazwa jego, oraz tag nadany 🐈 
- mietek442/restauracja - to jest tylko nazwa jełopie, dziekuje!      można napisac kotek ale według jakiejś tam konwencji (genewskiej czy innej) lepiej używać właśnie nazwa_użytkownika/nazwa_aplikacji 🐈
- 1.0   - taguje jaka wersja   tego mogło by nie być i wtedy  byśmy używali lastest przy np. push i by działało ale z nowu konwencja działa tak że lepiej 1.0 bo wtedy masz pewnosć do wersji chłopie, jak użyjesz lastest to nie zawsze ci zrobi lastest  🐈




# ! opcjonalne kroki !
do których musimy mieć docker hub. Wchodzimy na strone  docker hub i tworzymy nowe repozytorium, ja utworzyłem  mietek442/restauracja
Można utworzyć za darmo 1 prytwatne i reszta niestety publicznych nawet nie wiem ile 

Push  dockera:
```docker command
  docker push mietek442/restauracja:1.0    
```
- docker push  - do pushowania dockera ,  🐕‍🦺 - fajna emotka
- mietek442/restauracja - to już wiemy 
- 1.0  wersja/ opcjonalnie jak nie używaliśmy przy buildzie wersji to dajemy lastest 

PULL  dockera:
```docker command
  docker pull mietek442/restauracja:1.0    
```
- chyba da się na logike  zrozumieć co tu sie dzieje  😎 

# ! Uruchomienie dockera to akurat ważne  !

pokazanie listy obrazów:
```docker command
docker images
```
- jak się zbuduje to pokazuje obraz, ale ten pobrany z repozytorium też pokaże


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



pokazanie listy uruchomionych kontenerów:
```docker command
docker ps
```
- pokazuje id uruchomionego obrazu, nazwa_obrazu, status(start) 




# ! zawansowane techniki dockera no na razie to warto sie dwoeidzieć co to docker ale mamy:

```docker command 
docker run --rm
```
-   służy do  kontener zostanie automatycznie usunięty po zakończeniu jego działania. 🥴


```docker command 
docker run --read-only my_image
```
-   no jest read only i jak ci jakiś jełop wejdzie na twojego ukochanego dockera to nie bedzie mógł zbytnio nic tam edytować w tym obrazie no i może być to spoko na produkcji już bo zmniejsza ryzyko zmian 🥴



Uruchomienie dockera z ograniczeniem pamieci i procestora:
```docker command 
docker run --memory="150m"   --cpus="0.2"
```
-   --memory="150m"  - tylko 150mg pamieci ogranicza🥴
-   --cpus="0.2" - pozwala na wykorzystanie procesora do 20%, ale jeśli mamy  kilka rdzeni na procsorze to musmy kila razy podać tą wartosc(nie wiem w sumie)   🥴 


#krótko o DockerFile:

```docker file command 
USER app 
```
USER app  w 2 linijce używanie usera zwiekrsza bezpieczeństwo, można też takiego stworzonego usera ograniczyć i nie bedzie mógł zrobić szkód jak root 
[mało info? - poczytaj o bezpieczeństwie u tego giga chłopa]([https://backendrestauracja.jakubchrzastek.pl/swagger/index.html](https://cdn.sekurak.pl/ksiazka3/wdbit2-docker-rozdzial.pdf))
