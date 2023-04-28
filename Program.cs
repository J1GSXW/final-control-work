﻿string[] CreateStringArray()
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[size];
    int i = 0;
    while(i < size)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        string? element = Console.ReadLine()??String.Empty;
        stringArray[i] = element;
        i++;
    }
    return stringArray;
}


string[] LessThenThreeSymbols(string[] array)
{
    string[] newArray = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}


