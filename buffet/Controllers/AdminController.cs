using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using buffet.Models;
using buffet.Models.Buffet.Cliente;
using buffet.ViewModels.Home;

namespace buffet.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
  
            return View();
        }

        public IActionResult Ajuda()
        {
  
            return View();
        }
        public IActionResult Secao()
        {
  
            return View();
        }
        public IActionResult Politicaprivacidade()
        {
  
            return View();
        }
        public IActionResult Termodeuso()
        {
  
            return View();
        }
   
        
        public IActionResult Clientes()
        {
            var clienteService = new ClienteService();
            var listaDeClientes = clienteService.obterClientes();

            var viewModel = new ClientesViewModel();
            foreach (ClienteEntity clienteEntity in listaDeClientes)
            {
                viewModel.Clientes.Add(new Cliente
                {
                    Nome = clienteEntity.Nome,
                        DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString()
                });
            }

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}