using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2GRAFOS;


namespace Ejercicio2GRAFOS
{
    public class Nodo
    {
        public List<Auto> autos;//Lista que guarda cada carro de la sucursal
        public int ID { get; set; }
        public int Distancia { get; set; } // Nueva propiedad

        public Nodo()
        {
        }
        public Nodo(List<Auto> Auto)
        {
            autos = Auto;
        }
        public List<Auto> Autos
        {
            get { return autos; }
            set { autos = value; }
        }

    }
}
