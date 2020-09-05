namespace att_07
{
    public class ContaEmpresa : ContaNormal
    {
        public double LimiteEmprestimo { get; set; }
        public ContaEmpresa(){
            LimiteEmprestimo = 5000.00;
        }

        public ContaEmpresa(double limiteEmprestimo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }
        public void Emprestar(double valor){
            Saldo -= valor;
            LimiteEmprestimo -= valor;
        }

        
    }
}