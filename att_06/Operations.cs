using System;

namespace att_06
{
    public class Operations : Bank
    {
        public void ShowAccount(){
            Console.WriteLine("Nome: "+Name);
            Console.WriteLine("Conta: "+Number);
            Console.WriteLine($"Saldo em conta: ${Saldo} ");
        }
        public void Saque(double valor){
            Saldo -= valor;
        }

        public void Deposito(double valor){
            Saldo += valor;
        }
    }
}