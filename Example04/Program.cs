int [,] Array = new int [4, 4];
int count = 1;
int i = 0;
int j = 0;

while (count <= Array.GetLength(0) * Array.GetLength(1))
{
  Array[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Array.GetLength(1) - 1)
    j--;
  else
    i--;
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

PrintArray(Array);