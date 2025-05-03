int  firstNumber= 10;
int secondNumber = 6;
Console.WriteLine("First number = {0}", firstNumber);
Console.WriteLine("Second number = {0}", secondNumber);
if (firstNumber > secondNumber){
    int oldFirst = firstNumber ;
    firstNumber = secondNumber;
    secondNumber = oldFirst;
    Console.WriteLine("First number after swap = {0}",firstNumber);
    Console.WriteLine("Seond number after swap = {0}", secondNumber); 
}