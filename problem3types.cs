using System;

namespace program{
class program{
static void Main(string [] args){

	int a,b,c;
	Console.WriteLine("What is the first grade?");
	a=(int) double.Parse(Console.ReadLine());

	Console.WriteLine("What is the second grade?");
	b=(int) double.Parse(Console.ReadLine());

	Console.WriteLine("What is the third grade?");
	c=(int) double.Parse(Console.ReadLine());
	
	double avg = ((double)a + (double)b + (double)c)/3;
	Console.WriteLine("The average grade for these three is: " + avg);
}
}
}
