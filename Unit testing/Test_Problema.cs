using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizMakers;

namespace Unit_testing
{
    /// <summary>
    /// Descripción resumida de Test_Problema
    /// </summary>
    [TestClass]
    public class Test_Problema
    {

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestMethod]
        public void testConstructorDefaultProblema()
        {
            Problema P = new Problema(1);
            Fraccion F1 = P.getFraccion_Der();
            Fraccion F2 = P.getFraccion_Izq();
            char operador = P.getOperador();

            bool b1 = (F1 == null) ? false : true;
            bool b2 = (F2 == null) ? false : true;
            bool o = (operador == 'n') ? false : true;
            Assert.AreEqual(true, o);
            Assert.AreEqual(true, b1);
            Assert.AreEqual(true, b2);
        }
    }
}
