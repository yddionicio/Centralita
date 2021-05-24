using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CentralitaHerencia;

namespace PruebaTest
{
    [TestClass]
    public class CentralitaTest
    {
        [TestMethod]
        public void ValidarListaLlamada()
        {
            Centralita c = new Centralita("central");
            Assert.IsNotNull(c.Llamadas);
        }


        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void VerificarLlamadaProvincial()
        {
            //Arrange
            Centralita c = new Centralita();
            Llamada l = new Provincial("cordoba", Provincial.Franja.Franja_1, 2.5f, "salta");

            //Act
            c += l;
            c += l;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void VerificarLlamadaLocal()
        {
            //Arrange
            Centralita c = new Centralita();
            Llamada l = new Local("avellaneda", 2.3f, "wilde", 10.5f);

            //Act
            c += l;
            c += l;
        }

        //[TestMethod]
        //[TestCase(new Provincial("cordoba", Provincial.Franja.Franja_1, 2.5f, "salta"), new Provincial("cordoba", Provincial.Franja.Franja_1, 2.5f, "salta"))]
        //public void CompararLlamadas(object obj, object obj)
        //{
        //    //Arrange
        //    Llamada p1 = new Provincial("cordoba", Provincial.Franja.Franja_1, 2.5f, "salta");
        //    Llamada p2 = new Provincial("cordoba", Provincial.Franja.Franja_1, 2.5f, "salta");

        //    Llamada l1 = new Local("cordoba", 2.3f, "salta", 10.5f);
        //    Llamada l2 = new Local("cordoba", 2.3f, "salta", 10.5f);

        //    //Act
         
        //    //Assert.AreEqual(l1, l2);
        //    Assert.AreEqual(l1, p2);

        //}
    }
}
