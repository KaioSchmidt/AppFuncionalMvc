using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AppMvc.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = " O Campo {0} é obrigadtorio")]
        public string Nome { get; set; }
        public string Email  { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Cpf { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMatricula  { get; set; }
        public bool Ativo { get; set; }
    }
}