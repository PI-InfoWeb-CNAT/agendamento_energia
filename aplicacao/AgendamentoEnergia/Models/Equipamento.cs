using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoEnergia.Models
{
    public class Equipamento
    {
        public long EquipamentoID { get; set; }

        [Required(ErrorMessage = "Por favor, selecione um tipo valido!")]
        [DisplayName("Tipo")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Por favor, inira um DataSheet valida!")]
        [DisplayName("DataSheet")]
        public string DataSheet { get; set; }

        [Required(ErrorMessage = "Por favor, inira uma potencia valida!")]
        [DisplayName("Potencia")]
        public float Potencia { get; set; }

        [DisplayName("Detalhes")]
        public string Detalhes { get; set; }
    }
}