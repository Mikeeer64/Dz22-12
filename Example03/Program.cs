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

//находит произведение двух матриц.
int [,] GetNewArray (int[,] array, int[,] arr)
{
    int [,] arrnew = new int [arr.GetLength(0), arr.GetLength(1)];
    int namber = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            namber = array[i, j] * arr[i, j];
            arrnew[i, j] = namber;
            namber = 0;
        }
    }
    return arrnew; 
}


int [,] Array = GetArray(5, 5);
PrintArray(Array);
int [,] arr = GetArray(5, 5);
PrintArray(arr);
int [,] arrnew = GetNewArray(Array, arr);
PrintArray(arrnew);