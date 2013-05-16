
﻿using System;
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
        private char _signo;

        public Fraccion(int num, int denom)
        {
            _numerador=num;
            _denominador=denom;
        }

        public Fraccion()
        {
            _numerador = 1;
            _denominador = 1;
        }
        
        public void setSigno(char signo) 
        {
            this._signo = signo;
        }

        public char getSigno() 
        {
            return this._signo;
        }

        public int getNumerador()
        {
            return this._numerador;
        }
        public void setNumerador(int numerador) 
        {
            this._numerador = numerador;
        }

        public int getDenominador()
        {
            return this._denominador;
        }
        public void setDenominador(int denominador)
        {
            this._denominador = denominador;
        }

        public void Sumar(Fraccion F1, Fraccion F2)
        {
            if (F1._signo == F2._signo)
            {
                this._numerador = (F1._numerador * F2._denominador) + (F2._numerador * F1._denominador);
                this._denominador = F1._denominador * F2._denominador;
                this._signo = F1._signo;
            }
            else 
            {
                Restar(F1, F2);
            }
        }
        public void Restar(Fraccion F1, Fraccion F2)
        {
            if (F1.getSigno() != F2.getSigno())
            {
                this._numerador = (F1.getNumerador() * F2.getDenominador()) - (F2.getNumerador() * F1.getDenominador());
                this._denominador = F1.getDenominador() * F2.getDenominador();
                if (F1._signo == '-' && F2._signo == '+')
                {
                    if (F1.SoyMayorQue(F2))
                        this._signo = '-';
                    else
                        this._signo = '+';
                }
                if (F1._signo == '+' && F2._signo == '-')
                {
                    if (F1.SoyMayorQue(F2))
                        this._signo = '+';
                    else
                        this._signo = '-';
                }
            }
            else if (F1.getSigno() == '-' && F2.getSigno() == '-')
            {
                this._numerador = (F1.getNumerador() * F2.getDenominador()) - (F2.getNumerador() * F1.getDenominador());
                this._denominador = F1.getDenominador() * F2.getDenominador();
                this._signo = '-';
            }
            else 
            {
                Sumar(F1, F2);
            }
        }

        private bool SoyMayorQue(Fraccion F)
        {
            double fraccion1, fraccion2;
            fraccion1 = F.getNumerador() / F.getDenominador();
            fraccion2 = this._numerador / this._denominador;
            return (fraccion2 > fraccion1) ? true : false;
        }

        public void Multiplicar(Fraccion F1, Fraccion F2)
        {
            this._numerador = F1._numerador * F2._numerador;
            this._denominador = F1._denominador * F2._denominador;
            if (F1._signo != F2._signo)
            {
                this._signo = '-';
            }
            else 
            {
                this._signo = '+';
            }
        }

        public void Dividir(Fraccion F1, Fraccion F2)
        {
            this._numerador = F1._numerador * F2._denominador;
            this._denominador = F1._denominador * F2._numerador;
            if (F1._signo != F2._signo)
            {
                this._signo = '-';
            }
            else
            {
                this._signo = '+';
            }
        }

        public void Simplificar() 
        {
            int i = 2;
            while (i <= 9) 
            {
                if (this._denominador % i == 0 && this._denominador % i == 0)
                {
                    this._numerador = this._numerador / i;
                    this._denominador = this._denominador / i;
                }
                else 
                {
                    i++;
                }
            }
        }
    }
}

