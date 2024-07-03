using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2GRAFOS;


namespace Ejercicio2GRAFOS
{
    public class LlenarLista
    { 

        public Lista Llenarlista()
        {
            Lista a = new Lista();
            //aqui se inserta la informacion    a cada sucursal, las sucursales se identifican como nodos del 0 al 8
            SucursalesDATA N1 = new SucursalesDATA(0, "Jose Vicente Diaz", "74320148", "villaltaDJ@gmail.com", "San Salvador");
            SucursalesDATA N2 = new SucursalesDATA(1, "Francisco Flores miranda", "78952654", "FranciscoFM@gmail.com", "Cabañas");
            SucursalesDATA N3 = new SucursalesDATA(2, "Angel Pedro Ramirez", "78454554", "AngelPR@gmail.com", "San Tecla");
            SucursalesDATA N4 = new SucursalesDATA(3, "Carlos Angel VIllacorta", "71546484", "CarlosAV@gmail.com", "Santa Ana");
            SucursalesDATA N5 = new SucursalesDATA(4, "Fernando Aquino Valle", "78454646", "FernandoAQ@gmail.com", "Sonsonate");
            SucursalesDATA N6 = new SucursalesDATA(5, "Alberto Ramoz Cruz", "78651291", "AlbertoRC@gmail.com", "La union");
            SucursalesDATA N7 = new SucursalesDATA(6, "Oscar Navarro Banderas", "79513268", "OscarNB@gmail.com", "La libertad");
            SucursalesDATA N8 = new SucursalesDATA(7, "Roberto Jose Melgares", "74942158", "RobertoJM@gmail.com", "Villas de Francia");
            a.agregarSucursal(N1);
            a.agregarSucursal(N2);
            a.agregarSucursal(N3);
            a.agregarSucursal(N4);
            a.agregarSucursal(N5);
            a.agregarSucursal(N6);
            a.agregarSucursal(N7);
            a.agregarSucursal(N8);
            return a;
        }
    }
}
