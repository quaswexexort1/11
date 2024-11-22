Console.Write("Введите размерность матрицы (n): ");
int n = int.Parse(Console.ReadLine());

int[,] A = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i + j == n - 1)
        {
            A[i, j] = 1;
        }
        else if (i + j < n - 1)
        {
            A[i, j] = 0;
        }
        else
        {
            A[i, j] = 2;
        }
    }
}



Console.WriteLine("Полученная матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}