using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizMakers;

namespace Unit_testing
{
    /// <summary>
    /// Descripción resumida de Test_Fraccion
    /// </summary>
    [TestClass]
    public class Test_Fraccion
    {

        [TestMethod]
        public void testConstructorDefaultFraccion()
        {
            Fraccion F = new Fraccion();
            int numerador = F.getNumerador();
            int denominador = F.getDenominador();
            bool b = (numerador == 1) && (denominador == 1);
            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testSumarMetodoPublicodeFracciones1()
        {
            Fraccion F1 = new Fraccion(6, 2);
            F1.setSigno('+');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.Sumar(F1, F2);
            bool b = (Resultado.getNumerador() == 14) && (Resultado.getDenominador() == 6) && (Resultado.getSigno() == '+');
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testSumarMetodoPublicodeFracciones2()
        {
            Fraccion F1 = new Fraccion(6, 2);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.Sumar(F1, F2);
            bool b = ((Resultado.getNumerador() == 14) && (Resultado.getDenominador() == 6)) || (Resultado.getSigno() == '-');
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testRestarMetodoPublicodeFracciones1()
        {
            Fraccion F1 = new Fraccion(6, 2);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.Restar(F1, F2);
            bool b = (Resultado.getNumerador() == 14) && (Resultado.getDenominador() == 6) && (Resultado.getSigno() == '-');

            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testRestarMetodoPublicodeFracciones2()
        {
            Fraccion F1 = new Fraccion(6, 2);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.Restar(F1, F2);
            bool b = (Resultado.getNumerador() == 14) && (Resultado.getDenominador() == 6) && (Resultado.getSigno() == '-');

            Assert.AreEqual(true, b);
        }


        [TestMethod]
        public void testMultiplicarMetodoPublicoFaccion1()
        {
            Fraccion F1 = new Fraccion(2, 3);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Result = new Fraccion();
            Result.Multiplicar(F1, F2);
            bool b = (Result.getNumerador() == 4) && (Result.getDenominador() == 9) && (Result.getSigno() == '+');

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testMultiplicarMetodoPublicoFaccion2()
        {
            Fraccion F1 = new Fraccion(2, 3);
            F1.setSigno('+');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Result = new Fraccion();
            Result.Multiplicar(F1, F2);
            bool b = (Result.getNumerador() == 4) && (Result.getDenominador() == 9) && (Result.getSigno() == '-');

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testDividirMetodoPublicodeFracciones1()
        {
            Fraccion F1 = new Fraccion(1, 3);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.Dividir(F1, F2);
            bool b = (Resultado.getNumerador() == 3) && (Resultado.getDenominador() == 6) && Resultado.getSigno() == '+';

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testDividirMetodoPublicodeFracciones2()
        {
            Fraccion F1 = new Fraccion(1, 3);
            F1.setSigno('+');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.Dividir(F1, F2);
            bool b = (Resultado.getNumerador() == 3) && (Resultado.getDenominador() == 6) && Resultado.getSigno() == '-';

            Assert.AreEqual(true, b);

        }


        [TestMethod]
        public void testSimplificarMetodoPublicodeFracciones1()
        {
            Fraccion F1 = new Fraccion(12, 6);
            F1.Simplificar();
            bool b = F1.getNumerador() == 2 && F1.getDenominador() == 1;
            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testSimplificarMetodoPublicodeFracciones2()
        {
            Fraccion F1 = new Fraccion(35, 5);
            F1.Simplificar();
            bool b = F1.getNumerador() == 7 && F1.getDenominador() == 1;
            Assert.AreEqual(true, b);

        }
    }
}
