using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sarah;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestdeAhorro()
        {
            //organizar
            Company obj = new Company("Alan Brito", 200);
            double valoresperado = 300;

            //actuar
            obj.Save(100);
            double valorobtenido = obj.SaveProject;

            //afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
            //200+100=300
        }

        [TestMethod]
        public void TestNombre()
        {
            //organizar
            Company obj = new Company("Sergio Ramirez", 200);
            string valoresperado = "Jeferson Gutierritos";

            //actuar
            obj.ChangeName("Jeferson Gutierritos");
            string valorobtenido = obj.Name;

            //afirmar
            Assert.AreEqual(valoresperado, valorobtenido);

        }

        [TestMethod]
        public void TestGastar()
        {
            Company obj = new Company("Peppa Pig", 200);
            double valoresperado = 50;

            obj.Spend(150);
            double valorobtendio = obj.SaveProject;

            Assert.AreEqual(valoresperado, valorobtendio);
            //200-150=50
        }

    }
}
