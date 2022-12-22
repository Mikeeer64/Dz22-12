//создаёт двумерный массив.
int [,] GetArray(int x, int y)
{
    int [,] arr = new int[x, y];
    Random asd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = asd.Next(1, 10);
        }
    }
    return arr;
}

//выводит двумерный массив.
void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//считает сумму элементов каждой строки.
int GetMinStrok(int [,] arr)
{
    int count = 0;
    int min = 0;
    int x = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            count += arr[i, j];
        }
        if(min == 0)
        {
            min = count;
            x = i + 1;
        }
        else if(min != 0)
        {
            if(min > count)
            {
                min = count;
                x = i + 1;
            }
        }
        count = 0;
    }
    return x;
}

int [,] Array = GetArray(6, 4);
PrintArray(Array);
int namber = GetMinStrok(Array);
Console.WriteLine($"Строка №{namber} имеет самую маленькую сумму элементов.");