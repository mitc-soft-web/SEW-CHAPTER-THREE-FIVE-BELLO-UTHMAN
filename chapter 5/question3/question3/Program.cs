int firstNumber = 10;
int secondNumber = 20;
int thirdNumber = 40;
if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine("The biggest number is {0}", firstNumber );
}
else
{
    if (secondNumber > firstNumber && secondNumber > thirdNumber)
    {
        Console.WriteLine("The biggest number is {0}", secondNumber );
    }
    else
    {
        Console.WriteLine("The biggest number is {0}", thirdNumber );
    }
}