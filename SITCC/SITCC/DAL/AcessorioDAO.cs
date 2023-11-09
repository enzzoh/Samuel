using Dapper;
using SITCC.DAL.CárdapioV3_Tunado.DAL;
using SITCC.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SITCC.DAL
{
    public class AcessorioDAO
    {

        SqlConnection _connection;
        public AcessorioDAO()
        {
            _connection = ConexaoBD.getConexao();
        }
        public Acessorios getacessoriobyID(int id)
        {
            string query = "SELECT * FROM Acessorios WHERE proID = @id";
            return _connection.QueryFirstOrDefault<Acessorios>(query, new { id });
        }

        public List<Acessorios> getAcessoriospopular()
        {
            string sql = "SELECT * FROM Acessorios WHERE proID IN (9,6,8);";
            var dados = (List<Acessorios>)_connection.Query<Acessorios>(sql);
            return dados;
        }



        public List<Acessorios> getTodosAcessorios()
        {
            var sql = "select * from Acessorios";

            var dados = (List<Acessorios>)_connection.Query<Acessorios>(sql);
            return dados;
        }

        public void InsertAcessorios(Acessorios novoAcessorios)
        {
            string query = "Insert into Acessorios (nomeproduto, preco, descricaoproduto, fotoproduto) values (@nomeproduto, @preco, @descricaoproduto, @fotoproduto)";

            _connection.Execute(query, novoAcessorios);
        }

        public void UptdateAcessorios(Acessorios EditarAcessorios)
        {
            string query = "update Acessorios set nomeproduto=@nomeproduto, DescricaoProduto=@DescricaoProduto, preco=@preco, fotoproduto=@fotoproduto  where proID=@proID";

            _connection.Execute(query, EditarAcessorios);

        }

        public void ApagarAcessorios(Acessorios deleteAcessorios)
        {
            string query = "Delete from Acessorios where proID=@proID";

            _connection.Execute(query, deleteAcessorios);

        }


    }
}

