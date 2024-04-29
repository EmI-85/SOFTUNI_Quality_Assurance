function printAndSum(startNum, endNum){
    let textForPrint = '';
    let sum = 0;
    for(let number = startNum; number <= endNum; number++) {
        textForPrint += number + ' ';
        sum += number;
    }
    console.log(textForPrint.trim());
    console.log('Sum: ' + sum);
}

printAndSum(5, 10);