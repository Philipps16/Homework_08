void InputMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix [i,j] = new Random (). Next (0, 21);
    }
}

void PrintMatrix (int [,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    
}


void ReleaseMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1)-1; n++)
            {                
                if (matrix [i, n] < matrix[i, n + 1])
                {
                    int t = 0;
                    t = matrix[i, n + 1];
                    matrix[i, n + 1] = matrix [i, n];
                    matrix [i, n] = t;
                }
            }
        }
    }
}



Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
ReleaseMatrix (matrix);
Console.WriteLine("Итоговый массив:");
PrintMatrix(matrix);