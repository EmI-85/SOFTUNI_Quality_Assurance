function rotateArray (array, countRotations){
    for(let count = 1; count<= countRotations; count++){
        let firstElement = array.shift();
        array.push(firstElement); 
    }
    console.log(array.join(' '));
}

rotateArray([51, 47, 32, 61, 21], 2);