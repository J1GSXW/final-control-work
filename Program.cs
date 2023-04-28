string[] CreateStringArray()
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



