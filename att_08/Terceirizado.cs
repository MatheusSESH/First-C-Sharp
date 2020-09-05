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
         public void verifyFunc(int verify)
        {
            if(verify == 1)
            {
                StatusF = false;
            }else if(verify == 2)
            {
                StatusF = true;
            }else{

            }
        }
        public double Paymentt()
        {   
            double porcent = 110;
            double value = ValuePerHour*Hours;
            AddicionalValue *= (porcent/100);
            value += AddicionalValue; 
            return value;
        }
    }
}