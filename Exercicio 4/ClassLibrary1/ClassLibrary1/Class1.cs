using System;

namespace GeometriaSimples
{
    public class CalculadoraArea
    {
        public double Retangulo(double @base, double altura)
        {
            if (@base <= 0 || altura <= 0)
                throw new ArgumentException("A base e a altura devem ser maiores que zero.");

            return @base * altura;
        }
    }
}
