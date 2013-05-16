using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMakers
{
    public class Problema
    {
        private Fraccion _FracccionIzq;
        private Fraccion _FracccionDer;
        private char _Operador;

        public Fraccion getFraccion_Izq() 
        {
            return this._FracccionIzq;
        }
        public Fraccion getFraccion_Der()
        {
            return this._FracccionDer;
        }
        public char getOperador() 
        {
            return this._Operador;
        }
        
        public Problema(int nivel) 
        {
            this._FracccionIzq = generar_Fraccion(nivel);
            this._FracccionDer = generar_Fraccion(nivel);
            this._Operador = generar_Operadorleatorio();
        }

        private char generar_Operadorleatorio() 
        {
            Random random = new Random();
            int rand = random.Next(0,3);
            switch (rand) 
            {
                case 0:
                    return '+';
                case 1:
                    return '-';
                case 2:
                    return '*';
                case 3:
                    return '/';
            }
            return 'n';
        }

        private Fraccion generar_Fraccion(int nivel) 
        {
            Fraccion F = new Fraccion();
            if(nivel == 1)
            {
                F.setNumerador(getNumRandom(1,20));
                F.setDenominador(getNumRandom(1, 20));
            
            }
            else if (nivel == 2)
            {
                F.setNumerador(getNumRandom(20, 50));
                F.setDenominador(getNumRandom(2, 50));
            }
            else 
            {
                return null;            
            }
            int num = getNumRandom(1, 2);
            char signo = (num==1)? '-' : '+';
            F.setSigno(signo);
             
            return F;
        }
        private int getNumRandom(int min,int max) 
        {
            Random num = new Random();
            return num.Next(min, max);
        }
    }
}
