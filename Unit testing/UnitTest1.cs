using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizMakers;

namespace Unit_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testConstructorDefaultFraccion()
        {
            Fraccion F = new Fraccion();
            int numerador = F.getNumerador();
            int denominador = F.getDenominador();

            bool b = (numerador==1) && (denominador==1);

            Assert.AreEqual(true, b);
            
        }

        [TestMethod]
        public void testSumarMetodoPublicodeFracciones()
        {
            Fraccion F1 = new Fraccion(6,2);
            F1.setSigno('+');
            Fraccion F2 = new Fraccion(2,3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.Sumar(F1,F2);
            Resultado.SimboloResultante(F1,F2,'+');

            bool b = (Resultado.getNumerador() == 14) && (Resultado.getDenominador() == 6) && (Resultado.getSigno() == '+');

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testRestarMetodoPublicodeFracciones()
        {
            Fraccion F1 = new Fraccion(6, 2);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.setOperador('-');
            Resultado.Restar(F1, F2);
            Resultado.SimboloResultante(F1, F2, '-');
            bool b = (Resultado.getNumerador() == 14) && (Resultado.getDenominador() == 6) && (Resultado.getSigno() == '-');

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testConstructorDefaultProblema()
        {
            Problema P = new Problema();

            Fraccion op1 = P.getOperando1();
            Fraccion op2 = P.getOperando2();
            char operador = P.getOperador();
            Fraccion result = P.getResultado();


        }

        [TestMethod]
        public void testMultiplicarMetodoPublicoFaccion()
        {
            Fraccion F1 = new Fraccion(2,3);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2,3);
            F2.setSigno('-');
            Fraccion Result = new Fraccion();
            Result.setOperador('*');
            Result.Multiplicar(F1, F2);
            Result.SimboloResultante(F1, F2, '*');
            bool b = (Result.getNumerador() == 4) && (Result.getDenominador() == 9) && (Result.getSigno() == '+');

            Assert.AreEqual(true,b);
         
        }

        [TestMethod]
         public void testDividirMetodoPublicodeFracciones()
        {
            Fraccion F1 = new Fraccion(1, 3);
            F1.setSigno('-');
            Fraccion F2 = new Fraccion(2, 3);
            F2.setSigno('-');
            Fraccion Resultado = new Fraccion();
            Resultado.setOperador('/');
            Resultado.Dividir(F1, F2);
            Resultado.SimboloResultante(F1,F2,'/');
            char operador = Resultado.getOperador();
            bool b = (Resultado.getNumerador() == 3) && (Resultado.getDenominador() == 6) && Resultado.getSigno() == '+';

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testSimplificarMetodoPublicodeFraccionesa()
        {
            Fraccion F1 = new Fraccion(12, 6);
            F1.Simplificar();
            bool b = F1.getNumerador() == 2 && F1.getDenominador() == 1;
            Assert.AreEqual(true, b);

        }
    }
}

