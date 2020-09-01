using System;

namespace att_04
{
    class Program
    {
        static void Main(string[] args)
        {
            op op1 = new op();

            Console.Write("Digite a Largura: ");
            op1.Largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a Altura: ");
            op1.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------");

            Console.WriteLine("Area: "+op1.area());
            Console.WriteLine("Perimetro: "+op1.perimetro());
            Console.WriteLine("Diagonal: "+op1.diagonal());

        }
    }
}
