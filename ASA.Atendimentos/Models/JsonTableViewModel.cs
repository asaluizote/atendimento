using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASA.Atendimentos.Models
{
    public class JsonTableViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public string Salary { get; set; }
        public string StartDate { get; set; }

        [Display(Name="CPF")]
        [Required(ErrorMessage = "* {0} é obrigatório")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "* {0} deve ter no mínimo 14 caracteres")]
        //Classe de validação criada para funcionar com o jquery.validate.unobtrusive
        [CustomValidationCPF(ErrorMessage = "* CPF inválido")] 
        public string CPF { get; set; }
    }
}