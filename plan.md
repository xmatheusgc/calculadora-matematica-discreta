# Plano de Implementação — Projeto de Matemática Discreta

## C# .NET 8 + Windows Forms

---

# Visão Geral

O projeto será desenvolvido utilizando:

* Linguagem: C#
* Framework: .NET 8
* Interface: Windows Forms

A aplicação possuirá uma interface gráfica amigável contendo 3 módulos principais:

1. Calculadora de Bases
2. Algoritmo Estendido de Euclides
3. Crivo de Eratóstenes

A ideia principal é separar:

* Interface gráfica
* Lógica matemática
* Exibição dos passos

Isso deixa o projeto:

* organizado
* fácil de manter
* fácil de apresentar
* ideal para desenvolvimento com IA

---

# Estrutura Recomendada do Projeto

```txt
Projeto/
│
├── Forms/
│   ├── MainForm.cs
│   ├── BaseCalculatorForm.cs
│   ├── EuclidesForm.cs
│   └── EratostenesForm.cs
│
├── Services/
│   ├── BaseConverterService.cs
│   ├── BaseOperationsService.cs
│   ├── ExtendedEuclidService.cs
│   └── EratosthenesService.cs
│
├── Models/
│   ├── ConversionResult.cs
│   ├── EuclidResult.cs
│   └── SieveResult.cs
│
└── Program.cs
```

---

# Organização Geral

## Regra principal

Cada algoritmo deverá retornar:

* resultado final
* lista de passos

Exemplo:

```csharp
public class ConversionResult
{
    public string Result { get; set; }
    public List<string> Steps { get; set; }
}
```

---

# PROGRAMA 1 — Calculadora de Bases

# Objetivos

O programa deverá:

## Conversões

Permitir conversão entre:

* Decimal
* Binário
* Hexadecimal

Exemplos:

* Binário → Decimal
* Decimal → Hexadecimal
* Hexadecimal → Binário

---

## Operações

Permitir:

* soma
* subtração
* multiplicação

Entre dois números na mesma base.

---

# Estratégia Recomendada

## Conversões

Sempre converter:

```txt
Origem → Decimal → Destino
```

Isso simplifica bastante a implementação.

---

# Conversões Necessárias

## Decimal → Binário

Método:

* divisões sucessivas por 2

Exemplo:

```txt
13 / 2 = 6 resto 1
6 / 2 = 3 resto 0
3 / 2 = 1 resto 1
1 / 2 = 0 resto 1

Resultado: 1101
```

---

## Decimal → Hexadecimal

Método:

* divisões sucessivas por 16

---

## Binário → Decimal

Método:

* soma das potências de 2

Exemplo:

```txt
1011

1×2³ = 8
0×2² = 0
1×2¹ = 2
1×2⁰ = 1

Resultado: 11
```

---

## Hexadecimal → Decimal

Método:

* soma das potências de 16

Conversões:

* A = 10
* B = 11
* C = 12
* D = 13
* E = 14
* F = 15

---

# Operações em Bases

## Estratégia recomendada

Converter:

```txt
Base X → Decimal
Realiza operação
Decimal → Base X
```

---

# Regra da Subtração

Caso:

```txt
a < b
```

O programa poderá retornar:

```txt
"Esse tipo de operação não é suportada."
```

---

# Interface Recomendada

## Aba 1 — Conversão

Componentes:

* TextBox valor
* ComboBox base origem
* ComboBox base destino
* Button converter
* RichTextBox passos
* Label resultado

---

## Aba 2 — Operações

Componentes:

* TextBox valor A
* TextBox valor B
* ComboBox base
* ComboBox operação
* Button calcular
* Label resultado

---

# PROGRAMA 2 — Algoritmo Estendido de Euclides

# Objetivos

Dado dois números inteiros:

```txt
a e b
```

O programa deverá:

* calcular o MDC(a,b)
* mostrar o passo a passo
* encontrar:

```txt
mdc(a,b) = sa + tb
```

Onde:

* s e t são inteiros

---

# Estrutura Recomendada

