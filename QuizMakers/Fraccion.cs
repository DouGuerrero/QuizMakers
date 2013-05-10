using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMakers
{
    public class Fraccion
    {
        private int _numerador;
        private int _denominador;
        private char _operador;

        public Fraccion(int num, int denom)
        {
            _numerador=num;
            _denominador=denom;
        }

        public Fraccion()
        {
            
        }

        public void setOperador(char operando) 
        {
            this._operador = operando;        
        }

        public int getNumerador()
        {
            return this._numerador;
        }

        public int getDenominador()
        {
            return this._denominador;
        }

        public int Sumar(Fraccion f1, Fraccion f2)
        {
            return 0;
        }

        public char getOperador()
        {
            return this._operador;
        }

        public void Multiplicar(Fraccion F1, Fraccion F2)
        {
            this._numerador = F1._numerador * F2._numerador;
            this._denominador = F1._denominador * F2._denominador;
        }

        public void Restar(Fraccion F1, Fraccion F2)
        {
            this._numerador = (F1._numerador * F2._denominador) - (F2._numerador * F1._denominador);
            this._denominador = F1._denominador * F2._denominador;
        }
    }
}
