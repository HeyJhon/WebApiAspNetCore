using System.ComponentModel.DataAnnotations;
namespace SistemaVue.Entidades.Almacen
{
public    class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre solo puede tener 50 caracteres como maximo")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
