using System.ComponentModel.DataAnnotations;

namespace on_data_server_dotnet.Models
{
    public class Occurrence
    {
        [Key]
        public int IdOcorrencia { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public TimeSpan Duracao { get; set; }

        [Required]
        public bool Aprovado { get; set; }

        // Foreign key relationship
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}