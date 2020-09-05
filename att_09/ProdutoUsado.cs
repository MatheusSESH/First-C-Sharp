namespace att_09
{
    public class ProdutoUsado : Produto
    {
        public int AnoFabricação { get; set; }

        public ProdutoUsado(){
            Nome = "Iphone 7";
            Preço = 400.00;
            AnoFabricação = 2017;
        }
        public ProdutoUsado(int anoFabricação)
        {
            AnoFabricação = anoFabricação;
        }

        public override string PreçoEtiqueta()
        {
            return  Nome +" (Usado) "+Preço.ToString("C")+$" (Ano de fabricação: {AnoFabricação})";
        }
    }
}