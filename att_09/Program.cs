using System;

namespace att_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Product = new Produto();
            ProdutoUsado Used = new ProdutoUsado();
            ProdutoImportado Import = new ProdutoImportado();

                Console.Clear();

                
                Console.WriteLine("PRODUTO IMPORTADO");
                Console.WriteLine("------------------");
                Console.WriteLine($"Nome: {Import.Nome}");
                Console.WriteLine($"Preço: {Import.Preço}");
                Console.WriteLine($"Taxa de importação: {Import.TaxaImportação}");
                Console.WriteLine("");

                
                Console.WriteLine($"PRODUTO NORMAL");
                Console.WriteLine("------------------");
                Console.WriteLine($"Nome: {Product.Nome}");
                Console.WriteLine($"Preço: {Product.Preço}");
                Console.WriteLine("");


                Console.WriteLine($"PRODUTO USADO");
                Console.WriteLine("------------------");
                Console.WriteLine($"Nome: {Used.Nome}");
                Console.WriteLine($"Preço: {Used.Preço}");
                Console.WriteLine($"Ano de fabricação: {Used.AnoFabricação}");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("ETIQUETAS: ");
                Console.WriteLine("");
                Console.WriteLine(Import.PreçoEtiqueta());
                Console.WriteLine("---------------------------");
                Console.WriteLine(Product.PreçoEtiqueta());
                Console.WriteLine("---------------------------");
                Console.WriteLine(Used.PreçoEtiqueta());
                
                
        
        }
    }
}
