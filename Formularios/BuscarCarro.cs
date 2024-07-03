using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Ejercicio2GRAFOS;

namespace Ejercicio2GRAFOS
{
    public partial class BuscarCarro : Form
    {
        public Grafo grafo;
        public Lista Sucursales;
        public BuscarCarro(Grafo grafo, Lista Sucursales)
        {
            InitializeComponent();
            this.grafo = grafo;
            this.Sucursales = Sucursales;
            cmbSucursales.SelectedIndex = 0;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "" || txtmarca.Text == "" || txtmodelo.Text == "" || cmbSucursales.Text == "")
                {
                MessageBox.Show("Por favor llenar los campos incompletos para la busqueda", "Error");
            }
            else {
                //expresiones regulares
                if (!Regex.IsMatch(txtColor.Text, @"^[A-Z][a-z0-9_-]*$")) {
                    MessageBox.Show("El color ingresado no es válido.", "Advertencia");
                    txtColor.Focus();
                }
                else if (!Regex.IsMatch(txtmarca.Text, @"\w")) {
                    MessageBox.Show("El nombre de la marca ingresado no es válido.", "Advertencia");
                    txtmarca.Focus();
                }
                else if (!Regex.IsMatch(txtmodelo.Text, @"^[A-Z][a-z0-9_-]*$")) {
                    MessageBox.Show("El modelo ingresado no es válido.", "Advertencia");
                    txtmodelo.Focus();
                }
                else
                {
                   
                    string marca, color, modelo;
                    marca = txtmarca.Text;
                    color = txtColor.Text;
                    modelo = txtmodelo.Text;
                    int origen = cmbSucursales.SelectedIndex;
                    /*MessageBox.Show("Se busca desde el nodo " + origen);*/// MENSAJE DE COMPROBACION DE SALIDAS
                    Auto autoVERIFICAR = new Auto(origen, marca, color, modelo);
                    bool verficar = grafo.BuscarAutoEnNodo(origen, autoVERIFICAR);//Este bool verificada si el auto esta en esta sucursal
                    if (verficar != true) 
                    {
                        Auto autobusqueda = new Auto(1, marca, color, modelo);
                        List<Nodo> nodosresultado = new List<Nodo>();
                        nodosresultado = grafo.BuscarNodos(autobusqueda);
                        GrafoN grafon = new GrafoN();
                        //Esto crea un tabla hash que almacena listas.La tabla hash esta hecha con un diccionario de entero
                        //(MISMO COMPORTAMIENTO QUE UNA TABLA HASH CREADA CON CLASE)
                        Dictionary<int, List<(int, int)>> graph = new Dictionary<int, List<(int, int)>>() {
                            //La clave es un entero que representa el nodo, en (1,3) representa que tiene una conexion con el nodo 1 de peso 3
                            [0] = new List<(int, int)> { (1, 3), (4, 8), (5, 2), (6, 8) },
                            [1] = new List<(int, int)> { (0, 3), (2, 5), (3, 4) },
                            [2] = new List<(int, int)> { (1, 5), (7, 9) },
                            [3] = new List<(int, int)> { (1, 4), (4, 5) },
                            [4] = new List<(int, int)> { (3, 5), (0, 8), (5, 3), (6, 5), (7, 2) },
                            [5] = new List<(int, int)> { (0, 2), (4, 3) },
                            [6] = new List<(int, int)> { (0, 8), (4, 5) },
                            [7] = new List<(int, int)> { (4, 2), (2, 9) },
                        };

                        // tu lista de objetos de la clase Auto
                        List<int> nodoBusqueda = new List<int>();
                        foreach (Nodo nodo in nodosresultado) {
                            int id = nodo.Autos[0].ID; // recibe el id del primer carro del array
                            nodoBusqueda.Add(id); // Guarda el id en array
                            /*MessageBox.Show("Nodos que tiene el carro" + id );*/ // MENSAJE PARA COMPROBAR FUNCIONAMIENTO    

                        }
                        int[] distanciaNodos = new int[8];
                        for (int i = 0; i < nodoBusqueda.Count; i++) {
                            distanciaNodos[i] = GrafoN.Dijkstra(graph, origen, nodoBusqueda[i]);//Guarda la distancia de cada nodo en un array
                                                                                                //MessageBox.Show("Nodo " + nodoBusqueda[i] + " distancia" + distanciaNodos[i]); //MENSAJE DE COMPRABACION FUNCIONAMIENTO
                        }
                        //Ahora determinamos el minimo valor que se encuntra en el array QUE SEA DIFERENTE DE 0
                        int minimo = int.MaxValue;
                        for (int i = 0; i < distanciaNodos.Length; i++) {
                            if (distanciaNodos[i] != 0 && distanciaNodos[i] < minimo) {
                                minimo = distanciaNodos[i];//Setea la distancia minima, es decir la mas corta
                            }
                        }
                        int indice = Array.IndexOf(distanciaNodos, minimo);
                        //MessageBox.Show("La posicion del valor minimo es " + indice); MENSAJE DE COMPROBACION DE POSICION DE DISTANCIA MINIMA
                        try 
                        {
                            label6.Text = "Auto mas cercano en:";
                            ImprimirCarro(nodosresultado[indice], autobusqueda, distanciaNodos[indice]); //Manda a imprimir
                            LLenar(nodosresultado, Sucursales, distanciaNodos);//Llena con todas las sucursales que tienen el auto
                            Limpiar();
                        }
                        catch 
                        {
                            MessageBox.Show("El carro solicitado no se encuentra registrado o alguno de sus características son incorrectas.", "Lo sentimos...");
                            Limpiar();
                        }
                    }
                    else {
                        //Se deja todo en limpio por si se desea hacer una otra busqueda
                        AutoOrigen(Sucursales, origen);
                        Limpiar();
                    }
                }
            }
        }
        public void ImprimirCarro(Nodo nodo, Auto autoBusqueda, int distancia)
        {
            txtMascercano.Text = "";
            Auto primerAuto = nodo.Autos[0];
            string cercano = $"El auto marca {autoBusqueda.Marca}, modelo {autoBusqueda.Modelo}, color {autoBusqueda.Color}.En la sucursal N# {primerAuto.ID + 1} a una distancia de {distancia} KM";
            txtMascercano.Text = cercano;   
            MessageBox.Show(cercano);

        }
        public void Limpiar()
        {
            txtColor.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            cmbSucursales.SelectedIndex = -1;
        }
        public void LLenar(List<Nodo> Nodos, Lista sucursales, int[] distancias)
        {
            label7.Text = "";//Para borrar el mensaje de salidas xd
            Lista lista = new Lista();
            int x = 0;
            foreach (Nodo nodo in Nodos)
            {
                int ID = nodo.Autos[0].ID;
                int a = ID + 1;
                label7.Text = label7.Text + "\nSucursal N#" + a+ " Encargado: " + Sucursales.ListaSucursal[ID].nombreRESPONSABLE +
                    " Correo Electronico: " + Sucursales.ListaSucursal[ID].direccion + 
                    " Numero de Contacto: " + Sucursales.ListaSucursal[ID].numeroCONTACTO + " a " + distancias[x] + " KM" + ".Direccion: " + Sucursales.ListaSucursal[ID].direccionc;
                x++;

            }
        }
        public void AutoOrigen(Lista sucursales, int ID)
        {
            label6.Text = "";
            int a = ID + 1;
            label6.Text = "\nSucursal N#" + a + " Encargado: " + Sucursales.ListaSucursal[ID].nombreRESPONSABLE +
                    " Correo Electronico: " + Sucursales.ListaSucursal[ID].direccion +
                    " Numero de Contacto: " + Sucursales.ListaSucursal[ID].numeroCONTACTO + " a  0 KM" + "Direccion: " + Sucursales.ListaSucursal[ID].direccionc;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.White;
            Form1 frm = new Form1(grafo,Sucursales);
            frm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e) {
            btnIngresar.BackColor = Color.FromArgb(14, 209, 206);            
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e) {
            btnIngresar.BackColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void btnBuscar_MouseHover(object sender, EventArgs e) {
            btnBuscar.BackColor = Color.FromArgb(18, 170, 181);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e) {
            btnBuscar.BackColor = Color.FromArgb(14, 209, 206);
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarInfo frm1 = new CambiarInfo(grafo, Sucursales);
            frm1.Show();
            this.Hide();

        }

        private void button1_MouseHover(object sender, EventArgs e) {
            button1.BackColor = Color.FromArgb(14, 209, 206);
        }

        private void button1_MouseLeave(object sender, EventArgs e) {
            button1.BackColor = Color.White;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) {

        }
    }
}
