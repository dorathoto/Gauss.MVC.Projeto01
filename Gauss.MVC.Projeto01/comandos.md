## Comando para migration
dotnet ef migrations add  ___NomeMigration___

ex:
    dotnet ef migrations add migrationInicial

Update do migration
    dotnet ef database update


Se tiver erro, atualizar o pacote do ef
	dotnet tool update --global dotnet-ef

Ou instalar se não tiver ainda
    dotnet tool install --global dotnet-ef

## Instalar o .NET 7

Windows
https://download.visualstudio.microsoft.com/download/pr/4c0aaf08-3fa1-4fa0-8435-73b85eee4b32/e8264b3530b03b74b04ecfcf1666fe93/dotnet-sdk-7.0.306-win-x64.exe

Linux & Mac
https://dotnet.microsoft.com/pt-br/download/dotnet
Escolher o .NET 7 SDK x64
