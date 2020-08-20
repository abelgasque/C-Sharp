using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip.Models
{
    public class Cliente
    {
        [Key]
        public long Id { get; set; } 
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public float Credito { get; set; }

        public string Telefone { get; set; }

        public string Status { get; set; }
    }
}
