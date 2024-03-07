// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    Console.Write("Введите длину массива: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[arraySize];

    CreateRandomArray(arr);

    Console.WriteLine("Исходный массив:");
    PrintArray(arr);

    InvertArray(arr);

    Console.WriteLine("\nПеревернутый массив:");
    PrintArray(arr);
}

Main();

void CreateRandomArray(int[] arr)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void InvertArray(int[] arr)
{
    int b;
    for(int i = 0; i < arr.Length / 2; i++)
    {
        b = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = b;
    }
}