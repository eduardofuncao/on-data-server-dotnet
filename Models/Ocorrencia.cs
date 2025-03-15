// Ocorrencia.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace OnData.Models
{
    public class Ocorrencia
    {
        [Key]
        public int IdOcorrencia { get; set; }

        [Required(ErrorMessage = "O nome da ocorrência é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome da ocorrência não pode ter mais de 200 caracteres.")]
        public string NomeOcorrencia { get; set; }

        [Required(ErrorMessage = "Os detalhes da ocorrência são obrigatórios.")]
        public string Detalhes { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser maior ou igual a zero.")]
        public decimal? Valor { get; set; }

        public bool? Aprovado { get; set; }

        [Required(ErrorMessage = "O ID do paciente é obrigatório.")]
        public int PacienteId { get; set; }

        public Paciente Paciente { get; set; }
    }
}