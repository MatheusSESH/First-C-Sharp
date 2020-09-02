using System;

namespace att_06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Operations account = new Operations();

            Console.Write("Digite seu nome: ");
            account.Name = Console.ReadLine();
            Console.Write("Digite o numero da conta: ");
            account.Number = int.Parse(Console.ReadLine());
            /*  ESTUTURA LOGICA DA SENHA /  INSERINDO SENHA / 
            COMPARANDO SENHA DIGITADA COM SENHA DEFINIDA ANTERIORMENTE/

            Console.Write("Digite sua senha: ");
            account.Senha = int.Parse(Console.ReadLine());
            while(account.Key != account.Senha){
                Console.WriteLine("Senha incorreta, Por favor digite novamente:");
                account.Senha = int.Parse(Console.ReadLine());
            }
            */
            
            Console.WriteLine("------------------------------------");
            account.ShowAccount();
            Console.WriteLine("------------------------------------");
    
            
            Console.WriteLine("Deseja realizar algum saque? (Y/N)");
            String escolha1 = Console.ReadLine();
            escolha1 = escolha1.ToLower();

            while(!(escolha1 == "y" || escolha1 == "n")){
                Console.WriteLine("Comando Invalido, tente novamente");
                Console.WriteLine("Deseja sacar? (Y/N)");
                Console.WriteLine("Escreva da forma que está no exemplo | Y = sim | N = não ");
                escolha1 = Console.ReadLine();
                escolha1 = escolha1.ToLower();
            }
                if(escolha1 == "y"){
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    account.Saque(int.Parse(Console.ReadLine()));
                    Console.WriteLine("------------------------------------");
                    account.ShowAccount();
                }


            Console.WriteLine("Deseja realizar algum deposito? (Y/N)");
            String escolha2 = Console.ReadLine();
            escolha2 = escolha2.ToLower();

            while(!(escolha1 == "y" || escolha1 == "n")){
                Console.WriteLine("Comando Invalido, tente novamente");
                Console.WriteLine("Deseja realizar algum deposito? (Y/N)");
                Console.WriteLine("Escreva como da forma que está no exemplo | Y = sim | N = não ");
                escolha2 = Console.ReadLine();
                escolha2 = escolha2.ToLower();
            }
                if(escolha2 == "y"){
                    Console.WriteLine("Informe o valor do deposito: ");
                    account.Deposito(int.Parse(Console.ReadLine()));
                    Console.WriteLine("------------------------------------");
                    account.ShowAccount();
                }


            Console.Clear();
            Console.WriteLine("------------------------------------");
            account.ShowAccount();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Processo finalizado...");
            Console.WriteLine("------------------------------------");

        }
    }
}
