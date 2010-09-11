using UPC.Trabajo.KBHit.BC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPC.Trabajo.KBHit.BE;
using System;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for AeropuertoBCTest and is intended
    ///to contain all AeropuertoBCTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AeropuertoBCTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ObtenerAeropuerto
        ///</summary>
        [TestMethod()]
        public void ObtenerAeropuertoTest()
        {
            AeropuertoBC target = new AeropuertoBC(); // TODO: Initialize to an appropriate value
            int codigo = 1; // TODO: Initialize to an appropriate value
            AeropuertoBE expected = new AeropuertoBE(); // TODO: Initialize to an appropriate value
            expected.Ciudad = "Talara";
            expected.CodAeropuerto = 1;
            expected.Elevacion = 282;
            expected.Estado = "Piura";
            //La comparacion de la fecha la hago con .toString();
            expected.Fuel = 1;
            expected.Iata = "TYL";
            expected.Nombre = "Aeropuerto Internacional Capitán FAP Victor Montes";
            expected.Oaci = "SPYL";
            expected.Operacion = "24x7";
            expected.Sei = 6;
            AeropuertoBE actual;
            actual = target.ObtenerAeropuerto(codigo);
            Assert.AreEqual(expected.Ciudad, actual.Ciudad);
            Assert.AreEqual(expected.CodAeropuerto, actual.CodAeropuerto);
            Assert.AreEqual(expected.Elevacion, actual.Elevacion);
            Assert.AreEqual(expected.Estado, actual.Estado);
            Assert.AreEqual("6/6/2010", String.Format("{0}/{1}/{2}", actual.Fecha.Day, actual.Fecha.Month, actual.Fecha.Year));
            Assert.AreEqual(expected.Fuel, actual.Fuel);
            Assert.AreEqual(expected.Iata, actual.Iata);
            Assert.AreEqual(expected.Nombre, actual.Nombre);
            Assert.AreEqual(expected.Oaci, actual.Oaci);
            Assert.AreEqual(expected.Operacion, actual.Operacion);
            Assert.AreEqual(expected.Sei, actual.Sei);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
