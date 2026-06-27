// See https://aka.ms/new-console-template for more information
int [,] matrix = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
int [,] matrix2 = new int[3, 3]
{
    { 9, 8, 7 },
    { 6, 5, 4 },
    { 3, 2, 1 }
};
Console.WriteLine("Matrix 1: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Matrix 2: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Sum of Matrix 1 and Matrix 2: ");
int [,] sumMatrix = new int[3, 3];  
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        sumMatrix[i, j] = matrix[i, j] + matrix2[i, j];
        Console.Write(sumMatrix[i, j] + " ");
    }
    Console.WriteLine();
}