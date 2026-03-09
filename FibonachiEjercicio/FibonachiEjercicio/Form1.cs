using System.Timers;

namespace FibonachiEjercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Limite = Convert.ToDouble(textBox1.Text);
            Double Num1 = 1;
            Double Num2 = 1;
            Double Anterior = 1;



            for (Double i = 0; Anterior < Limite;)
            {
                listBox1.Items.Add(Anterior);
                Num1 = Anterior;
                Anterior = Num2;
                Num2 = Num1 + Num2;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
