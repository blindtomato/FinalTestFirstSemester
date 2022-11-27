string[] fillArray(int length)
    {
        string[] array = new string[length];
        for(int i = 0; i < length; i++)
        {
            Console.WriteLine($"Введите {i + 1} элемент массива");
            array[i] = Console.ReadLine();
        }
        return array;
    }

void PrintArray(string[] array)
{
    Console.Write("[");
    Console.Write(string.Join(", ", array));
    Console.WriteLine("]");
}

int CountElements(string[] array)
{
    int result = 0;
    foreach (string value in array)
    {
        if (value.Length <= 3)
            result++;
    }
    return result;
}

string[] DeleteElements(string[] array)
{
    int length = CountElements(array);
    string[] arrayResult = new string[length];
    int i = 0;
    foreach (string value in array)
    {
        if (value.Length <= 3)
        {
            arrayResult[i++] = value;            
        }
    }
    return arrayResult;
}

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = fillArray(n);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine("Результирующий массив");
PrintArray(DeleteElements(array));
