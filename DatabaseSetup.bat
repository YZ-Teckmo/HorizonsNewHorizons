@echo off
echo "Setting Up Database..."
@echo on
dotnet ef migrations add InitialCreate
dotnet ef database update
@echo off
echo "Done!"