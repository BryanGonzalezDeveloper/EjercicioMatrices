using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMatrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsMatriz objMatriz;
        private void btnSuma_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(txtCantidad.Text);
                dgvMatriz.ColumnCount = cantidad;
                dgvMatriz.RowCount = cantidad;
            objMatriz = new clsMatriz(cantidad);
            objMatriz.imprimirMatriz = llenarDGV;
            objMatriz.llenarMatriz();

        }

        void llenarDGV(int numero,int fila,int columna)
        {
            dgvMatriz[columna, fila].Value = numero;
        }
    }
}
