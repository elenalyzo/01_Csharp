int n = 10;
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int i = 0;

while(i < n)
{
    if(array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
