namespace FichadeEmpregado
{
    public partial class Form1 : Form
    {
        Empregado? empregado = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (empregado == null)
            {
                empregado = new Empregado();
            }
            empregado.Nome = Convert.ToString(textBox1.Text);
            empregado.Idade = Convert.ToInt32(label3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = empregado.Nome;
            label7.Text = empregado.Idade.ToString();
            groupBox2.BackColor = Color.Khaki;

        }
    }
}