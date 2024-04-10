using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace WebApiTienda.Models
{
	public class galeria
	{

        public galeria() { }    
        public galeria(string name, byte[] archivo ,string extension)
        {
            this.name = name;
            this.archivo = archivo;
            this.extension= extension;
            
        }


        [Key]
        [Column("id")]
		public int idGalery { get; set; }

        public string name { get; set; }

        public byte[] archivo { get; set; }

        
        public string extension { get; set; }

        [NotMapped]
        public IFormFile imagen { get; set; }

        
    }

}
