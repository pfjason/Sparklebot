# Use the official .NET SDK image as a base
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy the project file and restore any dependencies
COPY SparkleBot/SparkleBot.csproj ./SparkleBot/SparkleBot.csproj
RUN dotnet restore ./SparkleBot/SparkleBot.csproj

# Copy the remaining source code
COPY . ./

# Build the application
RUN dotnet publish ./SparkleBot/SparkleBot.csproj -c Release -o out

# Use the official .NET runtime image as a base for the final image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port 80 for HTTP traffic
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "SparkleBot.dll"]