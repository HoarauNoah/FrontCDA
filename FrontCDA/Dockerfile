#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FrontCDA/FrontCDA.csproj", "FrontCDA/"]
RUN dotnet restore "FrontCDA/FrontCDA.csproj"
COPY . .
WORKDIR "/src/FrontCDA"
RUN dotnet build "FrontCDA.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FrontCDA.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrontCDA.dll"]