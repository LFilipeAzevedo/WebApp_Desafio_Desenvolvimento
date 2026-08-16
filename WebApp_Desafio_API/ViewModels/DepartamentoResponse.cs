using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Desafio_API.ViewModels
{
    /// <summary>
    /// Resposta da chamada
    /// </summary>
    public class DepartamentoResponse
    {
        /// <summary>
        /// ID do Departamento
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Descrição do Departamento
        /// </summary>
        [Required(ErrorMessage = "Informe a Descrição do Departamento.")]
        [StringLength(100, ErrorMessage = "A Descrição deve ter no máximo {1} caracteres.")]
        public string descricao { get; set; }
    }
}