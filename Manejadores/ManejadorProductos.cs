using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorProductos
    {
        Base b = new Base("localhost", "root", "", "proyectotienda");

        public void MostrarRegistros(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar($"SELECT * FROM productos WHERE codigoBarras LIKE '%{filtro}%'", "productos").Tables[0];
            tabla.Columns.Insert(5, Boton("Eliminar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Flat;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }

        public void InsertarProductos(string codigo, string nombre, string descrpcion, string precio)
        {
            b.Comando($"INSERT INTO productos VALUES (NULL, {int.Parse(codigo)}, '{nombre}', '{descrpcion}', {double.Parse(precio)});");
        }
    }
}
