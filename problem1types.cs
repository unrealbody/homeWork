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
double pens, pencils;
double penPrice, pencilPrice;
Console.WriteLine( "Please enter the number of pens_int you want to buy");
pens = double.Parse( Console.ReadLine());
Console .WriteLine( "Please enter the number of pencils_int you want to buy");
pencils = double.Parse( Console.ReadLine());
Console.WriteLine( "Please type the price of one pen");
penPrice = double.Parse( Console.ReadLine());
Console.WriteLine( "Please type the price of one pencil");
pencilPrice = double.Parse( Console.ReadLine());
int pens_int=(int)pens;
int pencils_int = (int)pencils;
double totalPen = (int)penPrice * pens_int;
double totalPencils = pencilPrice * pencils_int;
double total = totalPen + totalPencils;
Console.WriteLine( "You have to pay " + totalPen + " shekels for the pens_int you want to buy");
Console.WriteLine( "You have to pay " + totalPencils + " shekels for the pencils_int you want to buy");
Console.WriteLine( "You have to pay a total of " + total + " shekels for everything");
Console.ReadLine();
}
}
}
