# Base image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj files
COPY ["TechlyApplication/Techly.Presentation.csproj", "TechlyApplication/"]
COPY ["Techly.BLL/Techly.BLL.csproj", "Techly.BLL/"]
COPY ["Techly.DAL/Techly.DAL.csproj", "Techly.DAL/"]
COPY ["Utility/Utility.csproj", "Utility/"]

# Restore dependencies
RUN dotnet restore "TechlyApplication/Techly.Presentation.csproj"

# Copy all source code
COPY . .

WORKDIR "/src/TechlyApplication"

# Build
RUN dotnet build "Techly.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Techly.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final image
FROM base AS final
WORKDIR /app

# Copy published files
COPY --from=publish /app/publish ./

# Copy all appsettings.*.json files
COPY TechlyApplication/appsettings.json ./ 
COPY TechlyApplication/appsettings.Development.json ./ 
COPY TechlyApplication/appsettings.Docker.json ./ 





# Optional: Ensure wwwroot is present (already included in publish if <Content> added in csproj)
# COPY TechlyApplication/wwwroot ./wwwroot

ENTRYPOINT ["dotnet", "Techly.Presentation.dll"]
