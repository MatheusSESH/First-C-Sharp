using System;

namespace att_04
{
    public class op
    {
        public double Altura { get; set; }
        public double Largura { get; set; }


        public op(){

        }

        public op(double altura, double largura){
            Altura = altura;
            Largura = largura;
        }

        public double area(){
            double AreaValue = (Largura*Altura);
            return AreaValue;
        }

        public double perimetro(){
            double PerValue = 2*(Largura+Altura);
            return PerValue;
        }

        public double diagonal(){
            double DiagonalValue = Math.Pow(Largura,2)+Math.Pow(Altura,2);
            DiagonalValue = Math.Sqrt(DiagonalValue);
            return DiagonalValue;
        }
    }
}