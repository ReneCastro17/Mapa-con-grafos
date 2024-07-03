using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2GRAFOS;

namespace Ejercicio2GRAFOS
{
    public partial class CambiarInfo : Form
    {
        public Grafo grafo;
        public Lista Sucursales;
        public CambiarInfo(Grafo grafo, Lista Sucursales)
        {
            InitializeComponent();
            //instancia el grafo que recibe como parámetro
            this.grafo = grafo;
            this.Sucursales = Sucursales;
            comboSucursales.SelectedIndex = 0;
        }

        private void btbcambiar_Click(object sender, EventArgs e)
        {
            if (txtContacto.Text == "" || txtDireccionC.Text == "" || txtNombre.Text == "" || comboSucursales.Text == "")
            {
                MessageBox.Show("No se ha modificado ningún campo.", "ERROR");
            }
            else
            {
                if (!Regex.IsMatch(txtContacto.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("El télefono de contacto no es válido.", "Advertencia");
                    txtContacto.Focus();
                }
                else if (!Regex.IsMatch(txtDireccionC.Text, @"\w")) {
                    MessageBox.Show("La dirección ingresada no es válida.", "Advertencia");
                    txtNombre.Focus();
                }
                else if (!Regex.IsMatch(txtDireccion.Text, @"^.*@.*\.com$"))
                {
                    MessageBox.Show("El correo eléctronico no es válido.", "Advertencia");
                    txtDireccionC.Focus();
                }
                else if (!Regex.IsMatch(txtNombre.Text, @"\w"))
                {
                    MessageBox.Show("El nombre ingresado no es válido.", "Advertencia");
                    txtNombre.Focus();
                }
                else
                {
                    //Modifica la posicion especifica del la sucursal para poder cambiar la información
                    int i = comboSucursales.SelectedIndex;
                    Sucursales.ListaSucursal[i].numeroCONTACTO = txtContacto.Text;
                    Sucursales.ListaSucursal[i].nombreRESPONSABLE = txtNombre.Text;
                    Sucursales.ListaSucursal[i].direccion = txtDireccion.Text;//direccion es de correo 
                    Sucursales.ListaSucursal[i].direccionc = txtDireccionC.Text;//direccion c  = direccion de calle
                    MessageBox.Show("Datos actualizados correctamente");
                    LImpiar();
                }
            }
        }
        public void LImpiar()
        {
            //Setea todos los campos vacios
            txtContacto.Text = "";
            txtDireccionC.Text = "";
            txtNombre.Text = "";
            comboSucursales.SelectedIndex = -1;
        }

        private void btbRegresar_Click(object sender, EventArgs e)
        {
            BuscarCarro frm = new BuscarCarro(grafo, Sucursales);
            frm.Show();
            this.Hide();
        }

        private void btbRegresar_MouseHover(object sender, EventArgs e) {
            btbRegresar.BackColor = Color.FromArgb(14, 209, 206);

        }

        private void btbRegresar_MouseLeave(object sender, EventArgs e) {
            btbRegresar.BackColor = Color.White;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
