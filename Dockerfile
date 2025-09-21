# Dùng image .NET 8 SDK để build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy tất cả source code
COPY . .

# Restore dependencies
RUN dotnet restore "./APIService.csproj"

# Build project
RUN dotnet publish "./APIService.csproj" -c Release -o /app/publish

# Dùng image runtime nhẹ để chạy
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Expose port
EXPOSE 8080
ENTRYPOINT ["dotnet", "APIService.dll"]