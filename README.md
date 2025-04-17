# 🔐 API de Autenticação - .NET 8

Este projeto é uma API de autenticação desenvolvida em .NET 8, com emissão de tokens JWT e verificação de credenciais de usuário via login. Ele simula a migração de um sistema legado em Java (Spring Boot) para o ecossistema .NET, mantendo a segurança e a compatibilidade dos acessos.

## 🚀 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- BCrypt.Net
- JWT (Json Web Tokens)
- Swagger (Swashbuckle)

---

## ⚙️ Requisitos

Antes de começar, certifique-se de ter instalado:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/)
- [Visual Studio ou VS Code](https://code.visualstudio.com/)
- [EF Core CLI](https://learn.microsoft.com/ef/core/cli/dotnet)

---

## 📦 Instalação e Execução

1. **Clone o repositório:**

```bash
git clone https://github.com/seu-usuario/API_Authentication.git
cd API_Authentication/API_Authentication
```

2. **Configure o banco de dados:**

Altere a string de conexão em `appsettings.json` ou `appsettings.Development.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=AuthDb;Username=postgres;Password=suasenha"
}
```

3. **Configure as chaves JWT no `appsettings.json`:**

```json
"JwtSettings": {
  "SecretKey": "sua-chave-secreta-bem-grande",
  "Issuer": "API_Authentication",
  "Audience": "API_Authentication_User",
  "TokenExpirationMinutes": 60
}
```

4. **Execute as migrations para criar o banco de dados:**

```bash
dotnet ef database update
```

5. **Execute a aplicação:**

```bash
dotnet run
```

A API estará disponível em: `http://localhost:5000` ou `http://localhost:5400`

---

## 🧪 Testando a API

Acesse a documentação interativa no Swagger:

```
https://localhost:5000/swagger
```

### 🔐 Endpoint de Login

- `POST /api/auth/login`

**Corpo da requisição:**

```json
{
  "username": "admin",
  "password": "123456"
}
```

**Resposta:**

```json
{
  "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "refreshToken": "d7e6b318-..."
}
```

---

## 🧰 Estrutura do Projeto

```
API_Authentication/
├── Controllers/         # Endpoints da API
├── Data/                # Contexto do banco de dados
├── Models/              # Modelos e DTOs
├── Repositories/        # Acesso a dados
├── Services/            # Lógica de autenticação e JWT
├── Settings/            # Configurações
├── Program.cs
├── appsettings.json
└── API_Authentication.csproj
```

---

## 📜 Licença

Este projeto foi desenvolvido exclusivamente para fins educacionais e de avaliação técnica.
Desafio proposto para entrevista de desenvolvedora com foco em .NET 8, autenticação, segurança de APIs e migração de Java para C#.

---

## 🤝 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.
