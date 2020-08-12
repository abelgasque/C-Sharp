using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.WebAPI.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatorio!")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter no maximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no minimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo email é obrigatorio!")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter no maximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no minimo 3 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo senha é obrigatorio!")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter no maximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no minimo 3 caracteres")]
        public string Senha { get; set; }
    }
}
