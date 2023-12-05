using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApiTienda.Models;

namespace WebApiTienda.Dtos_Models
{
	public class descripcionMangaDto
	{
		public descripcionMangaDto(string name,int tomoNro,double price,string summary,int numberPages, editorialesDto edit, mangaInfoDto mangaInfo) 
		{ 
		
			this.name = name;
			this.tomoNro = tomoNro;
			this.price = price;
			this.summary = summary;
			this.numberPages = numberPages;
			this.editorial = edit;
			this.mangaInfo = mangaInfo;
		}
		public string name { get; set; }
		
		public int tomoNro { get; set; }
		
		public double price { get; set; }

		public string summary { get; set; }

		public int numberPages { get; set; }

		public editorialesDto editorial { get; set; }

		public mangaInfoDto mangaInfo { get; set; }

	}

}

