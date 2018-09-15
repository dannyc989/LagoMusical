using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LagoMusicalBLL;

namespace UnitTestLagoMusical
{
    [TestClass]
    public class UnitTestCancion
    {
        [TestMethod]
        public void TestMethodLeerRestoCancion()
        {
            clsCancion objCancion = new clsCancion();

            string sonidoBuscar = "fiu";
            string valorEsperado = "cric-cric,brrah";

            var actual = objCancion.getRestoCancion(sonidoBuscar);
            Assert.AreEqual(valorEsperado, actual);

            string sonidoBuscar2 = "pep";
            string valorEsperado2 = "birip,trri-trri,croac";
            
            var actual2 = objCancion.getRestoCancion(sonidoBuscar2);
            Assert.AreEqual(valorEsperado2, actual2);

            string sonidoBuscar3 = "croac";
            string valorEsperado3 = "";

            var actual3 = objCancion.getRestoCancion(sonidoBuscar3);
            Assert.AreEqual(valorEsperado3, actual3);

        }
    }
}
