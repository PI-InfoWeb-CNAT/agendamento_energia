using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoEnergia.Models
{
    public class Sistema
    {
        public int SistemaID { get; set; }

        public string Nome { get; set; }
        public float Potencia { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataInstalação { get; set; }

        public long UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}