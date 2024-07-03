using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Ejercicio2GRAFOS;

namespace Ejercicio2GRAFOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
        }

        public void Form2_Load(object sender, EventArgs e)
        {
		}
        public void btbbuscar_Click(object sender, EventArgs e)
        {
            //Creamos el grao que se va ocupar
            btbbuscar.ForeColor = Color.FromArgb(14, 209, 206);
			Grafo grafo = new Grafo();
            LlenarGrafo llenarGrafo = new LlenarGrafo();
            grafo = llenarGrafo.Llenar();
            Lista Sucursales = new Lista();
            LlenarLista a = new LlenarLista();
            Sucursales = a.Llenarlista();
			BuscarCarro frm = new BuscarCarro(grafo,Sucursales);
			frm.Show();
			this.Hide();
        }

        private void btbbuscar_MouseHover(object sender, EventArgs e) {
            btbbuscar.BackColor = Color.FromArgb(211, 42, 0);
            btbbuscar.ForeColor = Color.White;
        }

        private void btbbuscar_MouseLeave(object sender, EventArgs e) {
            btbbuscar.BackColor = Color.White;
            btbbuscar.ForeColor = Color.Black;
        }
    }
}
