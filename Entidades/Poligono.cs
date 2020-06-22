using System;
using System.Collections.Generic;
using System.Text;

namespace Cap10_12.Entidades
{
    public class Poligono
    {
        public float Radio = 0;
        public float Lado = 0;
        public float Apotema = 0;
        public float Angulo = 0;
        public float Inscrita = 0;
        public float Circunscrita = 0;


        public Poligono(float radio, float lado, float apotema, float angulo)
        {
            Radio = radio;
            Lado = lado;
            Apotema = apotema;
            Angulo = angulo;
        }

        public Poligono(float radio, float lado, float apotema, float angulo, float inscrita, float circunscrita)
        {
            Radio = radio;
            Lado = lado;
            Apotema = apotema;
            Angulo = angulo;
            Inscrita = inscrita;
            Circunscrita = circunscrita;
        }

        public float Radio
        {
            get
            {
                return radio;
            }
            set
            {
                string var = 
            }
        }



        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat($"Radio: {radio}");

            return base.ToString();

        }

    }

}
