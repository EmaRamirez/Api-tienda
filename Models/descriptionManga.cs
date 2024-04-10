using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApiTienda.Models
{
	public class descriptionManga
	{
		public descriptionManga() 
		{

		}

		public descriptionManga(string name, int tomoNro,double price,string summary, int numberPages,int idEditorial, int infoManga,int idImage)
		{
			this.name = name;
			this.tomoNro = tomoNro;
			this.price = price;
			this.summary = summary;
			this.numberPages = numberPages;
			this.idEditorial = idEditorial;
			
			this.idMangaInfo = infoManga;
			
			this.idGalery = idImage;
			
		}

		[Key]
		[Column("id")]
        public int idDescripcion { get; set; }
		[Required]
		public string name { get; set; }
		[Required]
		public int tomoNro { get; set; }
		[Required]
		public double price { get; set; }
	
		public string summary { get; set; }
		
		public int numberPages { get; set; }

		[ForeignKey("editorial")]
		[Required]
		public int idEditorial { get;set; }

		//public editorial editorial { get; set; }

		[ForeignKey("mangaInfo")]
		[Required]
		public int idMangaInfo { get; set; }

		
		//public mangaInfo mangaInfo { get; set; }
		
		[ForeignKey("galeria")]
		[Required]
		public int idGalery { get; set; }

		//public galeria galeria { get; set; }


	}
}
