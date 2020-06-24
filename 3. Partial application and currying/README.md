# Partial application e currying

Nesta seção é feito uma breve demonstração de composição com F#.

## [F#](https://github.com/ghiorzi/Functional-Programming/blob/master/3.%20Partial%20application%20and%20currying/F%20Sharp/Program.fsx)

```fsharp
let multiplyBy = (*)

let multiplyBy2 = multiplyBy 2

[2;7;9] |> List.map multiplyBy2 |> printfn "%A" // 4, 14, 18

multiplyBy 2 9 |> printfn "%d" // 18
```

### Execução

``dotnet fsi Program.fsx``

## [JS](https://github.com/ghiorzi/Functional-Programming/blob/master/3.%20Partial%20application%20and%20currying/JS/index.js)

### Partial application e currying

```javascript
// função de alta ordem que retorna outra função
const multiplyBy = factor => number => factor * number;

// partial application
const multiplyBy2 = multiplyBy(2);

[2, 7, 9]
         .map(multiplyBy2)
         .forEach(value => console.log(value));

// Ainda podemos aplicar todos os parâmetros
console.log(multiplyBy(2)(9)); // 18
```
### Partial application

```javascript
const multiply = a => (b, c) => a * b * c;

const multiplyBy2 = multiply(2);

console.log(multiplyBy2(4, 6)); // 48
```

### Currying

```javascript
const multiply = a => b => c => a * b * c;

const multiplyBy2 = multiply(2);
const multiply2By4 = multiplyBy2(4);

console.log(multiply2By4(6)); // 48
```
