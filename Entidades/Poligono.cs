using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cap10_12.Entidades
{
    //3- Crear una clase para polígonos con sobrecarga del constructor.
    public class Poligono
    {
        private static float Radio = 0;
        public float Lado = 0;
        public float Apotema = 0;
        public float Angulo = 0;
        public float Inscrita = 0;
        public float Circunscrita = 0;


        public Poligono(float radio, float lado, float apotema, float angulo)
        {
            Radio_ = radio;
            Lado_ = lado;
            Apotema_ = apotema;
            Angulo_ = angulo;
        }

        //Constructor Sobrecargado.
        public Poligono(float radio, float lado, float apotema, float angulo, float inscrita, float circunscrita)
        {
            Radio = radio;
            Lado = lado;
            Apotema = apotema;
            Angulo = angulo;
            Inscrita = inscrita;
            Circunscrita = circunscrita;
        }


        //4- Crear propiedades para la clase polígono que solamente permitan colocar valores válidos.
        public float Radio_
        {
            get
            {
                return Radio;
            }
            set
            {
                string var = Radio.ToString();
                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    Radio = 0;
                Radio = value;
            }
        }

        public float Lado_
        {
            get
            {
                return Lado;
            }
            set
            {
                string var = Lado.ToString();
                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    Lado = 0;
                Lado = value;
            }
        }

        public float Apotema_
        {
            get
            {
                return Apotema;
            }
            set
            {
                string var = Apotema.ToString();
                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    Apotema = 0;
                Apotema = value;
            }
        }

        public float Angulo_
        {
            get
            {
                return Angulo;
            }
            set
            {
                string var = Angulo.ToString();
                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    Angulo = 0;
                Angulo = value;
            }
        }

        public float Inscrita_
        {
            get
            {
                return Inscrita;
            }
            set
            {
                string var = Inscrita.ToString();
                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    Inscrita = 0;
                Inscrita = value;
            }
        }

        public float Circunscrita_
        {
            get
            {
                return Circunscrita;
            }
            set
            {
                string var = Circunscrita.ToString();
                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    Circunscrita = 0;
                Circunscrita = value;
            }
        }


        // 5- Programar el método ToString() para la clase polígono.

         public override string ToString()
         {
             StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat($"Radio: {Radio}");
            stringBuilder.AppendFormat($"Lado: {Lado}");
            stringBuilder.AppendFormat($"Apotema: {Apotema}");
            stringBuilder.AppendFormat($"Angulo: {Angulo}");
            stringBuilder.AppendFormat($"Inscrita: {Inscrita}");
            stringBuilder.AppendFormat($"Circunscrita: {Circunscrita}");

            return base.ToString();

         }

    }

}
