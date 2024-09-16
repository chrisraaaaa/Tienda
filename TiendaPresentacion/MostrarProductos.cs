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

        public void Mostrar()
        {
            mp.MostrarRegistros(dtgvProductos, txtBuscar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.ShowDialog();
        }

        int fila, columns, id;
        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columns = e.ColumnIndex;
            switch (columns)
            {
                case 5:
                    {
                        id = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        mp.Borrar(id);
                        Mostrar();
                        txtBuscar.Text = "";
                        txtBuscar.Focus();
                    }break;
            }
        }
    }
}
