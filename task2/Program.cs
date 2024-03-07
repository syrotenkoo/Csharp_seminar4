// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел 
// в массиве

void Main()
{
    Console.Write("Введите длину массива: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[arraySize];

    CreateRandomArray(arr);
    PrintArray(arr);

    int res = CountEvenNumbers(arr);
    Console.Write($"\nКоличество чётных чисел в массиве: {res}");

}

Main();

void CreateRandomArray(int[] arr)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }

    return count;
}