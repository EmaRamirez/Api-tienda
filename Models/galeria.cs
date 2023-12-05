using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTienda.Models
{
	public class galeria
	{
        [Key]
        [Column("id")]
		public int idGalery { get; set; }

        public string name { get; set; }

        public string extension { get; set; }

        public double size { get; set; }

        public string url { get; set; }

        
    }
}
