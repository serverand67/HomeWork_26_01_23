/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int GetOfRowMinSum (int [,] dimensArray)
    {
      int row = 0;
      int minSum = 0;
      for (int i = 0; i < dimensArray.GetLength(1); i++)
        {
            minSum = minSum + dimensArray[0,i];
        }
      for (int i = 1; i < dimensArray.GetLength(0); i++)
        {
            int sumNum = 0;
            for (int j = 0; j < dimensArray.GetLength(1); j++)
              {
                 sumNum = sumNum + dimensArray[i,j];
              }
            if (minSum > sumNum)
               {
                  minSum = sumNum;
                  row = i;
               }
        }
        return row;
    }

int[,] dimensArray = new int [4,4];
SetAnArray(dimensArray);
printDemArr(dimensArray);
Console.WriteLine();  
int result = GetOfRowMinSum(dimensArray);
Console.WriteLine($"Наименьшая сумма чисел в строке {result}");