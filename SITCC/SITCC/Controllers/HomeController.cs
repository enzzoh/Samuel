using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SITCC.DAL;
using SITCC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SITCC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProdutoDAO produto = new ProdutoDAO();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.produtos = produto.getTodosProdutos();
            return View();
        }

        //create
        [HttpGet]
    
        public IActionResult create()
        {

            ProdutoDAO produtos = new ProdutoDAO();
           
            ViewBag.listaCategorias = produtos.getTodosProdutos();
            return View();

        }

        [HttpPost]

        public IActionResult create(string nomeproduto, double preco, string descricaoproduto)
        {   
            
            produto NovoProduto = new produto();
            NovoProduto.nomeproduto = nomeproduto;
            NovoProduto.preco = preco;
            NovoProduto.descricaoproduto = descricaoproduto;
            produto.InsertProduto(NovoProduto);
            return RedirectToAction("Index");

        }
        //atualizar
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            produto p = new produto();
            ProdutoDAO produtos = new ProdutoDAO();
            ViewBag.ProdutoAtualizar = produtos.getTodosProdutos().FirstOrDefault(x => x.proID == id);
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string nomeproduto, string descricaoproduto, string codigo, double preco)
        {
           
       
            produto AtualizarProduto = new produto();
            AtualizarProduto.proID = Convert.ToInt32(codigo);
            AtualizarProduto.nomeproduto = nomeproduto;
            AtualizarProduto.descricaoproduto = descricaoproduto;
            AtualizarProduto.preco = preco;


            produto.UptdateProduto(AtualizarProduto);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Apagar(string id)
        {

            produto apagarProduto = new produto();
            apagarProduto.proID = Convert.ToInt32(id);
            produto.ApagarProduto(apagarProduto);

            return RedirectToAction("Index");
        }





















        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
