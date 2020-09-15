using System;
using System.Collections.Generic;

namespace att_10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Usuario> list = new List<Usuario>(); 

            Usuario user1 = new Usuario ( "Maria Green" , "maria@gmail.com" , 5 );
            Usuario user2 = new Usuario ( "Marco Antonio", "marco@gmail.com", 1 );
            Usuario user3 = new Usuario ( "Alex Brown", "alex@gmail.com", 8 );
           
                list.Add(user1);
                list.Insert(0, user2);
                list.Add(user3);
                
                   foreach(Usuario obj in list) {
                
                        Console.WriteLine(obj.Room+" : "+obj.Name+", "+obj.Email);
                        
                    }  
        }
    }
}