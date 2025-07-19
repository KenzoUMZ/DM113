# Trabalho DM113
## Alunos:
### Marcio Taier e Samuel Kenzo
# Delivery Management System

## DM113 - Projeto Final: SOAP Producer & Consumer

Este repositório contém a implementação de um sistema SOAP completo, desenvolvido como projeto final da disciplina **DM113 - Desenvolvimento de serviço SOAP com WCF em C#**. O sistema é dividido em dois projetos principais:

- **🟦 DM_113_SOAP_Producer**: Fornece os serviços SOAP para criação, listagem e gerenciamento de pedidos (`Orders`).
- **🟨 DM_113_SOAP_Consumer**: Consome os serviços SOAP do Producer e os expõe como endpoints REST via ASP.NET Core.
## 🚀 Como Executar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 ou superior (ou usar `dotnet` via terminal)

### Passos

1. Clone o repositório:

```bash
git clone https://github.com/KenzoUMZ/DM113.git
cd DM113
```



---

## 📦 Funcionalidades

### 🔹 SOAP Producer (`DM_113_SOAP_Producer`)

- `CreateOrder(Order order)` – cria um novo pedido
- `GetOrder(int id)` – retorna um pedido específico pelo ID
- `GetAllOrders()` – retorna todos os pedidos cadastrados
- `UpdateOrderStatus(int id, string newStatus)` – atualiza o status de um pedido
- `DeleteOrder(int id)` – remove um pedido pelo nome do cliente

### 🔸 SOAP Consumer (`DM_113_SOAP_Consumer`)

- **POST** `/orders` – envia lista de pedidos para criação via SOAP
- **GET** `/orders` – consulta todos os pedidos via SOAP
- **GET** `/orders/{id}` – consulta pedido específico via SOAP
- **PUT** `/orders/{id}/status?newStatus=valor` – atualiza status via SOAP
- **DELETE** `/orders/{id}` – remove pedido via SOAP

---

## 🧪 Teste via Swagger

Após iniciar o projeto `DM_113_SOAP_Consumer`, acesse:

```
https://localhost:{PORT}/swagger
```
