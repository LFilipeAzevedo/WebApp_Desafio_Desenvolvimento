using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebApp_Desafio_FrontEnd.ViewModels
{
    [DataContract]
    public class ChamadoViewModel : IValidatableObject
    {
        private CultureInfo ptBR = new CultureInfo("pt-BR");

        [Display(Name = "ID")]
        [DataMember(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Assunto")]
        [DataMember(Name = "Assunto")]
        [Required(ErrorMessage = "Informe o Assunto.")]
        [StringLength(150, ErrorMessage = "O Assunto deve ter no máximo {1} caracteres.")]
        public string Assunto { get; set; }

        [Display(Name = "Solicitante")]
        [DataMember(Name = "Solicitante")]
        [Required(ErrorMessage = "Informe o Solicitante.")]
        [StringLength(100, ErrorMessage = "O Solicitante deve ter no máximo {1} caracteres.")]
        public string Solicitante { get; set; }

        [Display(Name = "Departamento")]
        [DataMember(Name = "IdDepartamento")]
        [Range(1, int.MaxValue, ErrorMessage = "Selecione um Departamento.")]
        public int IdDepartamento { get; set; }

        [Display(Name = "Departamento")]
        [DataMember(Name = "Departamento")]
        public string Departamento { get; set; }

        [Display(Name = "Data de Abertura")]
        [DataMember(Name = "DataAbertura")]
        [Required(ErrorMessage = "Informe a Data de Abertura.")]
        public DateTime DataAbertura { get; set; }

        [DataMember(Name = "DataAberturaWrapper")]
        public string DataAberturaWrapper
        {
            get
            {
                return DataAbertura.ToString("d", ptBR);
            }
            set
            {
                DataAbertura = DateTime.Parse(value, ptBR);
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            bool ehNovoRegistro = (ID == 0);

            if (ehNovoRegistro && DataAbertura.Date < DateTime.Now.Date)
            {
                yield return new ValidationResult(
                    "A Data de Abertura não pode ser retroativa.",
                    new[] { nameof(DataAbertura) });
            }
        }
    }
}