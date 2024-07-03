using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2GRAFOS;


namespace Ejercicio2GRAFOS
{
    public class Lista
    {
        public List<SucursalesDATA> sucursal;

        public Lista()
        {
        }
        public List<SucursalesDATA> ListaSucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
        public void agregarSucursal(SucursalesDATA sus)
        {
            if (ListaSucursal == null)
            {
                ListaSucursal = new List<SucursalesDATA>();
            }
            ListaSucursal.Add(sus);
        }
    }
}
