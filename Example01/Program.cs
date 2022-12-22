//получает число с консоли.
//создаёт двумерный массив.
//выводит двумерный массив.
//упорядочивает элементы по убыванию.

//получает число с консоли.
int GetNamber(string message)
{
    int count = 0;
    bool isCorrect = false;
    
    while(!isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out count)) isCorrect = true;
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return count;
}

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

//упорядочивает элементы по убыванию.
void NewArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(1) - 1; l++)
            {
                if(arr[i, l] < arr[i, l + 1])
                {
                    int count = 0;
                    count = arr[i, l];
                    arr[i, l] = arr[i, l + 1];
                    arr[i, l + 1] = count;
                }
            }
        }
    }
}

int x = GetNamber("Введите количество строк: ");
int y = GetNamber("Введите количество столбцов: ");

int [,] Array = GetArray(x, y);
PrintArray(Array);
NewArray(Array);
PrintArray(Array);
