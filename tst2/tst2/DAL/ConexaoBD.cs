using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using tst2.Models;

namespace tst2.DAL
{
    public class ConexaoBD
    {
    
        public SqlConnection conectar = new SqlConnection(@"Data Source=.\SENAI2022;Initial Catalog=Escola;User ID=sa;Password=senai.123");
        public ConexaoBD()
        {
            if (conectar.State == System.Data.ConnectionState.Closed)
            {
                conectar.Open();
            }



        }

       
    }
}

