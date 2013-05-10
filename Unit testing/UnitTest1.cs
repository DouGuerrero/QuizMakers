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
            Fraccion F1 = new Fraccion(1,3);
            Fraccion F2 = new Fraccion(2,3);
            Fraccion Resultado = new Fraccion();
            Resultado.Sumar(F1,F2);

            bool b = (Resultado.getNumerador() == 9) && (Resultado.getDenominador() == 9);

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void testRestarMetodoPublicodeFracciones()
        {
            Fraccion F1 = new Fraccion(1, 3);
            Fraccion F2 = new Fraccion(2, 3);
            Fraccion Resultado = new Fraccion();
            Resultado.setOperador('-');
            Resultado.Restar(F1, F2);

            bool b = (Resultado.getNumerador() == 3) && (Resultado.getDenominador() == 9) && (Resultado.getOperador()=='-');

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
            Fraccion F2 = new Fraccion(2,3);
            Fraccion Result = new Fraccion();
            Result.setOperador('*');
            Result.Multiplicar(F1, F2);

            char operador = Result.getOperador();
            bool b = (Result.getNumerador() == 4) && (Result.getDenominador() == 9) && (Result.getOperador()=='*');

            Assert.AreEqual(true,b);
         
        }
    }
}
