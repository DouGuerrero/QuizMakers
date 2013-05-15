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
            Problema P = new Problema();

            Fraccion op1 = P.getOperando1();
            Fraccion op2 = P.getOperando2();
            char operador = P.getOperador();
            Fraccion result = P.getResultado();
        }
    }
}
