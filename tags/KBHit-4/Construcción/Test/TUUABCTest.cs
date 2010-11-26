using UPC.Trabajo.KBHit.BC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.Trabajo.KBHit.BE;

namespace Test
{


    /// <summary>
    ///This is a test class for TUUABCTest and is intended
    ///to contain all TUUABCTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TUUABCTest
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
        ///A test for ObtenerTUUA
        ///</summary>
        [TestMethod()]
        public void ObtenerTUUATest()
        {
            TUUABC target = new TUUABC(); // TODO: Initialize to an appropriate value
            int codigo = 2; // TODO: Initialize to an appropriate value
            TUUABE expected = new TUUABE(); // TODO: Initialize to an appropriate value
            expected.ObjAerolineaBE = new AerolineaBE();
            expected.ObjTipoVueloBE = new TipoVueloBE();
            expected.CodTUUA = 2;
            expected.CodBoleto = 25;
            expected.CodVuelo = 1;
            expected.ObjAerolineaBE.CodAerolinea = 5;
            expected.ObjTipoVueloBE.CodTipoVuelo = 1;
            expected.Impuesto = 6;
            TUUABE actual;
            actual = target.ObtenerTUUA(codigo);
            Assert.AreEqual(expected.CodBoleto, actual.CodBoleto);
            Assert.AreEqual(expected.CodTUUA, actual.CodTUUA);
            Assert.AreEqual(expected.CodVuelo, actual.CodVuelo);
            Assert.AreEqual(expected.Impuesto, actual.Impuesto);
            Assert.AreEqual(expected.ObjAerolineaBE.CodAerolinea, actual.ObjAerolineaBE.CodAerolinea);
            Assert.AreEqual(expected.ObjTipoVueloBE.CodTipoVuelo, actual.ObjTipoVueloBE.CodTipoVuelo);
            Assert.AreEqual("5/11/2010", String.Format("{0}/{1}/{2}", actual.Fecha.Day, actual.Fecha.Month, actual.Fecha.Year));
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
