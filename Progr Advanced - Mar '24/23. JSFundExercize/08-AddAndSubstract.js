function solve(n1, n2, n3){
    //console.log((n1+ n2) - n3);
    const sum = (firstNum, secondNum) => firstNum + secondNum;
    const subtract = (firstNum, secondNum) => firstNum - secondNum;

    const sumNumbers = sum(n1, n2);
    const result = subtract(sumNumbers, n3);

    console.log(result);
};

solve(23, 6 , 10);