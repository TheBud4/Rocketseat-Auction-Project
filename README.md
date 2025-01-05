# Auction Project

Este projeto é um backend desenvolvido em C# como uma plataforma de aprendizado para criar uma aplicação de "Auctions" (leilões). Ele foi inspirado pela Rocketseat e utiliza práticas modernas de desenvolvimento.

## 🚀 Tecnologias

Este projeto foi desenvolvido com as seguintes tecnologias:

- **C#**
- **.NET**
- **Entity Framework Core**
- **SQLite**
- **Swagger** (para documentação de API)

## 📂 Estrutura do Projeto

O projeto está estruturado da seguinte forma:

```plaintext
📁 Rocketseat-Auction-Project
├── 📁 Controllers      # Controladores para gerenciar endpoints
├── 📁 Models           # Modelos de dados
├── 📁 Data             # Configuração de banco de dados e migrações
├── 📁 Services         # Serviços de aplicação
├── 📁 DTOs             # Data Transfer Objects
├── 📁 Configurations   # Configurações adicionais do projeto
└── Program.cs          # Configuração inicial da aplicação
```

## ⚙️ Funcionalidades

O backend suporta as seguintes funcionalidades:

- **Usuários**:
  - Cadastro de novos usuários
  - Listagem de usuários
  - Atualização de informações de usuários
  - Exclusão de usuários
- **Leilões**:
  - Criação de leilões
  - Listagem de leilões ativos
  - Fechamento de leilões
  - Lances em leilões

## 🛠️ Como Executar

Siga os passos abaixo para executar o projeto localmente:

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/) instalado
- [SQLite](https://sqlite.org/index.html) configurado

### Passos

1. Clone este repositório:
   ```bash
   git clone https://github.com/TheBud4/Rocketseat-Auction-Project.git
   ```

2. Navegue até o diretório do projeto:
   ```bash
   cd Rocketseat-Auction-Project
   ```

3. Restaure as dependências:
   ```bash
   dotnet restore
   ```

4. Aplique as migrações do banco de dados:
   ```bash
   dotnet ef database update
   ```

5. Execute o projeto:
   ```bash
   dotnet run
   ```

6. Acesse a API no Swagger:
   - URL padrão: `http://localhost:5000/swagger`

## 🧪 Testes

Este projeto inclui testes básicos. Para executá-los:

1. Navegue até o diretório do projeto:
   ```bash
   cd Rocketseat-Auction-Project
   ```

2. Execute os testes:
   ```bash
   dotnet test
   ```

## 🌟 Contribuições

Contribuições são sempre bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias e sugestões.

## 📝 Licença

Este projeto está sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais informações.

---

💡 Desenvolvido por **[TheBud4](https://github.com/TheBud4)** como um projeto de aprendizado e prática em desenvolvimento backend.
