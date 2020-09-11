using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{

    class Aplicacion
    {
        public Aplicacion()
        {
            RecibirMedidas();
        }
        public Medidas  ObtenerMedida()
        {
            Console.WriteLine("Digite su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su genero");
            string genero = Console.ReadLine();
            Medidas medidas = new Medidas(edad,genero);
            medidas.ObtenerPulsaciones();
            return medidas;
        }

        public void RecibirMedidas()
        {
            Medidas medidas = ObtenerMedida();
            int pulsaciones = medidas.Pulsaciones;
            Console.WriteLine(pulsaciones);
        }
    }
}
