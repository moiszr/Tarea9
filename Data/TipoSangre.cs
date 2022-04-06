using System.ComponentModel.DataAnnotations;

namespace Tarea9.Data
{
    public class TipoSangre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
