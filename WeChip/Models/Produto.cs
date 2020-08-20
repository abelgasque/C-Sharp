using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip.Models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }

        public string Descricao { get; set; }

        public float Preco { get; set; }

        public string Tipo { get; set; }
        
        public long CodigoProduto { get; set; }
    }
}
