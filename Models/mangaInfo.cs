using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace WebApiTienda.Models
{
	public class mangaInfo
	{
		public mangaInfo() { }

		public mangaInfo(string name, string autor,string demografia,int cantidadTomos,List<descriptionManga> mangas,int idEditorial,editorial edit) 
		{ 
		this.name= name;
			this.autor= autor;
			this.demografia= demografia;
			this.cantidadTomo= cantidadTomos;
			this.mangas = mangas;
			this.idEditorial = idEditorial;
			this.editorial = edit;
		}


		[Key]
		[Column("id")]
		public int idMangaInfo { get; set; }
		public string name { get; set; }
		public string autor { get; set; }
		public string demografia { get; set; }

		public int cantidadTomo { get; set; }

		public List <descriptionManga> mangas { get; set; }

		[ForeignKey("editorial")]
		public int idEditorial { get; set; }

		public editorial editorial {get; set;}
	
	}
}
