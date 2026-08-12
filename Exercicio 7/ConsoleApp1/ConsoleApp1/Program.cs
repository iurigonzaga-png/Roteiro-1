using BibliotecaValidacoes;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Validador validador = new Validador();
            bool cpfValido = validador.ValidadorCPF("123.456.789-00");
            bool emailValido = validador.ValidadorEmail("usuario@email.com");
            bool senhaValida = validador.ValidadorSenha("123456");
            Console.WriteLine($"CPF Válido? {cpfValido}");
            Console.WriteLine($"E-mail Válido? {emailValido}");
            Console.WriteLine($"Senha Válida? {senhaValida}");
            Console.ReadKey();
        }
    }
}
