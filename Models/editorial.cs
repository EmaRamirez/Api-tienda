using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTienda.Models
{
	public class editorial
	{
		public editorial() { }
		public editorial(string name,List<descriptionManga> mangas,List<mangaInfo> infomanga) 
		{ 
			this.name = name;
			this.mangas = mangas;
			this.infoManga = infomanga;
		}

		[Key]
		[Column("id")]
		public int idEditorial { get; set; }
        public string name { get; set; }
		[NotMapped]
		public List<mangaInfo>infoManga { get; set; }
		[NotMapped]
		public List <descriptionManga> mangas { get; set; }
    }


}
