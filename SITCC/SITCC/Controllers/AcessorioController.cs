using Microsoft.AspNetCore.Mvc;
using SITCC.DAL;
using SITCC.Models;
using System;
using System.Linq;

namespace SITCC.Controllers
{
    public class AcessorioController : Controller
    {    AcessorioDAO A = new AcessorioDAO();

        public IActionResult Index()
        {
            ViewBag.acessorios = A.getTodosAcessorios();
            return View();
        }

        

        [HttpGet]
        public IActionResult Create()
        {
            AcessorioDAO acessorio = new AcessorioDAO();
            ViewBag.listaCategorias = acessorio.getTodosAcessorios();
            return View();
        }
        public ActionResult Index2(int id)
        {
            ViewBag.Acessorios = A.getTodosAcessorios();
            return View();
        }




        public IActionResult comprarAcessorio(int id)
        {
            Acessorios selecionado = A.getacessoriobyID(id);

            if (selecionado != null)
            {
                ViewBag.AcessorioSelecionado = selecionado;
            }

            ViewBag.Acessorios = A.getTodosAcessorios(); // Correção: Use "produtos" em vez de "produto"
            return View("Index2");
        }


        [HttpPost]
        public IActionResult Create(string nomeproduto, double preco, string descricaoproduto, string fotoproduto)
        {
            Acessorios novoAcessorios = new Acessorios();
            novoAcessorios.nomeproduto = nomeproduto;
            novoAcessorios.fotoproduto = fotoproduto;
            novoAcessorios.preco = preco;
            novoAcessorios.descricaoproduto = descricaoproduto;
            A.InsertAcessorios(novoAcessorios);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Acessorios p = new Acessorios();
            AcessorioDAO produtos = new AcessorioDAO();
            ViewBag.AcessorioAtualizar = produtos.getTodosAcessorios().FirstOrDefault(x => x.proID == id);
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string nomeproduto, string descricaoproduto, string codigo, double preco, string fotoproduto)
        {
            Acessorios EditarAcessorios = new Acessorios();
            EditarAcessorios.proID = Convert.ToInt32(codigo);
            EditarAcessorios.nomeproduto = nomeproduto;
            EditarAcessorios.fotoproduto = fotoproduto;
            EditarAcessorios.descricaoproduto = descricaoproduto;
            EditarAcessorios.preco = preco;
            A.UptdateAcessorios(EditarAcessorios);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Apagar(string id)
        {
            Acessorios deleteAcessorios = new Acessorios();
            deleteAcessorios.proID = Convert.ToInt32(id);
            A.ApagarAcessorios(deleteAcessorios);
            return RedirectToAction("Index");
        }
    }
}

