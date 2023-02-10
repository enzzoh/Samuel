using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Consultorio
{
    public partial class PAGconsulta : Form
    {
        public PAGconsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection nn = new SqlConnection(@"Data Source=DESKTOP-VFTSTJG;Initial Catalog=consultorio;Integrated Security=True");

            var sql = "INSERT INTO consulta (Idpaciente, nomepaciente, telefone, senha) VALUES (@Idpaciente, @nomepaciente, @telefone, @senha)";
            Random idpac = new Random();
            idpac.Next();

            Random RANDOMPACID= new Random();
            var RANDOMPAC = RANDOMPACID.Next(1,999999999);

            Random data1 = new Random();
           int data11 =  data1.Next(3, 13);
          
            Random data2 = new Random();
            int data22 =data2.Next(1, 31);
            Random hora1 = new Random();
            int hora11 = hora1.Next(1,25);
            Random hora2 = new Random();
           int hora22 = hora1.Next(1, 61);

            var datacompleta =  data11+"/"+data22+"/23";
            var HoraConsulta =  hora11 + ":" + hora22;


            datacons.Text = datacompleta.ToString();
            Horacons.Text = HoraConsulta.ToString();
            senhaaleatoria.Text = RANDOMPAC.ToString();















































        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void datacons_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceitarbutton_Click(object sender, EventArgs e)
        {
            SqlConnection nn = new SqlConnection(@"Data Source=DESKTOP-VFTSTJG;Initial Catalog=consultorio;Integrated Security=True");

            var sql = "INSERT INTO consulta (data1, hora, senhaaleatoria) VALUES (@data1, @hora, @senhaaleatoria)";

            try
            {

                SqlCommand c = new SqlCommand(sql, nn);

                c.Parameters.Add(new SqlParameter("data1", this.datacons.Text));
                c.Parameters.Add(new SqlParameter("hora", this.Horacons.Text));
                c.Parameters.Add(new SqlParameter("senhaaleatoria", this.senhaaleatoria.Text));
                
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













        }
    }
}
