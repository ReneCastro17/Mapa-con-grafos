using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2GRAFOS;

namespace Ejercicio2GRAFOS
{
    /*Roberto José Melgares Zelaya - MZ221682
        René Eduardo Hernández Castro - HC220857
        Oscar Edgardo Navarro Banderas - NB220557
    */
    public partial class Form1 : Form
    {
        public Grafo grafo;
        public Lista Sucursales;
        public Form1(Grafo grafo, Lista Sucursales)
        {
            InitializeComponent();
            this.grafo = grafo;
            this.Sucursales = Sucursales;
            txtAgregarModelo.Text = txtAgregarMarca.Text = txtAgregarColor.Text = "";
            cmbAgregarCarro.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(txtAgregarColor.Text == "" || txtAgregarMarca.Text == "" || txtAgregarModelo.Text == "" || cmbAgregarCarro.Text == "") 
            {
                MessageBox.Show("Aun hay datos que no se han llenado para el registro", "Datos Faltantes");
            }
            else {
                //expresiones regulares
                if (!Regex.IsMatch(txtAgregarMarca.Text, @"\w")) { //la marca no puede llevar numero, los demas si
                    MessageBox.Show("El nombre de la marca no es valido", "Por favor, intentelo nuevamente");
                    txtAgregarMarca.Focus();
                }
                else if(!Regex.IsMatch(txtAgregarColor.Text, @"^[A-Z][a-z0-9_-]*$")) {
                    MessageBox.Show("El color especificado no es valido", "Por favor, intentelo nuevamente");
                    txtAgregarColor.Focus();
                }
                else if (!Regex.IsMatch(txtAgregarModelo.Text, @"^[A-Z][a-zA-Z0-9- ]*$")) {
                    MessageBox.Show("El nombre del modelo no es valido", "Por favor, intentelo nuevamente");
                    txtAgregarModelo.Focus();
                }
                else 
                {
                    int nodoX = cmbAgregarCarro.SelectedIndex;
                    string color = txtAgregarColor.Text;
                    string marca = txtAgregarMarca.Text;
                    string modelo = txtAgregarModelo.Text;
                    //Crea un nuevo objeto carro y lo agrega al nodo correspondiente
                    Auto auto = new Auto(nodoX, marca, color, modelo);
                    grafo.AgregarAutoNodo(nodoX, auto);
                    MessageBox.Show("Auto agregado correctamente");
                    Limpiar();
                }
            }
        }
        public void Limpiar()
        {
            txtAgregarColor.Clear();
            txtAgregarMarca.Clear();
            txtAgregarModelo.Clear();
            txtAgregarColor.Clear();
            cmbAgregarCarro.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCarro frm = new BuscarCarro(grafo,Sucursales);
            frm.Show();
            this.Hide();

        }

        private void button1_MouseHover(object sender, EventArgs e) {//btn 1 registrar
            button1.BackColor = Color.FromArgb(18, 170, 181);
        }

        private void button1_MouseLeave(object sender, EventArgs e) {
            button1.BackColor = Color.FromArgb(14, 209, 206);
        }

        private void button2_MouseHover(object sender, EventArgs e) {//btn 2 regresasr
            button2.BackColor = Color.FromArgb(14, 209, 206);

        }
        private void button2_MouseLeave(object sender, EventArgs e) {
            button2.BackColor = Color.White;
        }

    }
}
