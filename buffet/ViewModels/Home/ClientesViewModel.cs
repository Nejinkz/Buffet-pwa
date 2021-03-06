using System.Collections.Generic;

namespace buffet.ViewModels.Home
{
    public class ClientesViewModel
    {
      public List<Cliente> Clientes { get; set; }

      public ClientesViewModel()
      {
          Clientes = new List<Cliente>();
      }

    }
    
    public class Cliente
    {
        public string Nome { get; set; }

        public string Email { get; set; }
        public string DataDeNascimento { get; set; }
      
    }
}