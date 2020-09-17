using System;
using System.Collections.Generic;

namespace att_11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Empregado> list = new List<Empregado>();
            Empregado em = new Empregado();

            Empregado Emp1 = new Empregado( 333, "Maria Brown", 4000.00 );
            Empregado Emp2 = new Empregado( 536, "Alex Grey"  , 3000.00 );
            Empregado Emp3 = new Empregado( 772, "Bob Green"  , 5000.00 );

            list.Add(Emp1);
            list.Add(Emp2);
            list.Add(Emp3);

            Console.WriteLine("DIGITE O ID DO EMPREGADO PARA AUMENTO");
            int selectE = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A PORCENTAGEM DO AUMENTO");
            double porcent = int.Parse(Console.ReadLine());

            em = list.Find(x => x.Id == selectE);

            em.aumento(porcent);

            foreach(Empregado obj in list) {

                Console.WriteLine(obj.Id+"  "+obj.Name+"  "+obj.Salary+"");
            }




            
            





              

            
           
            

        }
    }
}
