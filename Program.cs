using System;
using System.Globalization;

int[] CreateRandomArray() {
    int[] array = new int[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1,10);
    }
    return array;
}

int GetMaxMark(int[] marks) {
    int max = marks[0]; //create an integer variable max with value of the first element of array
    for (int j = 0; j < marks.Length; j++) //create a loop with an integer variable j = 0, if j < array length, add 1 to j
    {
        int current = marks[j];

        //if current element more than max set current to max
        if (current > max)
        {
            max = current;
        }

    }
    return max;
}

int GetMinMark(int[] marks)
{
    int min = marks[0]; //create an integer variable min with value of the first element of array
    for (int j = 0; j < marks.Length; j++) //create a loop with an integer variable j = 0, if j < array length, add 1 to j
    {
        int current = marks[j];

        //if current element more than max set current to max
        if (current < min)
        {
            min = current;
        }

    }
    return min;
}

double GetAverageMark(int[] marks)
{
    double sum = 0; //create floating point variable sum with value 0
    for (int j = 0; j < marks.Length; j++) //create a loop with an integer variable j = 0, if j < array length, add 1 to j
    {
        int current = marks[j];

        // add current element to the sum
        sum += current;
    }
    // calculate the average
    double average = sum / marks.Length;
    return average;
}
    void WriteStudentPerformance(int[] marks, string name)
{
    if (marks.Length > 0) // condition check: if the length of the array is greater than zero
    {
        int max = GetMaxMark(marks);
        int min = GetMinMark(marks);
        double average = GetAverageMark(marks);

        // show results
        Console.WriteLine($"Student name: {name}");
        Console.WriteLine($"Marks: {String.Join(",", marks)}");
        Console.WriteLine($"Minimum mark is {min}");
        Console.WriteLine($"Maximum mark is {max}");
        Console.WriteLine($"Average mark is {average}\n");
    }
    else
    {
        Console.WriteLine("Massive is empty");
    }
}

int[] Student1 = CreateRandomArray();
int[] Student2 = CreateRandomArray();
int[] Student3 = CreateRandomArray();
int[] Student4 = CreateRandomArray();
int[] Student5 = CreateRandomArray();

WriteStudentPerformance(Student1, "Noah");
WriteStudentPerformance(Student2, "Liam");
WriteStudentPerformance(Student3, "Mason");
WriteStudentPerformance(Student4, "Jacob");
WriteStudentPerformance(Student5, "John Doe");