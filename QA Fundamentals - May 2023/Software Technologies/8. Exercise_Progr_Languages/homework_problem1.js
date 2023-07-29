function calculateRectangleArea(length, width) {
    const area = length * width;
    return area;
  }
  
  const length = 10; // in cm
  const width = 5; // in cm
  
  const areaValue = calculateRectangleArea(length, width);
  
  console.log("The area of the rectangle is: " + areaValue + " sq.cm.");
  