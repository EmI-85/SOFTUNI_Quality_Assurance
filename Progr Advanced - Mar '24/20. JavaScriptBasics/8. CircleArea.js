function calculateCircleArea(radius){
    let inputType = typeof radius;

    if(inputType === 'number'){
        let area = Math.PI * radius ** 2;
        console.log(area.toFixed(2));
    } else{
        console.log(`We can not calculate the circle area, because we received a ${inputType}.`);
    }
}

calculateCircleArea(5);
calculateCircleArea('name');