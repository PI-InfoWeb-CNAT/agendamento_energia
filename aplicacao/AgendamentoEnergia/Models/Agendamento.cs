using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoEnergia.Models
{
    public class Agendamento
    {
        public long AgendamentoID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dataExecucao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataCriacao { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dataAgendamento { get; set; }

        public string Descricao { get; set; }
        public bool Executado { get; set; }
        public bool BemSucedido { get; set; }
        public bool Confirmado { get; set; }
        public long UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public long ServiçoID { get; set; }
        public virtual Serviço Serviço { get; set; }

    }
}