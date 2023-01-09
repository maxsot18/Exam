// Написать программу, которая из массива строк 
// формирует массив из строк, 
// длина которых не более 3 символов.

string Input(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
void ArrayWithMax3Digit(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[index] = array1[i];
            index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

string[] arr1 = { Input("Enter a word"), Input("Enter a word"), Input("Enter a word"), Input("Enter a word"), Input("Enter a word") };
string[] arr2 = new string[arr1.Length];
ArrayWithMax3Digit(arr1, arr2);
Console.Write($"Array with input values is ");
PrintArray(arr1);
Console.Write($"Array with values three or less digits is ");
PrintArray(arr2);
