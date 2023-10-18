using System;

namespace ValidadorDeCPF
{
    public class CPF
    {
		int[] multiplicadorDeCPF = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
		int[] multiplicadorDeCPF2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
		public string cPF;

        public CPF(string cPFDigitado)
        {
            cPF = cPFDigitado;
        }

        public bool CPFValido()
        {
			string cPFTemporario, digitoVerificador;
			int soma, resto;

			cPF = cPF.Trim();
			cPF = cPF.Replace(".", "").Replace("-", "");

			if (cPF.Length != 11)
				return false;

			cPFTemporario = cPF.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(cPFTemporario[i].ToString()) * multiplicadorDeCPF[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digitoVerificador = resto.ToString();

			cPFTemporario = cPFTemporario + digitoVerificador;
			soma = 0;

			for (int i = 0; i < 10; i++)
				soma += int.Parse(cPFTemporario[i].ToString()) * multiplicadorDeCPF2[i];

			resto = soma % 11;

			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digitoVerificador = digitoVerificador + resto.ToString();

			if (cPF.Substring(9, 2) == digitoVerificador)
				return true;
			else
				return false;
		}
    }
}