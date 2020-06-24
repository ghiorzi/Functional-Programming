// função binária pura
const multiply = (a, b) => a * b;

console.log(multiply(2, 4)); // 8
console.log(multiply(3, 7)); // 21

// função de alta ordem que retorna outra função
const multiplyBy = factor => number => factor * number;

// partial application
const multiplyBy2 = multiplyBy(2);

[2, 7, 9]
    .map(multiplyBy2)
    .forEach(value => console.log(value));

// Ainda podemos aplicar todos os parâmetros
console.log(multiplyBy(2)(9)); // 18

/*

partial application

const multiply = a => (b, c) => a * b * c;

const multiplyBy2 = multiply(2);

console.log(multiplyBy2(4, 6)); // 48


currying

const multiply = a => b => c => a * b * c;

const multiplyBy2 = multiply(2);
const multiply2By4 = multiplyBy2(4);

console.log(multiply2By4(6)); // 48
*/
