void InputMatrix (int [,,] matrix)
{
    int FirstZnak = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength (2); z++)
            matrix [i,j,z] = FirstZnak++;
        }
    }
}

void PrintMatrix (int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength (2); z++)
        {
            Console.Write($"{matrix[i, j, z]} ({i}, {j}, {z}) \t");
        }
        Console.WriteLine();
        }
    }
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if ((size[0]*size[1]*size[2]) > 99)
{
    Console.WriteLine ("Неверное значение. Попробуйте еще раз:");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[size[0], size[1], size [2]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);