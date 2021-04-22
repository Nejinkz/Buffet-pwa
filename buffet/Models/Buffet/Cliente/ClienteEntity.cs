using System;
using System.ComponentModel.DataAnnotations;

namespace buffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        [Key] public int Id { get; set; }
        [Required]public string Nome { get; set; }
        
        public string Email{ get; set; }
        public DateTime DataDeNascimento { get; set; }
        
    }
}