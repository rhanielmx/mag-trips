# Mag Trips

## Tecnologias 

Backend feito em C# com ASP.NET Core 8.0 e Frontend feito em React 18.2.0 com vite 5.1.4.

Dados consumidos pela API da [Open Trip Map.](https://opentripmap.com/)

### Procedimento

## Backend 

#### Clonar o repositório [rhanielmx/mag-trips](https://github.com/rhanielmx/mag-trips) e abrir no Visual Studio o projeto encontrado em `backend\mag-trip-api\mag-trip-api`

#### Instalar as seguintes Dependências com o próprio gerenciador de pacotes NuGet:
  - AutoMapper - v12.0.1
  - AutoMapper.Extensions.Microsoft.DependencyInjection - v12.0.1

#### Executar o programa clicando `Ctrl + F5` ou rodando o comando `dotnet run` na pasta do projeto.

## Frontend 

#### Clonar o repositório [rhanielmx/mag-trips](https://github.com/rhanielmx/mag-trips) e abrir no Visual Studio o projeto encontrado em `mag-trip-interface`

#### Instalar as dependências rodando `npm i`

#### Caso a porta em que o backend esteja rodando não seja a 7288, alterar o arquivo `src/lib/api.ts` substituindo a porta da rota pela porta correta.

#### Executar o programa rodando `npm run dev`

