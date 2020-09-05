using System;

namespace att_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregados statusF = new Terceirizado();

            Console.Clear();

                Console.Write("Digite quantos funcionarios quer cadastrar: ");
                int x = int.Parse(Console.ReadLine());
                    
                    Terceirizado[] func = new Terceirizado[x];

                int i;

                    for( i = 0; i < x; i++)
                    {
                        func[i] = new Terceirizado();

                            Console.WriteLine("Digite 1 - Funcionario | 2 - Funcionario Terceirizado: ");
                            int status = int.Parse(Console.ReadLine());

                                    if(!(status == 1 || status == 2))
                                    {   
                                        do
                                            {
                                                Console.WriteLine("Comando invalido: ");
                                                Console.WriteLine("Digite 1 - Funcionario | 2 - Funcionario Terceirizado: ");
                                                status = int.Parse(Console.ReadLine());
                                            }while(!(status == 1 || status == 2));
                                    }
                                    else if(status == 1 || status == 2)
                                    {
                                        func[i].verifyFunc(status);
                                    }

                                Console.Clear();   

                            if(status == 1)
                            {
                                Console.Write("Digite seu nome: ");
                                func[i].Name = Console.ReadLine();
                                Console.Write("Digite sua carga horaria: ");
                                func[i].Hours = int.Parse(Console.ReadLine());
                                Console.Write("Digite seu valor por hora: ");
                                func[i].ValuePerHour = double.Parse(Console.ReadLine());

                            Console.Clear();
                            }
                            else
                            {
                                Console.Write("Digite seu nome: ");
                                func[i].Name = Console.ReadLine();
                                Console.Write("Digite sua carga horaria: ");
                                func[i].Hours = int.Parse(Console.ReadLine());
                                Console.Write("Digite seu valor por hora: ");
                                func[i].ValuePerHour = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor adicional: ");
                                func[i].AddicionalValue = double.Parse(Console.ReadLine());

                            Console.Clear();
                            }  
                            
                        Console.Clear();
                    }
                
                    for( i = 0; i < x; i++)
                    {
                        Console.WriteLine($"Terceirizado: {func[i].StatusF}");
                        Console.WriteLine($"Nome: {func[i].Name}");
                        Console.WriteLine($"Horas trabalhadas: {func[i].Hours}");
                        Console.WriteLine($"Valor por hora trabalhada: ${func[i].ValuePerHour}");
                        Console.WriteLine("-------------------------------------------");
                    }
                    
                    for( i = 0; i < x; i++)
                    {   
                        if(func[i].StatusF == false){
                            Console.WriteLine($"Nome: {func[i].Name} - ${func[i].Payment()}");
                        }else{
                            Console.WriteLine($"Nome: {func[i].Name} - ${func[i].Paymentt()}");
                        }
                    }
        }
    }
}
