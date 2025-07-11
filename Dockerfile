# Use the official .NET SDK image as a base
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# It's more efficient to copy project and solution files first, then restore packages.
# This way, Docker can cache the restored packages layer if the project files don't change.
COPY ./*.sln ./
COPY SparkleBot/SparkleBot.csproj ./SparkleBot/
COPY SparkleBot.WebUI/SparkleBot.WebUI.csproj ./SparkleBot.WebUI/

# Restore dependencies for the solution
RUN dotnet restore

# Copy the remaining source code
COPY . ./

# Build the WebUI application for release
RUN dotnet publish ./SparkleBot.WebUI/SparkleBot.WebUI.csproj -c Release -o out

# Use the official .NET runtime image as a base for the final image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Set the URL and port for the ASP.NET Core application
# The '*' binds to all network interfaces, which is crucial for Docker
ENV ASPNETCORE_URLS=http://*:8080

# The default ASP.NET Core port
EXPOSE 8080

# Set the entry point for the WebUI application
ENTRYPOINT ["dotnet", "SparkleBot.WebUI.dll"]