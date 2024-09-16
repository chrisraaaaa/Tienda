using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace TiendaPresentacion
{
    public partial class Productos : Form
    {
        ManejadorProductos mp;
        public Productos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();  
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            mp.InsertarProductos(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtPrecio.Text);
            MessageBox.Show("Producto Insertado!");
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
