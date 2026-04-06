FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY ["FitConnect.API.csproj", "./"]
RUN dotnet restore "FitConnect.API.csproj"

COPY . .
RUN dotnet build "FitConnect.API.csproj" -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT ["dotnet", "FitConnect.API.dll"]