// Задача 29: Напишите программу, которая задаёт массив из (8) произвольного количества ?? элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateRandomArray(int size_array)
{
    int [] randomArray = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        randomArray [i] = new Random().Next(0, 100);
    }
    return randomArray;
}

void PrintArray(int [] array_to_print)
{
    Console.Write("Your array is: [");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write(array_to_print[i] + ", ");
}

int size = new Random().Next(1,11);
int [] firstArray = CreateRandomArray(size);
PrintArray(firstArray);
Console.Write("\b\b]");