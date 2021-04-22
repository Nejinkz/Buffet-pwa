using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using buffet.Models;
using buffet.Models.Buffet.Cliente;
using buffet.RequestModels;
using buffet.ViewModels.Acesso;
using buffet.ViewModels.Home;

namespace buffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly AcessoService _acessoService;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
  
            return View();
        }

        public IActionResult Politicaprivacidade()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Esqueciasenha()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastro()
        {
            var viewmodel = new CadastrarViewModel();

            viewmodel.Mensagem = (string) TempData["msg-cadastro"];
            viewmodel.ErrosCadastro = (string[]) TempData["erros-cadastro"];
            
            return View(viewmodel);
        }
        [HttpPost]
        public async Task<RedirectResult> Cadastro(AcessoCadastrarRequestModel request)
        {
            var redirectUrl = "/Home/Cadastro";
            var email = request.Email;
            var usuario = request.Usuario;
            var senha = request.Senha;
            var senhaConfirmacao = request.SenhaConfirmacao;

            if (email == null)
            {
                TempData["msg-cadastro"] = "Por favor insire as informações a baixo";
                return Redirect(redirectUrl);
            }

            try
            {
             await  _acessoService.RegistrarUsuario(email, senha);
                return Redirect(url:"/Home/Login");
            }
            catch (CadastrarUsuarioException exception)
            {
                var listaErros = new List<string>();

                foreach (var identityError in exception.Erros)
                {
                    listaErros.Add(identityError.Description);
                }

                TempData["erros-cadastro"] = listaErros;
                return Redirect(url:"/Home/Cadastro");

            }



            return Redirect(redirectUrl);
        }
        public IActionResult Termodeuso()
        {
            return View();
        }
        
        public HomeController(AcessoService acessoService)
        {
            _acessoService = acessoService;

            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}