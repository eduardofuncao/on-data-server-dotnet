using System.ComponentModel.DataAnnotations;

namespace OnData.Models
{
    public class Ocorrencia
    {
        [Key]
        public int IdOcorrencia { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public decimal Valor { get; set; }


        [Required]
        public bool Aprovado { get; set; }

        // Foreign key relationship
        public int PacienteId { get; set; }
 
    }
}