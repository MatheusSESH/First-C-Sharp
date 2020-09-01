namespace att_03
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }
        public double Porcento { get; set; }

        public Funcionario(){

        }
        public Funcionario(string nome, double salario, double imposto){
            Nome = nome;
            Salario = salario;
            Imposto = imposto;    
        }
        public Funcionario(double porcento){
            Porcento = porcento;
        }

        public double AumentarSalario(){
            Porcento = (Porcento/100)*Salario; 
            Salario += Porcento;
            return Salario;
        }
        public double SalarioL(){
            Salario = Salario - Imposto;
            return Salario;
        }
    }
}