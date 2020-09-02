namespace att_06
{
    public class Bank
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Saldo { get; set; }

    /*  ENCAPSULAMENTO DA SENHA
        public int Senha { get; set; }      
        public int Key { get; set;}  
    */  
        
        public Bank(){
            Saldo = 10000.00;
        /*  SENHA PRÉ-DEFINIDA
            Key = 1234;      
        */    
        }
        public Bank(string name, int number, double saldo)
        {
            Name = name;
            Number = number;
            Saldo = saldo;
        }
        /*  CONSTRUTOR SENHA
        public Bank(int senha){   
            Senha = senha;
        }
        */
       
        
    }
}