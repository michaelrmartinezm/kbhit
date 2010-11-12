using UPC.Trabajo.KBHit.BC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.Trabajo.KBHit.BE;
using System.Collections.Generic;

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
///A test for RegistrarTUUA
///</summary>
[TestMethod()]
public void RegistrarTUUATest()
{
    TUUABC target = new TUUABC(); // TODO: Initialize to an appropriate value
    TUUABE objTUUABE = null; // TODO: Initialize to an appropriate value
    int expected = 1; // TODO: Initialize to an appropriate value
    int actual;
    actual = target.RegistrarTUUA(objTUUABE);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for ObtenerTUUA
///</summary>
[TestMethod()]
public void ObtenerTUUATest()
{
    TUUABC target = new TUUABC(); // TODO: Initialize to an appropriate value
    int codigo = 1; // TODO: Initialize to an appropriate value
    TUUABE expected = new TUUABE() ; // TODO: Initialize to an appropriate value
    expected.CodTUUA = 1;
    expected.CodVuelo = 1;
    expected.Impuesto = 0;

    expected.ObjAerolineaBE = new AerolineaBE();
    expected.ObjAerolineaBE.CodAerolinea = 1;
    
    expected.ObjTipoVueloBE = new TipoVueloBE();
    expected.ObjTipoVueloBE.CodTipoVuelo = 1;
    
    expected.CodVuelo = 1;
    expected.Fecha = Convert.ToDateTime("28/10/2010");
    expected.CodBoleto = 1;
    TUUABE actual = new TUUABE();
    actual = target.ObtenerTUUA(codigo);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for ListarTUUAs
///</summary>
[TestMethod()]
public void ListarTUUAsTest()
{
TUUABC target = new TUUABC(); // TODO: Initialize to an appropriate value
List<TUUABE> expected = null; // TODO: Initialize to an appropriate value
    List<TUUABE> actual;
    actual = target.ListarTUUAs();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
