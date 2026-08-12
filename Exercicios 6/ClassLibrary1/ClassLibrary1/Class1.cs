using System;

namespace BibliotecaFinanceira
{
    public class CalculadoraJuros
    {

        internal double CalculoInterno(double capital, double taxa, double tempo)
        {
            double total = capital * taxa * tempo;
            return total;
        }
        public double JurosSimples(double capital, double taxa, double tempo)
        {
            return CalculoInterno(capital, taxa, tempo);
        }
    }
}