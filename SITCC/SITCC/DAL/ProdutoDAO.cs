using Dapper;
using SITCC.DAL.CárdapioV3_Tunado.DAL;
using SITCC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SITCC.DAL
{
    public class ProdutoDAO
    {

        SqlConnection _connection;
        public ProdutoDAO()
        {
            _connection = ConexaoBD.getConexao();
        }

        public List<produto> getTodosProdutos()
        {
            var sql = "select * from produtos";

            var dados = (List<produto>)_connection.Query<produto>(sql);
            return dados;
        }

        public void InsertProduto(produto novoProduto)
        {
            string query = "Insert into produtos (nomeproduto, preco, descricaoproduto) values (@nomeproduto, @preco, @descricaoproduto)";

            _connection.Execute(query, novoProduto);
        }

        public void UptdateProduto(produto EditarProduto)
        {
            string query = "update produtos set nomeproduto=@nomeproduto, DescricaoProduto=@DescricaoProduto, preco=@preco  where proID=@proID";

            _connection.Execute(query, EditarProduto);

        }

        public void ApagarProduto(produto deleteProduto)
        {
            string query = "Delete from produtos where proID=@proID";

             _connection.Execute(query, deleteProduto);

        }


    }
}