```csharp
public class EuclidResult
{
    public int Gcd { get; set; }

    public int S { get; set; }

    public int T { get; set; }

    public List<string> Steps { get; set; }
}
```

---

# Algoritmo

## Parte 1 — Algoritmo de Euclides

Mostrar todas as divisões.

Exemplo:

```txt
252 = 105×2 + 42
105 = 42×2 + 21
42 = 21×2 + 0
```

---

## Parte 2 — Algoritmo Estendido

Usar variáveis:

```txt
old_r, r
old_s, s
old_t, t
```

Implementação iterativa clássica.

---

# Resultado Final

Exemplo:

```txt
mdc(252,105)=21

21 = 1×252 + (-2)×105
```

---

# Interface Recomendada

Componentes:

* TextBox A
* TextBox B
* Button calcular
* RichTextBox passos
* Label resultado final

---

# PROGRAMA 3 — Crivo de Eratóstenes

# Objetivos

O programa deverá:

* encontrar todos os primos menores que n
* mostrar o passo a passo do método

---

# Estrutura Recomendada

```csharp
public class SieveResult
{
    public List<int> Primes { get; set; }

    public List<string> Steps { get; set; }
}
```

---

# Algoritmo

## Vetor booleano

```csharp
bool[] prime = new bool[n + 1];
```

Inicialmente:

* todos true
* exceto 0 e 1

---

# Processo

Para cada primo encontrado:

```txt
2 é primo
Removendo múltiplos:
4,6,8,10...

3 é primo
Removendo:
6,9,12...
```

---

# Resultado Final

```txt
Primos menores que 30:

2,3,5,7,11,13,17,19,23,29
```

---

# Interface Recomendada

Componentes:

* TextBox N
* Button executar
* RichTextBox passos
* Label/lista de primos

---

# Organização Correta do Código

## NÃO misturar:

* interface
* lógica matemática

---

# Exemplo Correto

## Form

```csharp
private void btnConverter_Click(object sender, EventArgs e)
{
    var service = new BaseConverterService();

    var result = service.Convert(...);

    txtPassos.Text = string.Join("\n", result.Steps);
}
```

---

## Service

```csharp
public ConversionResult Convert(...)
{
    // matemática aqui
}
```

---

# Validações Importantes

## Binário

Aceitar apenas:

* 0
* 1

---

## Hexadecimal

Aceitar:

* 0-9
* A-F

---

# NÃO usar bibliotecas prontas

Evitar:

```csharp
Convert.ToString(numero, 2)
```

ou:

```csharp
Convert.ToInt32(valor, 2)
```

O objetivo é implementar os algoritmos manualmente.

---

# Plano de Desenvolvimento

# ETAPA 1 — Criar projeto

Criar:

* projeto Windows Forms
* TabControl com 3 abas

Abas:

* Calculadora de Bases
* Euclides Estendido
* Crivo de Eratóstenes

---

# ETAPA 2 — Conversões

Implementar:

* decimal → binário
* binário → decimal
* decimal → hexadecimal
* hexadecimal → decimal

Com:

* resultado
* passo a passo

---

# ETAPA 3 — Operações

Implementar:

* soma
* subtração
* multiplicação

Estratégia:

* converter para decimal
* realizar operação
* converter de volta

---

# ETAPA 4 — Euclides

Implementar:

* algoritmo de Euclides
* algoritmo estendido
* identidade de Bézout

---

# ETAPA 5 — Crivo

Implementar:

* vetor booleano
* remoção de múltiplos
* exibição dos passos

---

# ETAPA 6 — Integração com Interface

Conectar:

* botões
* entradas
* serviços matemáticos

Mostrar:

* resultado
* passo a passo

---

# Sugestões Visuais

Usar:

* TabControl
* GroupBox
* RichTextBox
* Labels organizadas

---

# Nível de Dificuldade

## Fácil

* Crivo de Eratóstenes

## Médio

* Conversões

## Médio/Alto

* Algoritmo Estendido de Euclides

---

# Recomendação Final

Fazer:

## Um único projeto

Com:

* 3 abas

Em vez de:

* 3 projetos separados

Vantagens:

* mais profissional
* melhor apresentação
* código centralizado
* interface mais organizada
