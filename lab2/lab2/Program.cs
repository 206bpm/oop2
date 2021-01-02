using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Creating a parallelogram with a call to the constructor with parameters");
            Paralelo Paral1 = new Paralelo(16, 5);
            Console.WriteLine("Creating a parallelogram with a call to the constructor without parameters");
            Paralelo Paral2 = new Paralelo();
            Console.WriteLine("Creating a parallelogram with manual data entry");
            Console.WriteLine("Enter the side length and height of the parallelogram:");
            Paralelo Paral3 = new Paralelo(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("The area of the first parallelogram:{0}", Paral1.Get_Volume());
            Console.WriteLine("The area of the second parallelogram:{0}", Paral2.Get_Volume());
            Console.WriteLine("The area of the third parallelogram:{0}", Paral3.Get_Volume());
            Console.WriteLine("Values of the first parallelogram:");
            Paral1.vyvod();
            Console.WriteLine("Values of the second parallelogram:");
            Paral2.vyvod();
            Console.WriteLine("Values of the third parallelogram:");
            Paral3.vyvod();
            Console.ReadKey();
        }

    }
}
class Paralelo
{
    double height, width;
    public Paralelo() { height = 0; width = 0; }
    public Paralelo(double a, double b) { height = a; width = b; }
    ~Paralelo() { Console.WriteLine("The object is destroyed"); }
    public double Get_Volume() { return height * width; }
    public void set_height(double a) { height = a; }
    public void set_width(double b) { width = b; }
    public double get_height() { return height; }
    public double get_width() { return width; }
    public void vyvod()
    {
        Console.WriteLine("Height = {0}, Width = {1}.",
        height, width);
    }
}
