double[] inputArray = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();

int middleRightElement = inputArray.Length / 2;
int middleLeftElement = middleRightElement - 1;

double average = (inputArray[middleRightElement] + inputArray[middleLeftElement]) / 2;

Console.WriteLine($"{average:F2}");