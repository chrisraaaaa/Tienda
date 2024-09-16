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
    public partial class MostrarProductos : Form
    {
        ManejadorProductos mp;
        public MostrarProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mp.MostrarRegistros(dtgvProductos, txtBuscar.Text);
        }

        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            mp.MostrarRegistros(dtgvProductos, txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.ShowDialog();
        }
    }
}
