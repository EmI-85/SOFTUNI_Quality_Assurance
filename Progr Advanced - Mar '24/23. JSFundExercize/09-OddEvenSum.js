function OddAndEvenSum(inputNumber) {
    let oddSum = 0;
    let evenSum = 0;

    while (inputNumber > 0) {
        const currentDigit = inputNumber % 10;

        if (currentDigit % 2 === 0) {
            evenSum += currentDigit; 
        } else {
            oddSum += currentDigit; 
        }

        inputNumber = Math.floor(inputNumber / 10);
    }
   console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
};

OddAndEvenSum(1000435);
OddAndEvenSum(3495892137259234);