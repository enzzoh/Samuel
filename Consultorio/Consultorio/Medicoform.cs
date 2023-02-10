using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Medicoform : Form
    {
        public Medicoform()
        {
            InitializeComponent();
        }

        private void Savemed_Click(object sender, EventArgs e)
        {
            SqlConnection nn = new SqlConnection(@"Data Source=DESKTOP-VFTSTJG;Initial Catalog=consultorio;Integrated Security=True");

            var sql = "INSERT INTO medico (Idmedico, nomemedico, CPFMEDICO, RGMEDICO, SENHAMEDICO) VALUES (@Idmedico, @nomemedico, @CPFMEDICO, @RGMEDICO, @SENHAMEDICO)";
            Random idpac = new Random();
            idpac.Next();

            try
            {

                SqlCommand c = new SqlCommand(sql, nn);

                c.Parameters.Add(new SqlParameter("idmedico", idpac.Next()));
                c.Parameters.Add(new SqlParameter("nomemedico", this.Nomemedico.Text));
                c.Parameters.Add(new SqlParameter("CPFMEDICO", this.cpfmedico.Text));
                c.Parameters.Add(new SqlParameter("RGMEDICO", this.rgmedico.Text));
                c.Parameters.Add(new SqlParameter("SENHAMEDICO", this.senhamedico.Text));
                










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

            var medicoconsulta = new Medicoconsulta();
            medicoconsulta.Show();
            Hide();
            

        }
    }
}
