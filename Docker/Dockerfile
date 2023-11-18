
#SQL Server=========================================================

# Use the official SQL Server 2019 image from Microsoft
FROM mcr.microsoft.com/mssql/server:2019-latest

# Set environment variables
ENV SA_PASSWORD 123456!@
ENV ACCEPT_EULA Y

# Create a new database
ENV MSSQL_DB MVCTest

# Create a new user
#ENV MSSQL_USER YourUsername
#ENV MSSQL_PASSWORD YourUserPassword

# Expose SQL Server port
EXPOSE 1433


# Health check
HEALTHCHECK --interval=30s --timeout=3s \
  CMD /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -Q "SELECT 1" || exit 1


#Web Server=========================================================

# Use the appropriate base image for your MVC application
#FROM mcr.microsoft.com/dotnet/core/aspnet:latest

# Set the working directory inside the container
#WORKDIR /app

# Copy the published output of your MVC application to the container
#COPY ./bin/Release/netcoreapp3.1/publish .
#COPY ./Publish .

# Expose the port your application will run on
#EXPOSE 80

# Define the command to run your application
#CMD ["dotnet", "MVCApp1.dll"]

# Use the official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
#COPY *.csproj .
#RUN dotnet restore

# Copy everything else and build
#COPY . .
#RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
#COPY --from=build /app/out .
COPY ./Publish /app

# Expose the port your app will run on
EXPOSE 80

# Define the command to run your app
CMD ["dotnet", "MVCApp1.dll"]