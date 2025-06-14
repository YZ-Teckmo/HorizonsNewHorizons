echo "Setting Up Database..."
dotnet ef migrations add InitialCreate
dotnet ef database update
echo "Done!"