using System;

namespace att_07
{
    public class ContaNormal
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Saldo { get; set; }

        public ContaNormal(){
            
        }
        public ContaNormal(string name, int number, double saldo)
        {
            Name = name;
            Number = number;
            Saldo = saldo;
        }
        public void Sacar(double valor){
            Saldo -= valor;
        }
        public void Depositar(double valor){
            Saldo += valor;
        }
        public void ShowStatus(){
            Console.WriteLine("Nome: "+Name);
            Console.WriteLine("Conta: "+Number);
            Console.WriteLine("Saldo: "+Saldo);
        }
    }
}