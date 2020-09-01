namespace att_05
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Estoque { get; set; }

        public Product(){

        }

        public Product(string name, double price, int estoque){
            Name = name;
            Price = price;
            Estoque = estoque;
        }

        public double TotalProducts(){
            double Value = Price*Estoque;
            return Value;
        }

        public void AddProduct(int estoque){
            Estoque += estoque;
        }

        public void RemoveProduct(int estoque){
            Estoque -= estoque;
        }
    }
}