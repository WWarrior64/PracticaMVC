using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class equipos
    {
        [Key]
        [DisplayName("ID de Equipo")]
        public int id_equipos { get; set; }

        [DisplayName("Nombre del equipo")]
        [Required(ErrorMessage = "El nombre del equipo NO es opcional!")]
        public string nombre { get; set; }

        [DisplayName("Descripción")]
        public string descripcion { get; set; }

        [DisplayName("Tipo de Equipo ID")]
        public int? tipo_equipo_id { get; set; }

        [DisplayName("Marca ID")]
        public int? marca_id { get; set; }

        [DisplayName("Modelo")]
        [Required(ErrorMessage = "El modelo NO es opcional!")]
        public string modelo { get; set; }

        [DisplayName("Año de Compra")]
        [Range(2020, 2099, ErrorMessage = "Los valores aceptados son entre 2020 y 2099!")]
        public int? anio_compra { get; set; }

        [DisplayName("Costo")]
        public decimal costo { get; set; }

        [DisplayName("Vida Útil (en años)")]
        public int? vida_util { get; set; }

        [DisplayName("Estado del Equipo ID")]
        public int? estado_equipo_id { get; set; }

        [DisplayName("Estado")]
        [StringLength(1, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        public string estado { get; set; }
    }
}
