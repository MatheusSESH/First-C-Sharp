namespace att_02
{
    public class funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public funcionario(){

        }

        funcionario(string nome,double salario){
            Nome = nome;
            Salario = salario;
        }



    }
}