<h1>TODO List API</h1> 

<p align="center">

   <img src="http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=GREEN&style=for-the-badge"/>
</p>

> Status do Projeto: :heavy_check_mark: (concluido)

### Tópicos 

:small_blue_diamond: [Descrição do projeto](#descrição-do-projeto)

:small_blue_diamond: [Funcionalidades](#funcionalidades)

:small_blue_diamond: [Pré-requisitos](#pré-requisitos)

:small_blue_diamond: [Como rodar a aplicação](#como-rodar-a-aplicação-arrow_forward)

... 

## Descrição do projeto 

<p align="justify">
  Este projeto é uma API de lista de tarefas (Todo List) desenvolvida em ASP.NET Core, utilizando Entity Framework Core como ORM (Object-Relational Mapper) 
  e SQLite como banco de dados. O Entity Framework Core simplifica o acesso e a manipulação de dados em bancos relacionais por meio de modelos de entidade,
  enquanto o SQLite oferece uma solução leve e eficiente para armazenamento de dados.
</p>

## Funcionalidades

:heavy_check_mark: Implementação dos métodos HTTP (GET, POST, PUT, DELETE) para manipulação das tarefas.

:heavy_check_mark: Utilização do Postman para testar e validar os endpoints da API.


## Pré-requisitos

:warning: [.NET](https://dotnet.microsoft.com/pt-br/download/dotnet/5.0)
:warning: [SQLITE]

...

## Como rodar a aplicação :arrow_forward:

No terminal, clone o projeto: 

```
git clone https://github.com/naralicecosta/MeuTodoEm

```
Entre na pasta do projeto:
```
cd MeuTodoEmC
```
Instalar dependencias:
```
dotnet restore
```
Aplicar migrações:
```
dotnet ef database update
```
Comando para compilar se o código esta ok
```
dotnet run build
```
Comando para executar o projeto
```
dotnet watch run
```
... 

## Desenvolvedores/Contribuintes :octocat:

Time responsável pelo desenvolvimento do projeto

|[<br><sub>Naralice Costa</sub>](https://github.com/naralicecosta) |  [<br><sub>Alison Galdino</sub>](https://github.com/Alisongaldino) |[<br><sub>Guilherme</sub>](https://github.com/Diana-ops) |[<br><sub>Italo Barbosa</sub>](https://github.com/Diana-ops) |

Copyright :copyright: Ano - Titulo do Projeto
