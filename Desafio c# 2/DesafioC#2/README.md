# 🚗 Sistema de Tags de Pedágio (C# · Console)

Aplicação de console em C# que simula o funcionamento de uma **tag de pedágio**: o usuário cadastra um veículo, associa uma tag, recarrega saldo, passa pelo pedágio e consulta relatórios de passagens e tentativas.

Projeto desenvolvido como desafio do curso de C# da **Itera360**, com foco em programação orientada a objetos, coleções e consultas com LINQ.

## ✨ Funcionalidades

- Cadastro do veículo (placa, modelo, marca e tipo) e da tag, com validação de campos obrigatórios
- Recarga e consulta de saldo da tag
- Alteração da placa do veículo
- Passagem pelo pedágio com cobrança automática conforme o tipo do veículo
- Registro de **tentativas recusadas** (por exemplo, saldo insuficiente), com o motivo
- Relatórios:
  - **Passagens:** listagem da mais recente para a mais antiga e total arrecadado
  - **Tentativas:** listagem com filtro opcional por placa

### Tabela de valores

| Tipo de veículo | Valor do pedágio |
|-----------------|------------------|
| Moto            | R$ 1,50          |
| Carro           | R$ 2,90          |
| Caminhão        | R$ 18,90         |

## 🧠 Conceitos aplicados

- **Programação orientada a objetos:** classes, encapsulamento (propriedades com campos privados) e construtores sobrecarregados
- **Herança:** `TentativaPassagem` herda de `Passagem` e acrescenta o campo `Motivo`
- **Enum:** `TipoVeiculo` (Moto, Carro, Caminhão)
- **Coleções:** `List<Passagem>` e `List<TentativaPassagem>` para guardar o histórico
- **LINQ:** `OrderByDescending`, `Where`, `Any` e `Sum` nos relatórios
- **Tratamento de erros:** `try/catch/finally`, validação de entradas e exceções para saldo insuficiente
- **Centralização de regras:** o cálculo do valor do pedágio fica em um único método (`Pedagio.ObterValor`)

## 📁 Estrutura do projeto

```
DesafioC#2/
├── Dominio/
│   ├── Pedagio.cs            # Regras do pedágio e listas de passagens/tentativas
│   ├── Tag.cs                # Tag com saldo (recarregar, consultar, descontar)
│   └── Veiculo.cs            # Dados do veículo e associação com a tag
├── Passagem.cs               # Registro de uma passagem cobrada
├── TentativaPassagem.cs      # Passagem recusada (herda de Passagem, com motivo)
├── TipoVeiculo.cs            # Enum dos tipos de veículo
├── Relatorios.cs             # Menu e relatórios com LINQ
└── Program.cs                # Ponto de entrada e menu principal
```

## ▶️ Como executar

Pré-requisito: [.NET SDK](https://dotnet.microsoft.com/download) instalado (recomendado .NET 6 ou superior).

```bash
# clone o repositório
git clone https://github.com/sauloteixeira-dev/itera360.git

# entre na pasta do projeto
cd "itera360/Desafio c# 2/DesafioC#2"

# execute
dotnet run
```

## 🖥️ Como usar

1. Informe a identificação da tag e os dados do veículo.
2. No menu principal, escolha uma opção:

```
1 - Carregar Tag
2 - Verificar Saldo
3 - Alterar Placa
4 - Passar No Pedágio
5 - Informações do Veículo
6 - Relatórios
s - Sair
```

3. Recarregue saldo antes de passar no pedágio. Se o saldo for insuficiente, a tentativa é registrada e aparece no relatório de tentativas.

> **Observação:** os dados ficam apenas em memória e são perdidos ao encerrar o programa.

## 🔭 Próximos passos

- Persistir passagens e tentativas em arquivo ou banco de dados (por exemplo, PostgreSQL)
- Suportar mais de um veículo e tag
- Adicionar testes automatizados

## 👨‍💻 Autor

**Saulo Teixeira**
[LinkedIn](https://www.linkedin.com/in/sauloteixeira-dev/) · [GitHub](https://github.com/sauloteixeira-dev)
