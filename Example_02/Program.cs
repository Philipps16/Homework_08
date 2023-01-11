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


int ReleaseMatrix (int [,] matrix)
{
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        minSum += matrix[0, i];

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSum > sum)
            minSum = sum;
    }
    return minSum;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (size [0] == size [1])
{
    Console.Write("Размер не должен быть квадратным. Введите размер матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
Console.WriteLine($"Минимальная сумма чисел в строке: {ReleaseMatrix (matrix)}");