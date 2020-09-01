using System;

namespace att_02
{
    class Program
    {   
        static double calc(double a,double b){
            double media = (a+b)/2;
            return media;
        }
        static void Main(string[] args)
        {
            funcionario f1 = new funcionario();
            funcionario f2 = new funcionario();

            Console.Write("Digite Seu nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Digite seu salario: ");
            f1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite Seu nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Digite seu salario: ");
            f2.Salario = int.Parse(Console.ReadLine());

            double media = calc(f1.Salario, f2.Salario);

            Console.WriteLine($"A media salarial entre {f1.Nome} e {f2.Nome} é R${media}");
        
            

        }
    }
}
