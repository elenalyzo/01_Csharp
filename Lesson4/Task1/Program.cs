int[,] malrix = new int[3, 5];
Random rnd = new Random();
for (int i = 0; i < malrix.GetLength(0); i++)
{
    for (int j = 0; j < malrix.GetLength(1); j++)
    {
        malrix[i, j] = rnd.Next(1, 11);
    }
}

for (int i = 0; i < malrix.GetLength(1); i++)
{
    for (int j = 0; j < malrix.GetLength(0); j++)
    {
        Console.Write($"{malrix[i, j]} ");
    }
System.Console.WriteLine();
}