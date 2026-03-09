using System.Data;

namespace SolucionDataGridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
            comboBox1.SelectedIndex = -1;
        }
    }
}
