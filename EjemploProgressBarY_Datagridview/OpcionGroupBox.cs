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
    public partial class OpcionGroupBox : Form
    {
        public OpcionGroupBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbGenero.Location = new Point(160, 132);
            gbGenero.Visible = true;
            gbNacionalidad.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbNacionalidad.Location = new Point(160, 132); 
            gbNacionalidad.Visible = true;
            gbGenero.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
