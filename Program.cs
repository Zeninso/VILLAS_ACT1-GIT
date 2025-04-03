// See https://aka.ms/new-console-template for more information

static bool ContinueCalculation()
{
    Console.Write("Do you want to perform another calculation? (y/n): ");
    string response = Console.ReadLine().ToLower();
    return response == "y" || response == "yes";
}