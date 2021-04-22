using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace buffet.ViewModels.Acesso
{
    public class CadastrarUsuarioException : Exception
    {
        public IEnumerable<IdentityError> Erros { get; set; }

        public CadastrarUsuarioException(IEnumerable<IdentityError> erros)
        {
            Erros = erros;
        }
    }
}