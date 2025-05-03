Console.Write("Enter numbers 0-2 for any of this variable(0-int, 1-double, 2-string): ");
int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case 0:
    Console.Write("Enter your integer number : ");
    int intVar = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(intVar + 1);
    break;
    case 1:
    Console.Write("Enter your double number : ");
    double doubVar= Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(doubVar + 1);
    break;
    case 2:
    Console.Write("enter your string : ");
    string? strVAr = Console.ReadLine();
    System.Console.WriteLine(strVAr + "*");
    break;
    default :
    Console.Write("Wrong input");
    break;
}
