# On-Data Backend Server
API REST desenvolvida com C#/.NET usando EF para o aplicativo On-Data, desenvolvido como solução de gerenciamento de sinistros para a Odontoprev.

## Equipe
> Artur Lopes Fiorindo » 53481
> 
> responsável pela implementação do endpoint para ocorrências

> Eduardo Felipe Nunes Função » 553362 
> 
> responsável pela implementação do endpoint para pacientes

> Jhoe
> 
> FALTA DETALHAR
 
## Objetivo
DETALHAR

## Escopo
DETALHAR

## Requisitos Funcionais e Não Funcionais
DETALHAR

## Desenho da Arquitetura
DETALHAR

## Funcionalidades
- API com toods os verbos para implementação de um sistema CRUD
- Conexão com banco de dados Oracle

## Como executar
Utilizar o comando `dotnet run` na raíz do diretório

## Trabalhando com o banco de dados
- Para criar o arquivo Migration, executar `dotnet-ef migrations add NomeDaMigration`
- Para atualizar a migration com base no banco de dados `dotnet-ef database update`
- Caso você precise excluir uma migration, executar `dotnet-ef migrations remove`

### Para Testar
- Para realizar os testes da aplicação, está disponibilidada uma collection Bruno em `on-data-collection/` com requests para todos os endpoints implementados FALTA DISPONIBILIZAR
- Como alternativa, utilizar o swagger em `http://localhost:$PORT/swagger/index.html`, send $PORT a porta onde o servidor estiver rodando na máquina

