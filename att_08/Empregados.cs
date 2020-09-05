namespace att_008
{
    public class Empregados
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public bool StatusF { get; set; }

        public Empregados()
        {

        }
        public Empregados(string name, int hours, double valuePerHour, bool statusF)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
            StatusF = statusF;
        }
        public double Payment()
        {
            double valor = ValuePerHour*Hours;
            return valor;
        }
    }
}