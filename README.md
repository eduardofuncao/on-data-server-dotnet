# On-Data Backend Server
API REST desenvolvida com C#/.NET usando EF para o aplicativo On-Data, desenvolvido como solução de gerenciamento de sinistros para a Odontoprev.

Link GitHub: https://github.com/eduardofuncao/on-data-server-dotnet

## Equipe
> Artur Lopes Fiorindo » 53481
> 
> responsável pela implementação do endpoint para ocorrências

> Eduardo Felipe Nunes Função » 553362 
> 
> responsável pela implementação do endpoint para pacientes

> Jhoe
> 
> responsável pela implementação do README do projeto
 
## Objetivo

O objetivo deste projeto é desenvolver uma API robusta e eficiente para gerenciar sinistros odontológicos, oferecendo endpoints CRUD para a manipulação de entidades como Pacientes, Dentistas, Ocorrências e Doenças, integrando-se ao banco de dados Oracle e seguindo boas práticas de desenvolvimento em C#/.NET.

## Escopo

O escopo da API inclui:

- CRUD para **Pacientes** (criação, leitura, atualização e exclusão).
- CRUD para **Ocorrências**.
- CRUD para **Doenças**.
- Gerenciamento de relacionamento entre as entidades (Pacientes, Dentistas, Ocorrências, Doenças e Clínicas).

## Requisitos Funcionais

1. O sistema deve permitir criar, atualizar, excluir e listar pacientes.
2. O sistema deve permitir registrar ocorrências com informações como valor, duração e aprovação.
3. O sistema deve registrar as doenças associadas aos pacientes.
4. A API deve suportar as operações CRUD (Create, Read, Update, Delete) para todas as entidades.
5. A API deve se conectar a um banco de dados Oracle.

## Requisitos Não Funcionais

1. A API deve ser desenvolvida utilizando **C#/.NET Core**.
2. O banco de dados utilizado deve ser o **Oracle**.
3. A aplicação deve ser escalável e seguir padrões de boas práticas de desenvolvimento.
4. A API deve ter suporte a testes automatizados.
5. A aplicação deve ter uma cobertura de código mínima de [DETALHAR] % nos testes unitários.
6. O sistema deve ser implementado com suporte a **Swagger** para documentação dos endpoints.

## Desenho da Arquitetura

A arquitetura do sistema segue uma abordagem em camadas, com as seguintes responsabilidades:

- **Camada de Apresentação (API)**: Responsável por expor os endpoints REST e processar as solicitações HTTP.
- **Camada de Negócio (Services)**: Responsável pela lógica de negócios, onde as regras de processamento de dados são aplicadas.
- **Camada de Dados (Data Access Layer)**: Responsável pela interação com o banco de dados, utilizando o Entity Framework para mapeamento objeto-relacional (ORM).

Diagrama de Entidade-Relacionamento (ER):
![Diagrama ER](link-para-diagrama.png)

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

