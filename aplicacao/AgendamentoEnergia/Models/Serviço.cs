using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoEnergia.Models
{
    public class Serviço
    {
        public long ServiçoID { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma descrição valida!")]
        [DisplayName("Serviço")]
        public string Descrição { get; set; }

        [Required(ErrorMessage = "Por favor, insira um valor valido")]
        [DisplayName("Valor")]
        public float Valor { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma duração valida!")]
        [DisplayName("Duração")]
        public string Duração { get; set; }
    }
}