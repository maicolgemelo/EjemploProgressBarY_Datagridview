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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcionDatagridview opcionDatagridview = new OpcionDatagridview();
            opcionDatagridview.Show();
            this.Hide();
        }

        private void btnUsoGroupBox_Click(object sender, EventArgs e)
        {
            OpcionGroupBox opcionGroupBox = new OpcionGroupBox();
            opcionGroupBox.Show();
            this.Hide();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
