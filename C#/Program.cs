// Написать программу, которая из имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам.

string[] array = Array();
string[] newarray = LengthSize(array);
PrintNewArray(newarray);

string[] Array()
{
    Console.Write("введите количество строк в массиве: ");
    int length = int.Parse(Console.ReadLine());
    string[] array = new string[length];

    for (int i = 0; i < length; i++)
    {
        Console.Write($"введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }
    Console.Write("новый массив: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}/ ");
    }
    return array;
}

string[] LengthSize(string[] array)
{
    string[] newarray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[i] = array[i];
        }
    }
    return newarray;
}

void PrintNewArray(string[] newarray)
{
    Console.WriteLine();
    Console.Write("элементы массива длина которых <= 3: ");

    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] != null)
            Console.Write($"{newarray[i]}/ ");
    }
    Console.WriteLine();
}
