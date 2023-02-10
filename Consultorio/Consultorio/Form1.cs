using System.Runtime.ConstrainedExecution;

namespace Consultorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Botaomedico_Click(object sender, EventArgs e)
        {
            var medico = new Medicoform();
            medico.Show();
            Hide();

        }

        private void botaopac_Click(object sender, EventArgs e)
        {
            var paciente = new Form2();
            paciente.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}