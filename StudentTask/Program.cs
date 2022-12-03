string[] firstarray = new string[6] { "0", "two", "three", "four", "five", "12345"};
string[] resultarray = new string[firstarray.Length];

Console.Write(" Задан массив: [0, two, three, four, five, 12345 ]");
Console.WriteLine();

void FindThreeStringElements(string[] firstarray, string[] resultarray)
{
    int count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
        if (firstarray[i].Length <= 3)
        {
            resultarray[count] = firstarray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {  
        Console.Write($" {array[i]} ");
    }
    Console.Write("-> Cтроки длина которых меньше или равна 3 символам:");
}

FindThreeStringElements(firstarray, resultarray);
PrintArray(resultarray);

