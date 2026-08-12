using BibliotecaConversao;
using Microsoft.VisualBasic;
using System;

var Conv = new Conversao();

Console.WriteLine("Fahreinreit: " + Conv.CelsiusParaFahrenheit(35));
Console.WriteLine("Quilometros: " + Conv.MetrosParaQuilometros(10000));

Console.WriteLine("Digite a quantidade de Dolares (R$): ");
double reais = double.Parse(Console.ReadLine());

Console.Write("Digite a cotacao atual do Dolar (ex: 5.50): ");
double cambio = double.Parse(Console.ReadLine());

double resultadoDolar = Conv.ReaisParaDolar(reais, cambio);
Console.WriteLine("O valor convertido em Reais e: R$" + resultadoDolar.ToString("F2"));
