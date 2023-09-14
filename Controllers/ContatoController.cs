﻿using Microsoft.AspNetCore.Mvc;
using Primeiro_Site.Models;
using Primeiro_Site.Repositorio;

namespace Primeiro_Site.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            var contatos = _contatoRepositorio.BuscarTodos();

            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Confirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)            
        {
            _contatoRepositorio.Adicionar(contato);

            return RedirectToAction("Index");
        }
    }
}