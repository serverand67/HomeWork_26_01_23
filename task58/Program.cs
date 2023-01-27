/*Задача 58: Задайте две матрицы.
Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] GetMultiplMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
       {
          for (int j = 0; j < matrix2.GetLength(1); j++)
           {
             for (int k = 0; k < matrix1.GetLength(1); k++)
               {
                  matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
               }
           }
       }
    return matrix3;
}

int[,] matrix1 = new int [2,2];
int[,] matrix2 = new int [2,2];
SetAnArray(matrix1);
SetAnArray(matrix2);
printDemArr(matrix1);
Console.WriteLine();
printDemArr(matrix2);
Console.WriteLine();
int[,] matrix3 = GetMultiplMatrix(matrix1, matrix2);
printDemArr(matrix3); 