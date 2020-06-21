# Pipelines

Nesta seção é feito uma breve demonstração do uso de pipeline com F#. Em paralelo, há exemplos em C# e JS para demonstrar algumas similaridades com este recurso.

## [F#](https://github.com/ghiorzi/Functional-Programming/blob/master/1.%20Pipelines/F%20Sharp/Program.fsx)

```fsharp
open System

let numbers = [1..10]

let isEven number = number % 2 = 0

let square number = number * number

let sumEvenNumbers values =
    values
    |> List.filter isEven
    |> List.map square
    |> List.sum

numbers |> sumEvenNumbers |> printf "%d"
```

### Execução

``dotnet fsi Program.fsx``

## [C#](https://github.com/ghiorzi/Functional-Programming/blob/master/1.%20Pipelines/C%20Sharp/Program.cs)

```csharp
using System;
using System.Linq;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Enumerable
                                .Range(1, 10)
                                .Where(number => number % 2 == 0)
                                .Select(number => number * number)
                                .Aggregate((a,b) => a + b);
            
            Console.WriteLine(sum);
        }
    }
}
```
### Execução

``dotnet run``

### [JS](https://github.com/ghiorzi/Functional-Programming/blob/master/1.%20Pipelines/Js/index.js)

```javascript

const sum = [...Array(10).keys()]
                                 .map(i => i + 1)
                                 .filter(number => number % 2 === 0)
                                 .map(number => number * number)
                                 .reduce((a,b) => a + b);

console.log(sum);

```

### Execução

``node index.js``
