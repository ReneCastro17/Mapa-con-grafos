using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2GRAFOS;


namespace Ejercicio2GRAFOS
{
    public class SucursalesDATA
    {
        public int id;//Ya va predefinido
        public string nombreRESPONSABLE;
        public string numeroCONTACTO;//Criterios de busqueda
        public string direccion;//Criterio de busqueda
        public string direccionc;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NombreRESPONSABLE
        {
            get { return nombreRESPONSABLE; }
            set { nombreRESPONSABLE = value; }
        }
        public string NumeroCONTACTO
        {
            get { return numeroCONTACTO; }
            set { numeroCONTACTO = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Direcionc
        {
            get { return direccionc; }
            set { direccionc = value; }
        }
        public SucursalesDATA()
        {

        }
        public SucursalesDATA(int id, string nombre, string numero, string direccion, string direccionC)
        {
            this.id = id;
            this.nombreRESPONSABLE = nombre;
            this.numeroCONTACTO = numero;
            this.direccion = direccion;
            this.direccionc = direccionC;
        }
    }
}
