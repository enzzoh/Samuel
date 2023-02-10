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
    public partial class Medicoconsulta : Form
    {
        public Medicoconsulta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection nn = new SqlConnection(@"Data Source=DESKTOP-VFTSTJG;Initial Catalog=consultorio;Integrated Security=True");
            string Pegar = "SELECT * FROM Consulta data1";
           
            
            
            Nomepac1.Text = Pegar.ToString();
            

           
        }
    }
}
