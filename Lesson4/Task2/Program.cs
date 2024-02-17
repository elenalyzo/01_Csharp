// Создать двухмерный массив, к. состоит и целых чисел.
// Вывести на экран "интересные" эл-ты массива.
//"Интересные" - это числа сумма, которых четная

int[,] CreateMatrix(int rowsCount, int columsCount)
{
    int[,] matrix = new int[rowsCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInterestihg(e) == true)
    {
       Console.WriteLine($"{e} ");
    }
}

bool IsInterestihg(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }    
        return false;
}

 int GetSumOfDigits(int value)
 {
    int sum = 0;
    while (value >0)
    {
        sum += value % 10;
        value /=10;
    }
    return sum;
 }

