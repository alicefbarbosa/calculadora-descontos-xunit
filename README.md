# Calculadora de Descontos

Projeto desenvolvido em C# com .NET 10, utilizando testes unitários com xUnit.

## Sobre o projeto

A aplicação tem como objetivo calcular descontos de acordo com as regras definidas no serviço de descontos.

O projeto foi desenvolvido com foco na implementação da lógica de negócio e na criação de testes unitários para validar diferentes cenários da aplicação.

## Fact x Theory

- O `[Fact]` é utilizado para testes que possuem um único cenário e não recebem parâmetros.

- O `[Theory]` é utilizado para testes parametrizados, permitindo executar o mesmo teste várias vezes com diferentes dados fornecidos por meio do `[InlineData]`.

## Tecnologias utilizadas

- C#
- .NET 10
- xUnit
- Git
- GitHub

## Estrutura do projeto

```text
CalculadoraDescontos/
├── CalculadoraDescontos.App/
│   ├── DescontoService.cs
│   ├── Program.cs
│   └── CalculadoraDescontos.App.csproj
│
├── CalculadoraDescontos.Tests/
│   ├── DescontoServiceTests.cs
│   └── CalculadoraDescontos.Tests.csproj
│
├── CalculadoraDescontos.slnx
├── .gitignore
└── LICENSE
```

## Testes

Os testes unitários foram desenvolvidos utilizando xUnit.

Para executar os testes:

```bash
dotnet test
```

### Resultado dos testes

- **12 testes executados**
- **12 testes aprovados**
- **0 testes com falha**
- **0 testes ignorados**

## Cobertura de código

A cobertura de código foi gerada utilizando XPlat Code Coverage e ReportGenerator.

### Resultado

- **Cobertura de linhas: 94,1%**
- **Cobertura de branches: 100%**

Para gerar a cobertura:

```bash
dotnet test --collect:"XPlat Code Coverage"
```

Depois, para gerar o relatório:

```bash
reportgenerator -reports:"CalculadoraDescontos.Tests\TestResults\*\coverage.cobertura.xml" -targetdir:coveragereport
```

O relatório pode ser visualizado abrindo:

```text
coveragereport/index.html
```

## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais informações.

---

## Autora

- Alice Fernandes Barbosa - @alicefbarbosa - 326128348

**Atividade da disciplina de Gestão e Qualidade de Software.**
