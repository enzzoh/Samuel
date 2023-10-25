using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SITCC.DAL
{

namespace CárdapioV3_Tunado.DAL
    {
        public class ConexaoBD
        {
            private static SqlConnection _banco;

            public static SqlConnection getConexao()
            {
                if (_banco == null)
                {
                    
                   // return _banco = new SqlConnection(@"Data Source=.\SENAI2022;Initial Catalog=siteTCC;User ID=sa;Password=senai.123");
                    return _banco = new SqlConnection(@"Data Source=DESKTOP-9QCDCE8;Initial Catalog=siteTCC;Integrated Security=True");
                }
                else
                {
                    return _banco;
                }
            }
        }
    }
}

