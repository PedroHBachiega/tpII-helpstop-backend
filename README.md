# tpII-helpstop-backend

# HelpApp

Um aplicativo de gestão de atendimentos voluntários, desenvolvido com arquitetura limpa e princípios sólidos da engenharia de software.

---

## 1. 📌 HelpApp

Um aplicativo de gestão de atendimentos voluntários, que facilita a conexão entre quem precisa de ajuda e quem pode oferecê-la.

---

## 2. 📚 Descrição Geral

O HelpApp é um sistema que organiza atendimentos voluntários, conectando pessoas que necessitam de auxílio àquelas dispostas a ajudar.  

Problema que resolve:Facilita a gestão e o agendamento de atendimentos, otimizando a comunicação entre voluntários e solicitantes.  

Público-alvo: Voluntários, solicitantes de atendimento, organizações sociais e instituições parceiras.  

  Tecnologias utilizadas:
-.NET Core (C#)  
-SQL Server  
-Azure App Services
-Entity Framework Core
-xUnit para testes

---

## 3. 🧪 Funcionalidades

- Cadastro de usuários: Diferenciação entre ajudante e solicitante.
- Registro e gerenciamento de atendimentos: Criação, atualização e acompanhamento dos atendimentos.
- Agenda personalizada: Organização dos compromissos e disponibilidade dos voluntários.
- Histórico e relatórios: Visualização de registros e estatísticas de atendimentos.
- Login seguro:Sistema robusto de autenticação e autorização.

---

## 4. 🏗️ Arquitetura do Projeto

O projeto segue uma divisão em camadas, baseada nos princípios do Domain-Driven Design (DDD) e Clean Architecture.  
Divisão por camadas:

- Domain: Contém entidades, regras de negócio e interfaces essenciais.
- Application: Implementa casos de uso, orquestrando as operações entre Domain e Infrastructure.
- Infrastructure: Responsável pela comunicação com o banco de dados e implementação de serviços externos.
- Interfaces:Camada de apresentação, com controllers e rotas de API.

---

## 5. ⚙️ Princípios SOLID Aplicados

### S - Single Responsibility Principle
Cada classe possui uma única responsabilidade.  

### O - Open/Closed Principle
O sistema é aberto para extensão, mas fechado para modificação.  

### L - Liskov Substitution Principle
As subclasses podem substituir as superclasses sem alterar o comportamento esperado do sistema.  

### I - Interface Segregation Principle
Interfaces específicas são preferíveis a interfaces genéricas.  

### D - Dependency Inversion Principle
Módulos de alto nível não dependem dos de baixo nível, ambos dependem de abstrações.  

---

## 6. 🧩 Tecnologias e Ferramentas

- Linguagem: C# (.NET Core)
- Banco de Dados:SQL Server
- Ambiente:Azure App Services
- IDE: Visual Studio / VS Code
- ORM:Entity Framework Core
- Testes: xUnit ou NUnit (conforme utilizado)
- Controle de Versão: Git + GitHub

---

## 7. 🔧 Como Rodar o Projeto

1. Clonar o repositório:
   git clone https://github.com/PedroHBachiega/tpII-helpstop-backend.git
2. Abrir no Visual Studio ou VS Code.
3. Configurar a string de conexão: 
   Atualize o arquivo `appsettings.json` com as configurações do seu banco de dados.
4. Aplicar migrations:  
   Execute o comando `Update-Database` no Package Manager Console.
5. Rodar a aplicação:  
   Utilize o F5 no Visual Studio ou rode via CLI.
6. Testar rotas:  
   Utilize ferramentas como Postman ou Swagger para testar as APIs.

---

## 8. 🧪 Testes Automatizados

- Camadas testadas:
  Principalmente a camada de domínio e a camada de aplicação.
- Execução dos testes: 
  Utilize o runner do xUnit ou NUnit para executar a suíte de testes.
- Ferramentas utilizadas:
  xUnit ou NUnit (dependendo da escolha do projeto).
- Cobertura priorizada:
  Foco nas regras de negócio e integridade dos casos de uso.

---

## 9. 📂 Estrutura de Pastas

HelpApp/ ├── Domain/ │ ├── Entities/ │ └── Interfaces/ ├── Application/ │ └── UseCases/ ├── Infrastructure/ │ ├── Data/ │ └── Services/ ├── Interfaces/ │ └── Controllers/ ├── Tests/ └── Program.cs

---

## 10. 👨‍💻 Autores

- Nome Completo:[Pedro Henrique Bachiega]  
- Função:Desenvolvimento Back-end  
- GitHub: https://github.com/PedroHBachiega/tpII-helpstop-backend.git

---

## 11. 📜 Licença

Este projeto está sob a licença MIT.  


