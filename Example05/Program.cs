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

//выводит массив.
void PrintArray (int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={arr[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

//заполняет массив.
void GetArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = GetNamber("Введите X: ");
int y = GetNamber("Введите Y: ");
int z = GetNamber("Введите Z: ");
Console.WriteLine();

int[,,] Array = new int[x, y, z];
GetArray(Array);
PrintArray(Array);
