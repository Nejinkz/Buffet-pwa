using System;
using System.Threading.Tasks;
using buffet.ViewModels.Home;
using buffet.ViewModels.Acesso;
using Microsoft.AspNetCore.Identity;

namespace buffet.Models
{
    public class AcessoService
    {
        private readonly UserManager<Cliente> _userManager;
        private readonly SignInManager<Cliente> _signInManager;


        public AcessoService(UserManager<Cliente> userManager, SignInManager<Cliente> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task RegistrarUsuario(string email, string senha)
        {
            var novoUsuario = new Cliente()
            {
                Nome =  email,
                Email =  email
            };

            var resultado = await _userManager.CreateAsync(novoUsuario);

           if (!resultado.Succeeded)
           {
               throw new CadastrarUsuarioException(resultado.Errors);
           }

        }
    }
}