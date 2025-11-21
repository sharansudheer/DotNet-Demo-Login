# DotNet-Demo-Login
Demo App to showcase auth using Identity(Individual Account) and understanding EF Core 


dotnet new gitignore


dotnet user-secrets init

dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server= .....your connection string"

Eg - dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=(localdb)\\mssqllocaldb;Database=YourDatabase;Trusted_Connection=True;Encrypt=False;" Note -  Encrypt=False; is importent when running dev mode

