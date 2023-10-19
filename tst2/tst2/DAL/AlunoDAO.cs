using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tst2.Models;
using Dapper;

namespace tst2.DAL
{
    public class AlunoDAO
    {
       
            ConexaoBD conexao;
            public AlunoDAO()
            {

                conexao = new ConexaoBD();



            }


            public List<alunos> GetAlunos()
            {

                var sql = "select * from alunos";

                var dados = (List<alunos>)conexao.query<alunos>(sql);
               return dados.ToList();
            }

        
    }
}
