function sortNumbers(array){
let sortedArray = array.sort((e1, e2) => {
    return e1-e2;
});
let length = array.length;

let resultArray = [];
    for(let index = 0; index <= length - 1; index++){
        if(index % 2 == 0)
        {
            resultArray.push(sortedArray.shift());
        } else{
            resultArray.push(sortedArray.pop());
        }
    }
    return resultArray;
    //console.log(resultArray);
}

sortNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);