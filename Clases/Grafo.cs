using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Util;
using System.Windows.Forms;
using System.Threading;
using Ejercicio2GRAFOS;


namespace Ejercicio2GRAFOS
{
    public class Grafo
    {
        public List<Nodo> nodo;
       
        public Grafo()
        {
        }
        public List<Nodo> ListaNodo
        {
            get { return nodo; }
            set { nodo = value; }
        }
        public void agregarVertice(Nodo nodo)
        {
            if (ListaNodo == null)
            {
                ListaNodo = new List<Nodo>();
            }
            ListaNodo.Add(nodo);
        }
        public List<Nodo> BuscarNodos(Auto autoBusqueda)
        {
            List<Nodo> nodosEncontrados = new List<Nodo>();

            // Comienza la búsqueda con ID 1 y termina en 8
            for (int i = 1; i <= 8; i++)
            {
                autoBusqueda.ID = i;

                if (ListaNodo != null)
                {
                    //Busca el auto busqueda en cada auto de cada nodo en la lista de nodos del grafo
                    //Deben coincidir todos los campo para que este se de por encontrado
                    foreach (Nodo nodo in ListaNodo)
                    {
                        if (nodo.Autos != null && nodo.Autos.Any(auto =>
                            auto.ID == autoBusqueda.ID &&
                            auto.Marca == autoBusqueda.Marca &&
                            auto.Color == autoBusqueda.Color &&
                            auto.Modelo == autoBusqueda.Modelo))
                        {
                            // Agrega el nodo encontrado a la lista
                            nodosEncontrados.Add(nodo);
                        }
                    }
                }
            }

            return nodosEncontrados;
        }
        public bool BuscarAutoEnNodo(int posicionNodo, Auto autoBusqueda)
        {
            // Verificar que la posición sea válida
            if (posicionNodo < 0 || posicionNodo >= ListaNodo.Count)
            {
                //Console.WriteLine("Posición de nodo inválida");
                return false;
            }
            // Obtener el nodo correspondiente a la posición indicada
            Nodo nodo = ListaNodo[posicionNodo];
            // Buscar el auto en el arreglo de autos del nodo
            if (nodo != null && nodo.Autos != null)
            {
                foreach (Auto auto in nodo.Autos)
                {
                    //Verifica que cada auto en el nodo coincida con el auto de busqueda
                    if (auto != null && auto.ID == autoBusqueda.ID &&
                        auto.Marca == autoBusqueda.Marca &&
                        auto.Color == autoBusqueda.Color &&
                        auto.Modelo == autoBusqueda.Modelo)
                    {
                        posicionNodo++;
                        MessageBox.Show("Se encontró el auto especificado en esta sucursal N# " + posicionNodo);
                        return true;
                    }
                }
            }
            // Si no se encontró el auto, mostrar un mensaje
            MessageBox.Show("No se encontró el auto en esta sucursal. Buscando en otras sucursales..." );
            Thread.Sleep(1000);
            return false;
        }
        public void AgregarAutoNodo(int posicionNodo, Auto auto)
        {
            if (posicionNodo >= 0 && posicionNodo < ListaNodo.Count)
            {
                Nodo nodo = ListaNodo[posicionNodo];
                List<Auto> autos = nodo.Autos;
                autos.Add(auto);
                Console.WriteLine("Auto agregado al nodo {0}", nodo.ID);
            }
            else
            {
                MessageBox.Show("Nodo no encontrado en el grafo", "ERROR");
            }
        }


    }

}
