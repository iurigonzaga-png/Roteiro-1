using System;
using BibliotecaFinanceira;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraJuros calculadora = new CalculadoraJuros();
            double capital = 1000.00;
            double taxa = 0.05;
            double tempo = 3;
            double juros = calculadora.JurosSimples(capital, taxa, tempo);
            double totalGeral = capital + juros;
            Console.WriteLine("--- TESTE DA BIBLIOTECA FINANCEIRA ---");
            Console.WriteLine($"Capital Inicial: {capital:C}");
            Console.WriteLine($"Taxa de Juros:   {taxa:P}");
            Console.WriteLine($"Tempo:           {tempo} meses");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Juros Gerados:   {juros:C}");
            Console.WriteLine($"Total Acumulado: {totalGeral:C}");
            Console.ReadKey();
        }
    }
}
