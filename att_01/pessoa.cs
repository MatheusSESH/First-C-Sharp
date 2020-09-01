namespace att_01
{
    public class pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public pessoa(){
        
        }
        public pessoa(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }

        
    }
}
