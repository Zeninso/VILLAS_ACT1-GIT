// See https://aka.ms/new-console-template for more information
// this will divide the two numbers
static double Divide(double a, double b)
{
    if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
    return a / b;
}
