const sum = [...Array(10).keys()]
                                 .map(i => i + 1)
                                 .filter(number => number % 2 === 0)
                                 .map(number => number * number)
                                 .reduce((a,b) => a + b);

console.log(sum);