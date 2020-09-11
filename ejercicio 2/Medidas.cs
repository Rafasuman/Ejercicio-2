using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    class Medidas
    {
        public int Edad { get; set; }
        public string Genero { get; set; }
        public int Pulsaciones { get; set; }

        public Medidas(int edad,string genero)
        {
            Edad = edad;
            Genero = genero;
        }

        public int ObtenerPulsaciones()
        {
            if (Genero.Equals("F"))
                Pulsaciones= (220 - Edad) / 10;
            else
                Pulsaciones = (210 - Edad) / 10;
            return Pulsaciones;
        }
    }
}
