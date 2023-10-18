using System;

namespace ValidadorDeCPF
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe um CPF válido: ");
            string cPFDigitado = Console.ReadLine();
            CPF cPF = new CPF(cPFDigitado);

            bool cPFValido = cPF.CPFValido();

            if (cPFValido)
                Console.WriteLine("O CPF é válido.");
            else
                Console.WriteLine("O CPF não é válido. Verifique se digitou corretamente e tente de novo.");
        }
    }
}
