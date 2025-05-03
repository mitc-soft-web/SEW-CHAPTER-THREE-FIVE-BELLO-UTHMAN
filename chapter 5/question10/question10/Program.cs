Console.Write("Enter a number from 1 - 9 : ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
    Console.WriteLine("multiplication by 10= {0}", number*10);
    break;
      case 2:
    Console.WriteLine("multiplication by 10= {0}", number*10);
    break;
      case 3:
    Console.WriteLine("multiplication by 10= {0}", number*10);
    break;
      case 4:
    Console.WriteLine("multiplication by 100= {0}", number*100);
    break;
      case 5:
    Console.WriteLine("multiplication by 100= {0}", number*100);
    break;
      case 6:
    Console.WriteLine("multiplication by 100= {0}", number*100);
    break;
      case 7:
    Console.WriteLine("multiplication by 1000= {0}", number*1000);
    break;
      case 8:
    Console.WriteLine("multiplication by 1000= {0}", number*1000);
    break;
      case 9:
    Console.WriteLine("multiplication by 1000= {0}", number*1000);
    break;
    default:
    Console.WriteLine("The number is invalid");
    break;
}