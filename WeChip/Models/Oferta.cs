using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip.Models
{
    public class Oferta
    {
        [Key]
        public long Id { get; set; }

        public long IdProduto { get; set; }

        public Produto Produto { get; set; }
    }
}
