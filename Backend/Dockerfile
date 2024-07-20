# Use the official image as a parent
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use SDK to build and publish the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Backend/GTAServerAdmin.csproj", "Backend/"]
RUN dotnet restore "Backend/GTAServerAdmin.csproj"
COPY . .
WORKDIR "/src/Backend"
RUN dotnet build "GTAServerAdmin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GTAServerAdmin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GTAServerAdmin.dll"]
