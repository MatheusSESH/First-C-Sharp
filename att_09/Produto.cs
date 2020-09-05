namespace att_09
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Produto(){
            Nome = "Notebook";
            Preço = 1100.00;
        }
        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }

        public virtual string PreçoEtiqueta()
        {
            return Nome +" "+Preço.ToString("C");
        }
    }
}