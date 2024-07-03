using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2GRAFOS;

namespace Ejercicio2GRAFOS
{
    public class Auto
    {
         public int id;//Ya va predefinido
         public string marca;//Criterio de busqueda
         public string color;//Criterios de busqueda
         public string modelo;//Criterio de busqueda
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Modelo
        {
            get { return modelo; } 
            set { modelo = value; }
        }
        public Auto()
        {

        }
        public Auto(int id, string marca, string color, string modelo)
        {
            this.id = id;
            this.marca = marca; 
            this.color = color;
            this.modelo = modelo;
        }
    }
}
