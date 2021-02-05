Aplicação WebApi em C#.

/ping -> Retorna "Running" se a aplicação estiver rodando corretamente.

/pingdb -> Se a conexão ao banco for bem sucedida, retorna "OK".

/version -> Retorna a versão da aplicação.

/book -> Conecta no banco, e retorna uma lista de livros.

Classe BookController.cs:
- Lê a string de conexão ao banco de dados que está appsettings.json da aplicação.
- Utiliza Dapper para obter uma lista de livros do banco de dados.