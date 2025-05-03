Console.Write("Enter value of a : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value of b : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value of c : ");
int c = Convert.ToInt32(Console.ReadLine());

Double x;

int D = (b * b) - (4*a*c);
if (D == 0)
{
       x = -b / (2 * a);
   System.Console.WriteLine("The only real root for the equation is = {0}", x);
}
else
{
    if (D > 0 )
    {
        Double x1 = (-b - Math.Sqrt(D))/ (2*a) ;
        Double x2 = (-b + Math.Sqrt(D))/ (2*a);
        System.Console.WriteLine("The equation has two roots {0} , {1}" , x1 , x2 );
    }
    else
    {
        System.Console.WriteLine("The Equation has no real root");
    }
}

