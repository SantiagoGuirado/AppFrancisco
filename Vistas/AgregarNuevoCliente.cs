using System;
using System.Windows.Forms;

namespace AppFrancisco.Vistas
{
    public partial class AgregarNuevoCliente : Form
    {
        //Atributos
        private int dni;
        private String nombre;
        private Int64 telefono;
        private Boolean bandera = false;

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
            _bandera = false;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _dni = Convert.ToInt32(tbDNI.Text.ToString());
            _nombre = tbNombre.Text.ToString();
            _telefono = Convert.ToInt64(tbTelefono.Text.ToString());
            _bandera = true;
            this.Close();
        }

        //Setters && Getters
        public int _dni { get => dni; set => dni = value; }
        public string _nombre { get => nombre; set => nombre = value; }
        public Int64 _telefono { get => telefono; set => telefono = value; }
        public bool _bandera { get => bandera; set => bandera = value; }
    }
}