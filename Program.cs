using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Vector
{
    private int a;
    private int b;
    private int c;

    public Vector(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public void Multiplication(int num)
    {
        a *= num;
        b *= num;
        c *= num;
        Console.WriteLine($"Vector = {a + b + c}");
    }
    public void VectorAddition(Vector obj)
    {
        a += obj.a;
        b += obj.b;
        c += obj.c;
    }
    public void VectorSubstraction(Vector obj)
    {
        a -= obj.a;
        b -= obj.b;
        c -= obj.c;
    }
}

struct Decimal
{
    private int number;

    public Decimal(int n)
    {
        number = n;
    }
    public void Binary()
    {
        string binary = Convert.ToString(number, 2);
        number = Convert.ToInt32(binary);
        Console.WriteLine($"\n{number}");
    }
    public void Octal()
    {
        string octal = Convert.ToString(number, 8);
        number = Convert.ToInt32(octal);
        Console.WriteLine($"\n{number}");
    }
    public void Hexa()
    {
        string hexa = Convert.ToString(number, 16);
        number = Convert.ToInt32(hexa);
        Console.WriteLine($"\n{number}");
    }
}

namespace homework_16._02
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}