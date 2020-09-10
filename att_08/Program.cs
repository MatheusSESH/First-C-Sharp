using System;

namespace att_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

                Console.Write("Digite quantos funcionarios quer cadastrar: ");
                int x = int.Parse(Console.ReadLine());
                    
                    Terceirizado[] func = new Terceirizado[x];
                    Empregados[] Emp = new Empregados[x];

                int i;

                    bool[] ArrVerificar = new bool[x];
                    
                    for( i = 0; i < x; i++)
                    {
                        
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

                                Console.Clear();   

                            if(status == 1)
                            {
                                Emp[i] = new Empregados();

                                    Console.Write("Digite seu nome: ");
                                    Emp[i].Name = Console.ReadLine();
                                    Console.Write("Digite sua carga horaria: ");
                                    Emp[i].Hours = int.Parse(Console.ReadLine());
                                    Console.Write("Digite seu valor por hora: ");
                                    Emp[i].ValuePerHour = double.Parse(Console.ReadLine());

                                Console.Clear();

                            ArrVerificar[i] = false;

                            }else{
                                
                                func[i] = new Terceirizado();

                                    Console.Write("Digite seu nome: ");
                                    func[i].Name = Console.ReadLine();
                                    Console.Write("Digite sua carga horaria: ");
                                    func[i].Hours = int.Parse(Console.ReadLine());
                                    Console.Write("Digite seu valor por hora: ");
                                    func[i].ValuePerHour = double.Parse(Console.ReadLine());
                                    Console.Write("Digite o valor adicional: ");
                                    func[i].AddicionalValue = double.Parse(Console.ReadLine());

                                Console.Clear();

                            ArrVerificar[i] = true;

                            }  
                    }

                    Console.Clear();

                    for(i = 0; i <x; i++) {

                        if(ArrVerificar[i] == false) {
                            Console.WriteLine($"Terceirizado: {ArrVerificar[i]}");
                            Console.WriteLine($"Nome: {Emp[i].Name}");
                            Console.WriteLine($"Horas trabalhadas: {Emp[i].Hours}");
                            Console.WriteLine($"Valor por hora trabalhada: ${Emp[i].ValuePerHour}");
                            Console.WriteLine("-------------------------------------------");
                        }else {
                            Console.WriteLine($"Terceirizado: {ArrVerificar[i]}");
                            Console.WriteLine($"Nome: {func[i].Name}");
                            Console.WriteLine($"Horas trabalhadas: {func[i].Hours}");
                            Console.WriteLine($"Valor por hora trabalhada: ${func[i].ValuePerHour}");
                            Console.WriteLine($"Valor adicional: ${func[i].AddicionalValue}");
                            Console.WriteLine("-------------------------------------------");
                        }
                    }
                    
                Console.WriteLine("");
                Console.WriteLine("PAYMENTS:");
                Console.WriteLine("");

                    for(i = 0; i <x; i++) {

                        if(ArrVerificar[i] == false) {
                            Console.WriteLine($"{Emp[i].Name} - ${Emp[i].Payment()}");
                        }else {
                            Console.WriteLine($"{func[i].Name} - ${func[i].Payment()}");
                        }
                    }
        }
    }
}
