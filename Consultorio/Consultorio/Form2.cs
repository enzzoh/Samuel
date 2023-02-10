using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Consultorio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botaopac_Click(object sender, EventArgs e)
        {


            SqlConnection nn = new SqlConnection(@"Data Source=DESKTOP-VFTSTJG;Initial Catalog=consultorio;Integrated Security=True");

           var sql = "INSERT INTO paciente (Idpaciente, nomepaciente, telefone, senha, Descricaodoença) VALUES (@Idpaciente, @nomepaciente, @telefone, @senha, @Descricaodoença)";
            Random idpac = new Random();
            idpac.Next();
            
            try
            {
                
                SqlCommand c = new SqlCommand(sql, nn);

                c.Parameters.Add(new SqlParameter("idpaciente", idpac.Next()));
                c.Parameters.Add(new SqlParameter("nomepaciente", this.Nomepac.Text));
                c.Parameters.Add(new SqlParameter("telefone", this.teletex.Text));
                c.Parameters.Add(new SqlParameter("senha", this.senhapac.Text));
                c.Parameters.Add(new SqlParameter("Descricaodoença", this.DescProb.Text));
                nn.Open();

                c.ExecuteNonQuery();

                nn.Close();
                MessageBox.Show("enviado");

                
            }
            catch (SqlException ex)
            {

                MessageBox.Show("ocorreu um erro: " + ex);
            }
            finally
            {



                nn.Close();
            }

            var pagconsulta = new PAGconsulta();
            pagconsulta.Show();
            Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
