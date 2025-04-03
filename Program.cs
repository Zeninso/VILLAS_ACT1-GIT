// See https://aka.ms/new-console-template for more information
// this will create the remainder when divided the first number to the second number
static double Modulo(double a, double b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero.");
    }
    return a % b;
}
