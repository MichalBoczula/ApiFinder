#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ApiFinder.API/ApiFinder.API.csproj", "ApiFinder.API/"]
COPY ["ApiFinder.Infrastructure/ApiFinder.Infrastructure.csproj", "ApiFinder.Infrastructure/"]
COPY ["ApiFinder.Persistance/ApiFinder.Persistance.csproj", "ApiFinder.Persistance/"]
COPY ["ApiFinder.Application/ApiFinder.Application.csproj", "ApiFinder.Application/"]
COPY ["ApiFinder.Domain/ApiFinder.Domain.csproj", "ApiFinder.Domain/"]
COPY ["ApiFinder.Scheduler/ApiFinder.Scheduler.csproj", "ApiFinder.Scheduler/"]
RUN dotnet restore "ApiFinder.API/ApiFinder.API.csproj"
COPY . .
WORKDIR "/src/ApiFinder.API"
RUN dotnet build "ApiFinder.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiFinder.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiFinder.API.dll"]