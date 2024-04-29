function cookNumbers(number, firstOp, secondOp, thirdOp, fourthOp, fifthOp){
    number = executeOperation(number, firstOp);
    console.log(number);
    number = executeOperation(number, secondOp);
    console.log(number);
    number = executeOperation(number, thirdOp);
    console.log(number);
    number = executeOperation(number, fourthOp);
    console.log(number);
    number = executeOperation(number, fifthOp);
    console.log(number);

    function executeOperation(number, operation){
        switch(operation){
            case 'chop':
                number /= 2;
                break;
            case 'dice':
                number = Math.sqrt(number);
                break;
            case 'spice':
                number += 1;
                break;
            case 'bake':
                number *= 3;
                break;
            case 'fillet':
                number *= 0.8;
                break;
        }
    return number;
}
}

cookNumbers(9, 'dice', 'spice', 'chop', 'bake', 'fillet');

