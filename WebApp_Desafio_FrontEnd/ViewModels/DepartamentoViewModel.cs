using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebApp_Desafio_FrontEnd.ViewModels
{
    [DataContract]
    public class DepartamentoViewModel
    {
        [Display(Name = "ID")]
        [DataMember(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Descrição")]
        [DataMember(Name = "Descricao")]
        [Required(ErrorMessage = "Informe a Descrição do Departamento.")]
        [StringLength(100, ErrorMessage = "A Descrição deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }

    }
}