namespace att_11
{
    public class Empregado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Empregado() {

        }

        public Empregado(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void aumento(double porcent) {
            
            double value = 0;

            value = (porcent/100)*Salary;
            Salary += value;

        }
    }
}