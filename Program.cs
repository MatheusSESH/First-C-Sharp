using System;

namespace att_01
{
    class Program
    {
        static int calc(int a,int b){
            int maior;
            if(a>b){
                maior = a;
            }else{
                maior = b;
            }
            return maior;
        }
        static void Main(string[] args)
        {
            pessoa p1 = new pessoa();
            pessoa p2 = new pessoa();
            

            Console.WriteLine("Digite seu nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            p2.Idade = int.Parse(Console.ReadLine());


            int maior = calc(p1.Idade,p2.Idade);

            if(maior==p1.Idade){
                Console.WriteLine($"A pessoa mais velha é: {p1.Nome} ");
            }else{
                Console.WriteLine($"A pessoa mais velha é: {p2.Nome} ");
            }
            
            


            
        }
    
    }
}
