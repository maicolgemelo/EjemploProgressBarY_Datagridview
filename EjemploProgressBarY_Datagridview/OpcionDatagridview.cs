using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProgressBarY_Datagridview
{
    public partial class OpcionDatagridview : Form
    {
        public OpcionDatagridview()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            dtRegistros.Rows.Add(txtCedula.Text,txtNombre.Text,txtEdad.Text);
            MessageBox.Show("Redistro Guardado exitosamnete ");
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtCedula.Focus();

        }

        private void dtRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dtRegistros.Rows[dtRegistros.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dtRegistros.Rows[dtRegistros.CurrentRow.Index].Cells[1].Value.ToString();
            txtEdad.Text = dtRegistros.Rows[dtRegistros.CurrentRow.Index].Cells[2].Value.ToString();

            dtRegistros.Rows.RemoveAt(dtRegistros.CurrentRow.Index);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fila = int.Parse(txtFila.Text);
            dtRegistros.CurrentCell = dtRegistros.Rows[(fila - 1)].Cells[0];

            DialogResult Respuesta = MessageBox.Show("Estas seguro de eliminar? " 
                                     ," Validacion de respuesta "
                                     ,MessageBoxButtons.YesNo
                                     ,MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes) {
                dtRegistros.Rows.RemoveAt(dtRegistros.CurrentRow.Index);
                txtFila.Text = "";

            } else {
                txtFila.Focus();
                txtFila.Text = "";


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
