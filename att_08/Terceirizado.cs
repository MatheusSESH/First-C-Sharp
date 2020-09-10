namespace att_008
{
    public class Terceirizado : Empregados
    {
        public double AddicionalValue { get; set; }

        public Terceirizado()
        {
        }
        public Terceirizado(double addicionalValue)
        {
            AddicionalValue = addicionalValue;
        }
        public override double Payment()
        {   
            double valor = base.Payment();
            double porcent = 110;
            
            AddicionalValue *= (porcent/100);
            valor += AddicionalValue; 
            return valor;
        }
    }
}