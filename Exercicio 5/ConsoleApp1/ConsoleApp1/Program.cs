using System;
// 1. Importando a DLL que o Carlos (seu amigo) fez
using ConversorUnidades;

namespace ProjetoDoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversores conversor = new Conversores();
            double tempCelsius = 25.0;
            double tempFahrenheit = conversor.CelsiusParaFahrenheit(tempCelsius);
            Console.WriteLine($"[Temperatura] {tempCelsius}°C equivale a {tempFahrenheit}°F");
            double distanciaKm = 10.0;
            double distanciaMilhas = conversor.KmParaMilhas(distanciaKm);
            Console.WriteLine($"[Distância]   {distanciaKm} km equivale a {distanciaMilhas:F2} milhas");
            Console.ReadKey();
        }
    }
}
