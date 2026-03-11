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
    public partial class FormPaginaBuscada : Form
    {
        private string buscada;
        public FormPaginaBuscada(string busqueda)
        {
            InitializeComponent();
            buscada = busqueda;
        }

        private async void FormPaginaBuscada_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            if (!buscada.Contains("."))
            {
                buscada = "https://www.google.com/search?q=" + buscada;
            }
            else if (!buscada.StartsWith("http://") && !buscada.StartsWith("https://"))
            {
                buscada = "http://" + buscada;
            }
            textBox1.Text = (buscada);
            webView21.CoreWebView2.Navigate(buscada);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            
            string buscar = textBox1.Text;
            if (!buscar.Contains("."))
            {
                buscar = "https://www.google.com/search?q=" + buscar;
            }
            else if (!buscar.StartsWith("http://") && !buscar.StartsWith("https://"))
            {
                buscar = "http://" + buscar;
            }                                           
            webView21.CoreWebView2.Navigate(buscar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Formulariobuscar = new Form1();
            Formulariobuscar.MdiParent = this.MdiParent;
            Formulariobuscar.Dock = DockStyle.Fill;
            Formulariobuscar.Show();
            this.Close();
        }
    }
}
