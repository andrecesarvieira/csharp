using System.ComponentModel.DataAnnotations;

namespace SharpPontoWeb.Models
{
    public class Registro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateOnly Data { get; set; }
        [Required]
        public TimeOnly Entrada { get; set; }
        [Required]
        public TimeOnly Almoco { get; set; }
        [Required]
        public TimeOnly Retorno { get; set; }
        [Required]
        public TimeOnly Saida { get; set; }
        public TimeOnly Manha { get; set; }
        public TimeOnly Tarde { get; set; }
        public TimeOnly TotalDia { get; set; }
    }
}