int[] estimals = { 8, 7, 6, 4, 7, 5, 7, 10, 7, 7 }; //create an array

if (estimals.Length > 0) // condition check: if the length of the array is greater than zero
{
    double sum = 0; //create floating point variable sum with value 0
    int max = estimals[0]; //create an integer variable max with value of the first element of array
    int min = estimals[0]; //create an integer variable min with value of the first element of array
    for (int j = 0; j < estimals.Length; j++) //create a loop with an integer variable j = 0, if j < array length, add 1 to j
    {
        int current = estimals[j];

        // add current element to the sum
        sum += current;

        //if current element more than max set current to max
        if (current > max)
        {
            max = current;
        }
        //if current element less than min set current to min
        if (current < min)
        {
            min = current;
        }
    }
    // calculate the average
    double average = sum / estimals.Length;

    // show results
    Console.WriteLine($"Minimum estimals is {min}");
    Console.WriteLine($"Maximum estimals is {max}");
    Console.WriteLine($"Average estimals is {average}");
}
else
{
    Console.WriteLine("Massive is empty");
}
