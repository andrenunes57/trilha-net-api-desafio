# trilha-net-api-desafio

Este projeto resolve o desafio "trilha-net-api-desafio" da DIO, ao qual realizei um fork. O objetivo é implementar um CRUD completo em uma API utilizando Entity Framework.

## Funcionalidades
- CRUD de tarefas (criar, ler, atualizar, deletar)
- API desenvolvida em .NET 8
- Utilização do Entity Framework Core para persistência de dados
- Documentação interativa via Swagger

## Endpoints
Os principais endpoints disponíveis em `TarefaController.cs` são:

- `GET /Tarefa/{id}`: Obtém uma tarefa pelo ID
- `GET /Tarefa/ObterTodos`: Lista todas as tarefas
- `GET /Tarefa/ObterPorTitulo?titulo=...`: Busca tarefas pelo título
- `GET /Tarefa/ObterPorData?data=...`: Busca tarefas por data
- `GET /Tarefa/ObterPorStatus?status=...`: Busca tarefas por status
- `POST /Tarefa`: Cria uma nova tarefa
- `PUT /Tarefa/{id}`: Atualiza uma tarefa existente
- `DELETE /Tarefa/{id}`: Remove uma tarefa

## Como executar o projeto
1. Forneça a string de conexão para o SQL Server no arquivo `TrilhaApiDesafio/appsettings.Development.json`, na chave `ConexaoPadrao`:
   ```json
   "ConexaoPadrao": "Server=localhost; Initial Catalog=TodoDioDB; Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
   ```
   
   Caso prefira, você pode alterar a implementação do banco de dados para outro provedor compatível com o Entity Framework.

2. Execute as migrações e rode o projeto normalmente.

3. Acesse o Swagger para testar os endpoints e visualizar a documentação interativa.

---

Projeto desenvolvido para fins de aprendizado e conclusão do desafio DIO.
