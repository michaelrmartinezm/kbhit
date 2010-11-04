using UPC.Trabajo.KBHit.BC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPC.Trabajo.KBHit.BE;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for PlataformaBCTest and is intended
    ///to contain all PlataformaBCTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlataformaBCTest
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
        ///A test for ObtenerPlataforma
        ///</summary>
        [TestMethod()]
        public void ObtenerPlataformaTest()
        {
            PlataformaBC target = new PlataformaBC(); // TODO: Initialize to an appropriate value
            int codigo = 1; // TODO: Initialize to an appropriate value
            PlataformaBE expected = new PlataformaBE(); // TODO: Initialize to an appropriate value
            expected.CodPlataforma = 1;
            expected.CodAeropuerto = 1;
            expected.Naves = 30;
            expected.Pavimento = "pavimento uno";
            expected.Pcn = "pcn uno";
            expected.Dimensiones = "dimensiones uno";
            expected.NaveMaxPermisible = "nave max uno";
            PlataformaBE actual;
            actual = target.ObtenerPlataforma(codigo);
            Assert.AreEqual(expected.CodAeropuerto, actual.CodAeropuerto);
            Assert.AreEqual(expected.CodPlataforma, actual.CodPlataforma);
            Assert.AreEqual(expected.Dimensiones, actual.Dimensiones);
            Assert.AreEqual(expected.NaveMaxPermisible, actual.NaveMaxPermisible);
            Assert.AreEqual(expected.Naves, actual.Naves);
            Assert.AreEqual(expected.Pavimento, actual.Pavimento);
            Assert.AreEqual(expected.Pcn, actual.Pcn);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
