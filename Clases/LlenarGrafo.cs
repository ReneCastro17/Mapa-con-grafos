using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2GRAFOS;


namespace Ejercicio2GRAFOS
{
    public class LlenarGrafo
    {
        public LlenarGrafo() 
        { 

        }
        public Grafo Llenar()
        {
			//Se crea cada array para inviar como parametro a los nodo
			List<Auto> auto01 = new List<Auto>();
			List<Auto> auto02 = new List<Auto>();
			List<Auto> auto03 = new List<Auto>();
			List<Auto> auto04 = new List<Auto>();
			List<Auto> auto05 = new List<Auto>();
			List<Auto> auto06 = new List<Auto>();
			List<Auto> auto07= new List<Auto>();
			List<Auto> auto08 = new List<Auto>();
			//Se llena cada objeto auto y se asigna a un array
			Auto auto1 = new Auto(0, "BMW", "Negro", "M3");
			auto01.Add(auto1);
			Auto auto2 = new Auto(0, "Alfa Romeo", "Rojo", "Giulia");
			auto01.Add(auto2);
			Auto auto3 = new Auto(0, "Aston Martin", "Negro", "DB11");
			auto01.Add(auto3);
			Auto auto4 = new Auto(0, "Bugatti", "Naranja", "Chiron");
			auto01.Add(auto4);
			Auto auto5 = new Auto(0, "Chevrolet", "Amarillo", "Camaro");
			auto01.Add(auto5);
			//Se llenan 5 espacios del primer array y luego se llenan otros 5 espacios del siguiente array, cada uno corresponde a una sucursal
			Auto auto6 = new Auto(1, "BMW", "Verde", "M2");
			auto02.Add(auto6);
			Auto auto7 = new Auto(1, "Audi", "Gris", "A4");
			auto02.Add(auto7);
			Auto auto8 = new Auto(1, "Jeep", "Verde oscuro", "Wrangler");
			auto02.Add(auto8);
			Auto auto9 = new Auto(1, "Cadillac", "Plateado", "Escalade");
			auto02.Add(auto9);
			Auto auto10 = new Auto(1, "Chevrolet", "Amarillo", "Camaro");
			auto02.Add(auto10);
			//Siguiente array
			Auto auto11 = new Auto(2, "Chrysler", "Blanco perla", "300");
			auto03.Add(auto11);
			Auto auto12 = new Auto(2, "Citroën", "Gris oscuro", "C5 Aircross");
			auto03.Add(auto12);
			Auto auto13 = new Auto(2, "BMW", "Negro", "M3");
			auto03.Add(auto13);
			Auto auto14 = new Auto(2, "Daewoo", "Plateado", "Lanos");
			auto03.Add(auto14);
			Auto auto15 = new Auto(2, "Daihatsu", "Verde", "Terios");
			auto03.Add(auto15);
			//Siguiente array
			Auto auto16 = new Auto(3, "Dodge", "Azul oscuro", "Charger");
			auto04.Add(auto16); 
			Auto auto17 = new Auto(3, "Ferrari", "Rojo", "F8 Tributo");
			auto04.Add(auto17);
			Auto auto18 = new Auto(3, "McLaren", "Gris", "720S");
			auto04.Add(auto18);
			Auto auto19 = new Auto(3, "Jeep", "Verde oscuro", "Wrangler");
			auto04.Add(auto19);
			Auto auto20 = new Auto(3, "BMW", "Negro", "M3");
			auto04.Add(auto20);
			//Siguiente array
			Auto auto21 = new Auto(4, "Audi", "Gris", "A4");
			auto05.Add(auto21);
			Auto auto22 = new Auto(4, "GMC", "Marrón oscuro", "Yukon");
			auto05.Add(auto22);
			Auto auto23 = new Auto(4, "Honda", "Blanco perlado", "Civic");
			auto05.Add(auto23);
			Auto auto24 = new Auto(4, "BMW", "Negro", "M3");
			auto05.Add(auto24);
			Auto auto25 = new Auto(4, "Hyundai", "Plateado", "Elantra");
			auto05.Add(auto25);
			//Siguiente array
			Auto auto26 = new Auto(5, "Audi", "Gris", "A4");
			auto06.Add(auto26);
			Auto auto27 = new Auto(5, "McLaren", "Gris", "720S");
			auto06.Add(auto27);
			Auto auto28 = new Auto(5, "Jaguar", "Negro brillante", "F-Type");
			auto06.Add(auto28);
			Auto auto29 = new Auto(5, "Jeep", "Verde oscuro", "Wrangler");
			auto06.Add(auto29);
			Auto auto30 = new Auto(5, "Kia", "Gris", "Sorento");
			auto06.Add(auto30);
			//Siguiente array
			Auto auto31 = new Auto(6, "Lamborghini", "Amarillo", "Aventador");
			auto07.Add(auto31);
			Auto auto32 = new Auto(6, "Lancia", "Gris oscuro", "Thesis");
			auto07.Add(auto32);
			Auto auto33 = new Auto(6, "Land Rover", "Verde", "Range Rover");
			auto07.Add(auto33);
			Auto auto34 = new Auto(6, "Lexus", "Negro", "IS");
			auto07.Add(auto34);
			Auto auto35 = new Auto(6, "Chevrolet", "Amarillo", "Camaro");
			auto07.Add(auto35);
			//Siguiente array
			Auto auto36 = new Auto(7, "Chevrolet", "Amarillo", "Camaro");
			auto08.Add(auto36);
			Auto auto37 = new Auto(7, "Jeep", "Verde oscuro", "Wrangler");
			auto08.Add(auto37);
			Auto auto38 = new Auto(7, "Mazda", "Rojo", "MX-5");
			auto08.Add(auto38);
			Auto auto39 = new Auto(7, "McLaren", "Gris", "720S");
			auto08.Add(auto39);
			Auto auto40 = new Auto(7, "Daihatsu", "Verde", "Terios");
			auto08.Add(auto40);
			//Creamos cada nodo, este se lleva consigo un array que sera el valor/
			//objeto que almacenara en el grafo
			Nodo S1 = new Nodo(auto01);
			Nodo S2 = new Nodo(auto02);
			Nodo S3 = new Nodo(auto03);
			Nodo S4 = new Nodo(auto04);
			Nodo S5 = new Nodo(auto05);
			Nodo S6 = new Nodo(auto06);
			Nodo S7 = new Nodo(auto07);
			Nodo S8 = new Nodo(auto08);

			//Agregamos las aristas de los nodos/vertices
			//Denotan el inicio y final de la arista, al igual que el peso que tiene 
			//esta union
		




			//Insertamos los vertices dentro del grafo
			Grafo grafo = new Grafo();
			grafo.agregarVertice(S1);
			grafo.agregarVertice(S2);
			grafo.agregarVertice(S3);
			grafo.agregarVertice(S4);
			grafo.agregarVertice(S5);
			grafo.agregarVertice(S6);
			grafo.agregarVertice(S7);
			grafo.agregarVertice(S8);
			return grafo;
		}

    }
}
