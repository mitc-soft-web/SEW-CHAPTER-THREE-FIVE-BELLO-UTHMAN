int firstNumber = 1000;
int secondNumber = 801;
int thirdNumber = 500;
int fourthNumber = 805;
int fifthNumber = 600;
if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
{
    Console.WriteLine("The biggest number is {0}", firstNumber );
}
else
{
    if (secondNumber > firstNumber && secondNumber > thirdNumber
     && secondNumber > fourthNumber && secondNumber > fifthNumber)
    {
        Console.WriteLine("The biggest number is {0}", secondNumber );
    }
    else if(thirdNumber > firstNumber && thirdNumber > secondNumber
     && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
    {
        Console.WriteLine("The biggest number is {0}", thirdNumber );
    }
    else if (fourthNumber > secondNumber && fourthNumber > thirdNumber
     && fourthNumber > firstNumber && fourthNumber > fifthNumber)
    {
        Console.WriteLine("The biggest number is {0}", fourthNumber);
    }
    else
    {
        Console.WriteLine("The biggest number is {0}", fifthNumber);
    }
}