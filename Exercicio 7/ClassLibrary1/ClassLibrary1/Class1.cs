using System;
using System.Text.RegularExpressions;

namespace BibliotecaValidacoes
{
    public class Validador
    {
        public bool ValidadorCPF(string cpf)
        {
            string apenasNumeros = Regex.Replace(cpf, @"[^\d]", "");
            return apenasNumeros.Length == 11;
        }
        public bool ValidadorEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public bool ValidadorSenha(string senha, int tamanhoMinimo)
        {
            return senha.Length >= tamanhoMinimo;
        }
    }
}
