# Projeto feito para trabalhar o conhecimento em EntityFramework
Comandos para adicionar o pacote ao seu projeto caso esteja em Visual Studio Code.
* dotnet add package Microsoft.EntityFrameworkCore
* dotnet add package Microsoft.EntityFrameworkCore.SqlServer

## Atenção esse comando aqui é para projetos que tem a versão 5 do .NET 5.xx
* dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
* dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9

## Trabalhando com migrations
* dotnet tool install --global dotnet-ef

- Antes de fazer um dotnet ef e fazer as migrações faça isso:
    * dotnet clean
    * dotnet build

## Caso queira escrever ou gerar o SQL pelo script ou até fazer uma performace
* dotnet ef migrations script -o ./script.sql
isso vai fazer o um script de criação do banco de dados.


### Atenção esse projeto ainda pode conter continuação