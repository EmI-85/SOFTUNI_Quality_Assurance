function checkAndPrintSum(number){
    let sum = 0;
    let digit = number % 10;
    let areTheSame = true;
    
    while(number > 0){
        let lastDigit = number % 10;
        sum += lastDigit;

        if(lastDigit != digit){
            areTheSame = false;
        }
        number = Math.floor(number / 10);
    }
    console.log(areTheSame);
    console.log(sum);
}

checkAndPrintSum(2222222);
checkAndPrintSum(1234)