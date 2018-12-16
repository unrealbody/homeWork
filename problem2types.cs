using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace casting
{
class Program
{
static void Main( string [] args)
{
	char a,b;
	Console.WriteLine("Enter first character:");
	a=char.Parse(Console.ReadLine());
	Console.WriteLine("Enter second character:");
	b=char.Parse(Console.ReadLine());
	Console.WriteLine("the sum of these is:"+(a+b));
	Console.WriteLine("the multiplication of these is:"+(a*b));
}
}
}
