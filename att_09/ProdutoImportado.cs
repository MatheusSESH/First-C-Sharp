namespace att_09
{
    public class ProdutoImportado : Produto
    {
        public double TaxaImportação { get; set; }

        public ProdutoImportado(){
            TaxaImportação = 20.00;
            Nome = "Tablet";
            Preço = 260.00;
        }

        public double PreçoTotal()
        {
            Preço += TaxaImportação;
            return Preço;
        }
        public override string PreçoEtiqueta()
        {
            base.PreçoEtiqueta();

            return  Nome+" "+PreçoTotal().ToString("C")+$" (Taxa de importação: {TaxaImportação.ToString("C")})";
        }
    }
}