using System;

namespace att_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.Write("Digite seu nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Digite seu Salario bruto: ");
            f1.Salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o imposto pago: ");
            f1.Imposto = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Seu salario liquido é: " +f1.SalarioL());

            Console.Write("Digite a porcentagem para aumentar para aumentar seu salario: ");
            f1.Porcento = double.Parse(Console.ReadLine());
            Console.WriteLine($"Seu Salario com aumento de {f1.Porcento}% é: {f1.AumentarSalario()} ");
            
        }
    }
}
