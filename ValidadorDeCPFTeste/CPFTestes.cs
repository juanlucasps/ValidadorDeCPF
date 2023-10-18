using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidadorDeCPF;

namespace ValidadorDeCPFTeste
{
    [TestClass]
    public class CPFTestes
    {
        [TestMethod]
        public void CPF_Valido()
        {
            string cPFValido = "111.444.777-35";

            CPF cPF = new CPF(cPFValido);
            bool resultadoValidacaoCPF = cPF.CPFValido();

            Assert.AreEqual(true, resultadoValidacaoCPF, "Validação de CPF com erro.");
        }

        [TestMethod]
        public void CPF_Invalido()
        {
            string cPFInvalido = "111.444.777-00";

            CPF cPF = new CPF(cPFInvalido);
            bool resultadoValidacaoCPF = cPF.CPFValido();

            Assert.AreEqual(false, resultadoValidacaoCPF, "Validação de CPF com erro.");
        }

        [TestMethod]
        public void CPF_FormatoInvalido()
        {
            string cPFInvalido = "111.444.777";

            CPF cPF = new CPF(cPFInvalido);
            bool resultadoValidacaoCPF = cPF.CPFValido();

            Assert.AreEqual(false, resultadoValidacaoCPF, "Validação de CPF com erro.");
        }
    }
}
