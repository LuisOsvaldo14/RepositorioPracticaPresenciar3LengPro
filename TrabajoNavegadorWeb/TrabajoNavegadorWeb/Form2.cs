using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoNavegadorWeb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 Formulariobuscar = new Form1();
            Formulariobuscar.MdiParent = this;
            Formulariobuscar.Dock = DockStyle.Fill;
            Formulariobuscar.Show();
        }
    }
}
