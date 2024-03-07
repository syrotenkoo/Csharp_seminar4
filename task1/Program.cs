// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

void Main()
{
    InputNumbers();
}

Main();

void InputNumbers()
{
    for(;;)
    {
        Console.Write("Введите целое число: ");
        string str = Console.ReadLine();
        if(str != "q")
        {
            int num = Convert.ToInt32(str);
            int sum = num;
            while(num >= 10)
            {
                num /= 10;
                sum += num;
            }
            sum += num;
            if(sum % 2 == 0) break;
        }
        else break;
    }
    
}