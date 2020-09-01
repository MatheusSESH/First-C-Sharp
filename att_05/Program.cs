using System;

namespace att_05
{
    class Program
    {   
        public static void exit(){
            Console.Write("Processo finalizado... Bye! Bye! :)");
            
        }
        static void Main(string[] args)
        {
            Product p = new Product();
            bool exit = false;

            Console.Write("Digite o Nome do produto: ");
            p.Name = Console.ReadLine();
            Console.Write("Digite o Valor do produto: ");
            p.Price = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto em estoque: ");
            p.Estoque = int.Parse(Console.ReadLine());

            while(exit == false)
                {    
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.Write("Digite 1 - Mostrar Estoque | ");
                    Console.Write("2 - Adicionar ao Estoque | ");
                    Console.Write("3 - Remover do Estoque | ");
                    Console.Write("4 - Sair do programa ");
                       
                    int menu = int.Parse(Console.ReadLine());

                        switch(menu){
                            case 1: Console.WriteLine("");
                                    Console.WriteLine($"Produto: {p.Name} | Valor: ${p.Price} | Quantidade: {p.Estoque} | Valor total: ${p.TotalProducts()}");
                                break;
                            case 2: Console.WriteLine("");
                                    Console.Write("Quantos produos quer adicionar ao estoque? ");
                                    p.AddProduct(int.Parse(Console.ReadLine()));
                                    Console.WriteLine($"Total de produtos apos o adicionamento: {p.Estoque}");
                                    Console.WriteLine("-------------------------------------------------------------------------------");
                                    Console.WriteLine($"Produto: {p.Name} | Valor: ${p.Price} | Quantidade: {p.Estoque} | Valor total: ${p.TotalProducts()}");
                                break;
                            case 3: Console.WriteLine("");
                                    Console.Write("Digite a quantidade de produtos que desejar remover do estoque: ");
                                    p.RemoveProduct(int.Parse(Console.ReadLine()));
                                    Console.WriteLine($"Total de produtos: {p.Estoque}");
                                    Console.WriteLine("-------------------------------------------------------------------------------");
                                    Console.WriteLine($"Produto: {p.Name} | Valor: ${p.Price} | Quantidade: {p.Estoque} | Valor total: ${p.TotalProducts()}");
                                break;
                            case 4: Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Processo finalizado... Bye! Bye! :)");
                                    exit = true;
                                break;
                            default: Console.WriteLine("Comando invalido!");
                                break;
                }
            }
        }
    }
}
