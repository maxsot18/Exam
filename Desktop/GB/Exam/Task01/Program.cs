// Задача 1. Найти сумму всех элементов,
//  между введенными числами. 
//  (Введеные числа тоже суммируем)

int Input(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int value1, int value2)
{
    if (value1 == value2)
    {
        return value2;
    }
    return value1 + Sum(value1 + 1, value2);
}

int number1 = Input("Enter a first value");
int number2 = Input("Enter a second value");
Console.WriteLine($"Sum of values between {number1} and {number2} = {Sum(number1, number2)}");

