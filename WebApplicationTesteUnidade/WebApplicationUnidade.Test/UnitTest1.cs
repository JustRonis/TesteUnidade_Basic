using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationTesteUnidade;

namespace WebApplicationUnidade.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteIniciaComMaiusculo()
        {
            string[] palavras = { "Cachorro", "Gato", "Tartaruga", "Coelho" };

            foreach(var palavra in palavras)
            {
                bool resultado = palavra.Maiusculo();
                Assert.IsTrue(resultado, string.Format("Esperado para '{0}' : true; Atual {1}", palavra, resultado));
            }
        }

        [TestMethod]
        public void TesteIniciaComMinusculo()
        {
            string[] palavras = { "cachorro", "gato", "tartaruga", "coelho" };

            foreach (var palavra in palavras)
            {
                bool resultado = palavra.Maiusculo();
                Assert.IsFalse(resultado, string.Format("Esperado para '{0}' : false; Atual {1}", palavra, resultado));
            }
        }
    }
}
