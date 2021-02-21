using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFrancisco.Vistas
{
    public partial class AgregarNuevoCliente : Form
    {
        //Atributos
        private int dni;
        private String nombre;
        private int telefono;

        //Constructor
        public AgregarNuevoCliente()
        {
            InitializeComponent();
        }

        //Metodos
        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _dni = Convert.ToInt32(tbDNI.Text.ToString());
            _nombre = tbNombre.Text.ToString();
            _telefono = Convert.ToInt32(tbTelefono.Text.ToString());
            this.Close();
        }

        //Setters && Getters
        public int _dni { get => dni; set => dni = value; }
        public string _nombre { get => nombre; set => nombre = value; }
        public int _telefono { get => telefono; set => telefono = value; }
    }
}