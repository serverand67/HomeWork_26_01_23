/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void SetAnArray( int[,] dimensArray)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimensArray.GetLength(1); j++)
        {
            dimensArray[i,j] = new Random().Next(1,10);;
        }
    }
}
void printDemArr(int[,] dimensArray)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimensArray.GetLength(1); j++)
        {
            Console.Write($"{dimensArray[i, j]} ");
        }
        Console.WriteLine("");
    }
}
void OrderOfDimensArrayRow(int[,] dimensArray)
{
  for (int i = 0; i < dimensArray.GetLength(0); i++)
  {
    for (int j = 0; j < dimensArray.GetLength(1); j++)
    {
      for (int k = 0; k < dimensArray.GetLength(1) - 1; k++)
      {
        if (dimensArray[i, k] < dimensArray[i, k + 1])
        {
          int tmp = dimensArray[i, k + 1];
          dimensArray[i, k + 1] = dimensArray[i, k];
          dimensArray[i, k] = tmp;
        }
      }
    }
  }
}

int[,] dimensArray = new int [3,4];
SetAnArray(dimensArray);
printDemArr(dimensArray);
Console.WriteLine();
OrderOfDimensArrayRow(dimensArray);
printDemArr(dimensArray);  
