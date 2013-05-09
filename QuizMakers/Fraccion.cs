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

        public Fraccion(int num, int denom)
        {
            _numerador=num;
            _denominador=denom;
        }

        public Fraccion()
        {
            
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
    }
}
