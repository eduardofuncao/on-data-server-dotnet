# On-Data Backend Server

API REST desenvolvida com C#/.NET usando Entity Framework para o aplicativo On-Data, uma solução de gerenciamento de sinistros odontológicos para a Odontoprev.

**Link GitHub**: [https://github.com/eduardofuncao/on-data-server-dotnet](https://github.com/eduardofuncao/on-data-server-dotnet)

## Equipe

> **Artur Lopes Fiorindo** » 53481  
> Responsável pela implementação do endpoint para **Ocorrências**  
> 
> **Eduardo Felipe Nunes Função** » 553362  
> Responsável pela implementação do endpoint para **Pacientes**  
> 
> **Jhoe Kochi Hashimoto** » 553831  
> Responsável pela ideação e definições de negócio do projeto  

---

## Objetivo

Desenvolver uma API robusta e eficiente para gerenciar sinistros odontológicos, fornecendo endpoints CRUD para manipulação de entidades como Pacientes, Dentistas, Ocorrências e Doenças, integrada a um banco de dados Oracle e seguindo boas práticas de desenvolvimento em C#/.NET.

## Escopo

- **CRUD para Pacientes** (criação, leitura, atualização e exclusão)
- **CRUD para Ocorrências**
- Relacionamentos entre Pacientes, Dentistas, Ocorrências.

---

## Requisitos Funcionais

1. Operações de CRUD para entidades de Pacientes e Ocorrências.
2. Registro de ocorrências com detalhes como valor, data e status de aprovação.
3. API conectada a um banco de dados Oracle.
4. Suporte a operações de relacionamento entre entidades.

## Requisitos Não Funcionais

1. Desenvolvida em **C#/.NET Core**.
2. Conexão com banco de dados **Oracle**.
3. Aplicação modular e escalável, seguindo boas práticas.
4. Suporte a **Swagger** para documentação de endpoints.
5. Testes automatizados para funcionalidades essenciais.

---

## Estrutura da Arquitetura

O projeto utiliza uma arquitetura em camadas:

- **Camada de Apresentação (API)**: Exposição de endpoints REST e processamento de solicitações HTTP.
- **Camada de Negócio (Serviços)**: Implementação da lógica de negócios e regras de processamento.
- **Camada de Dados (Data Access Layer)**: Interação com o banco de dados usando Entity Framework e Oracle.

### Diagrama de Entidade-Relacionamento (ER)

![Diagrama ER](https://github.com/user-attachments/assets/a65fefc6-89d1-40ab-9486-03b65be135db)

---

## Configurações e Endpoints

### Configuração do Servidor

- **Arquivo Program.cs**: Define as configurações de inicialização, incluindo:
  - URLs (`http://localhost:5146` e `https://localhost:7114`)
  - Habilitação de **Swagger** para documentação
  - Configuração do banco de dados Oracle via `OnDataDbContext`
  - Mapeamento de rotas para controladores MVC e API

### Controllers

#### `CadastroController`

Gerencia o CRUD de Pacientes e Ocorrências com visualizações. Principais endpoints:

- **GET /Cadastro**: Exibe lista de pacientes e suas ocorrências.
- **GET /Cadastro/Create**: Formulário de criação de paciente e ocorrência.
- **POST /Cadastro/Create**: Processa a criação e salva no banco de dados.
- **GET /Cadastro/Details/{id}**: Exibe detalhes de um paciente e ocorrência.
- **GET /Cadastro/Edit/{id}** e **POST /Cadastro/Edit/{id}**: Edição de dados.
- **GET /Cadastro/Delete/{id}** e **POST /Cadastro/Delete/{id}**: Confirma e processa exclusão.

#### `OcorrenciaController`

Responsável pelas operações de CRUD para ocorrências via API.

- **GET /api/Ocorrencias**: Retorna lista de ocorrências.
- **GET /api/Ocorrencias/{id}**: Retorna uma ocorrência específica.
- **PUT /api/Ocorrencias/{id}**: Atualiza dados de uma ocorrência.
- **POST /api/Ocorrencias**: Cria uma nova ocorrência.
- **DELETE /api/Ocorrencias/{id}**: Exclui uma ocorrência.

#### `PacienteController`

Gerencia CRUD para pacientes via API.

- **GET /api/Pacientes**: Retorna lista de pacientes.
- **GET /api/Pacientes/{id}**: Retorna um paciente específico.
- **PUT /api/Pacientes/{id}**: Atualiza dados de um paciente.
- **POST /api/Pacientes**: Cria um novo paciente.
- **DELETE /api/Pacientes/{id}**: Exclui um paciente.

#### `HomeController`

Renderiza a página inicial da aplicação.

- **GET /Home/Index**: Exibe a página inicial com links para criar e listar pacientes e ocorrências.

---

## Funcionalidades

- API completa com suporte a operações CRUD para várias entidades.
- Relacionamentos entre entidades como Pacientes e Ocorrências.
- Conexão e integração com banco de dados Oracle.

---

## Como Executar o Projeto

Para iniciar o servidor da API, utilize o comando:

```bash
dotnet run
```

Este comando deve ser executado no diretório raiz do projeto.

---

## Trabalhando com o Banco de Dados

- **Criar uma Migration**: Para criar um novo arquivo de migration, execute:
  ```bash
  dotnet-ef migrations add NomeDaMigration
  ```
- **Atualizar o Banco de Dados**: Para aplicar as migrations e atualizar o banco de dados:
  ```bash
  dotnet-ef database update
  ```
- **Remover uma Migration**: Para excluir a última migration criada:
  ```bash
  dotnet-ef migrations remove
  ```

---

## Documentação e Testes

Para testar a API e explorar a documentação gerada automaticamente, utilize o **Swagger** acessando:

```
http://localhost:5146/swagger/index.html
```

---

Esse `README.md` fornece uma visão abrangente do projeto, incluindo configurações, rotas e funcionalidades. Qualquer atualização adicional pode ser facilmente integrada conforme necessário.
