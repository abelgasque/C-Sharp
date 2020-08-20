using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeChip.Models
{
    public class Status
    {
        [Key]
        public long Id { get; set; }

        public string Descricao { get; set; }

        public Boolean FinalizaCliente { get; set; }

        public Boolean ContabilizarVenda { get; set; }

        public long CodigoStatus { get; set; }
    }
}
