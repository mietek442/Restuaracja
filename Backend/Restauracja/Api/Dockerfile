# Etap 1: Baza
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8807
EXPOSE 8808

# Etap 2: Budowanie
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Kopiowanie pliku projektu
COPY Api/Api.csproj Api/
RUN dotnet restore Api/Api.csproj

# Kopiowanie pozosta³ych plików i budowanie aplikacji
COPY . .
WORKDIR /src/Api
RUN dotnet build Api.csproj -c $BUILD_CONFIGURATION -o /app/build

# Etap 3: Publikowanie
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish Api.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Etap 4: Finalny obraz
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.dll"]
