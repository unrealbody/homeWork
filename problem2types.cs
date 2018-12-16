using System;
namespace program{
class program{
static void Main(){
	char a,b;
	Console.WriteLine("type first character:");
	a = char.Parse(Console.ReadLine());
	
	Console.WriteLine("type second character:");
	b = char.Parse(Console.ReadLine());

	Console.WriteLine("sum is: " + (a+b));
	Console.WriteLine("multiplication is: " + (a*b));
}
}
}
