using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoEnergia.Models
{
    public class Usuario
    {

        public long UsuarioID { get; set; }

        [Required(ErrorMessage = "Por favor, insira seu nome")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira seu endereço")]
        [DisplayName("Endereço")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Por favor, insira seu numero de celular")]
        [DisplayName("Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma sehna")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        
    }
}