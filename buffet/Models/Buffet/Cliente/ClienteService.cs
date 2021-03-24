using System;
using System.Collections.Generic;

namespace buffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        public List<ClienteEntity> obterClientes()
        {
            var listaDeClientes = new List<ClienteEntity>();

            listaDeClientes.Add(new ClienteEntity
            {
                Id = 1,
                Nome = "Daryl",
                DataDeNascimento = new DateTime(1977, 12, 1)
            } );
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 2,
                Nome = "Dary",
                DataDeNascimento = new DateTime(1987, 6, 24)
            } );
            
            return listaDeClientes;
        }
    }
}