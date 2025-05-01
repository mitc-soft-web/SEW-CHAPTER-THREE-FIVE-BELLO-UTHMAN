Console.Write("Enter point x: ");
int pointX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter point Y: ");
int pointY = Convert.ToInt32(Console.ReadLine());
if (pointX * pointX + pointY * pointY <= 5*5)
{
 Console.WriteLine("The Point is inside the circle ");

}
else
{
    Console.WriteLine("The point is not in the circle ");
}