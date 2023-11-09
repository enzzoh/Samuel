using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SITCC.DAL;
using SITCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SITCC.Controllers
{
    public class SiteController : Controller
    {

        ProdutoDAO produtos = new ProdutoDAO();
      AcessorioDAO A = new AcessorioDAO();
        // GET: SiteController
        public ActionResult Index()
        {
            ViewBag.acessorios = A.getTodosAcessorios();
            ViewBag.produtos = produtos.getTodosProdutos();
            ViewBag.produtosP = produtos.getprodutopopular();
        


            return View();
        }

        public ActionResult Index1(int id)
        {
           ViewBag.produtos = produtos.getTodosProdutos();
            return View();
        }




        public IActionResult comprar(int id)
        {
            produto selecionado = produtos.getprodutobyID(id);

            if (selecionado != null)
            {
                ViewBag.ProdutoSelecionado = selecionado;
            }

            ViewBag.produtos = produtos.getTodosProdutos(); // Correção: Use "produtos" em vez de "produto"
            return View("Index1");
        }

        // GET: SiteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SiteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SiteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SiteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SiteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SiteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SiteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
    