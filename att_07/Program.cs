using System;

namespace att_07
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresa e1 = new ContaEmpresa();
            ContaNormal n1 = new ContaNormal();

            n1.Saldo = 200.00;
            e1.Saldo = 15000.00;

                    Console.Clear();

            Console.WriteLine("CONTA NORMAL");
            Console.WriteLine("------------------");
            Console.Write("Digite seu nome: ");
                n1.Name = Console.ReadLine();
            Console.Write("Digite o número da conta: ");
                n1.Number = int.Parse(Console.ReadLine());
            
                    Console.Clear();

            Console.WriteLine("CONTA EMPRESARIAL");
            Console.WriteLine("------------------");
            Console.Write("Digite seu nome: ");
                e1.Name = Console.ReadLine();
            Console.Write("Digete o número da conta Empresarial: ");
                e1.Number = int.Parse(Console.ReadLine());

                    Console.Clear();
           
            Console.WriteLine("CONTA NORMAL");
            Console.WriteLine("------------------");
                n1.ShowStatus();
            Console.WriteLine("------------------");
            Console.Write("Digite o valor para sacar: ");
                n1.Sacar(double.Parse(Console.ReadLine()));
                n1.ShowStatus();
            Console.WriteLine("------------------");
            Console.WriteLine("Digite o valor do deposito: ");
            n1.Depositar(double.Parse(Console.ReadLine()));
                n1.ShowStatus();
            Console.WriteLine("------------------");

                    Console.ReadLine();
                    Console.Clear();

            Console.WriteLine("CONTA EMPRESARIAL");
            Console.WriteLine("------------------");
                e1.ShowStatus();
            Console.WriteLine("------------------");
            Console.Write("Digite o valor para sacar: ");
                e1.Sacar(double.Parse(Console.ReadLine()));
                e1.ShowStatus();
            Console.WriteLine("------------------");
            Console.WriteLine("Digite o valor do deposito: ");
                e1.Depositar(double.Parse(Console.ReadLine()));
                e1.ShowStatus();
            Console.WriteLine("------------------");
            Console.WriteLine("Limite de emprestimo: $"+e1.LimiteEmprestimo);
            Console.WriteLine("Digite o valor do emprestimo: ");
                e1.Emprestar(double.Parse(Console.ReadLine()));
            Console.WriteLine("------------------");
            Console.WriteLine("CONTA EMPRESARIAL");
                e1.ShowStatus();
            Console.WriteLine("------------------");
        
        }
    }
}
