double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a - b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}
double result = CalculateFormula(15, 8, 3, 4);
System.Console.WriteLine(result);