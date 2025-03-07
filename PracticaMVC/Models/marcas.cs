using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
	public class marcas
	{
		[Key]
		[DisplayName("ID de Marca")]
		public int id_marcas { get; set; }

		[DisplayName("Nombre de la marca")]
		[Required(ErrorMessage = "El nombre de la marca NO es opcional!")]
		public string nombre_marca { get; set; }

		[DisplayName("Estado")]
		[StringLength(1, ErrorMessage = "La cantidad maxima de caracteres valida es {1}")]
		public string? estados { get; set; }
	}
}
