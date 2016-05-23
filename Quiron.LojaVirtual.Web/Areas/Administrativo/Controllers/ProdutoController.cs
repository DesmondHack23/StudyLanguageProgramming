﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Entidades;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Areas.Administrativo.Controllers
{
    public class ProdutoController : Controller
    {
       private ProdutosRepositorio _repositorio;
        public ActionResult Index()
        {

            _repositorio = new ProdutosRepositorio();

            var produtos = _repositorio.Produtos;
            return View(produtos);
        }

        public ActionResult NovoProduto(string @class)
        {
            throw new NotImplementedException();
        }

        public ViewResult Alterar(int produtoId)
        {
            _repositorio = new ProdutosRepositorio();
            Produto produto = _repositorio.Produtos
                .FirstOrDefault(p => p.ProdutoId == produtoId);

            return View(produto);
        }

        public ActionResult Excluir()
        {
            throw new NotImplementedException();
        }
    }
}