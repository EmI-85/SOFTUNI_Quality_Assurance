function printElement(array, step){
    let resultArray = [];

     for(index = 0; index <= array.length -1;  index += step ){
        resultArray.push(array[index]);
     }
     return resultArray;
}

printElement(['5', 
'20', 
'31', 
'4', 
'20'], 
2
);