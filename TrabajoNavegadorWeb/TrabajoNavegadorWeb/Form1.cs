using System;
using System.Windows.Forms;

namespace TrabajoNavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string busqueda = textBox1.Text;
            FormPaginaBuscada hijoformPagina = new FormPaginaBuscada(busqueda);
            hijoformPagina.MdiParent = this.MdiParent;   
            hijoformPagina.Dock = DockStyle.Fill;
            hijoformPagina.Show();
            this.Close();
            
        }

    }
}
