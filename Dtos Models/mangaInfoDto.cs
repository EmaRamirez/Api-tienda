using WebApiTienda.Models;

namespace WebApiTienda.Dtos_Models
{
	public class mangaInfoDto
	{
		public mangaInfoDto(string autor,string demografia,int cantidadTomo)
		{
			
			this.autor = autor;
			this.demografia = demografia;
			this.cantidadTomo = cantidadTomo;
			
		}
		public string autor { get; set; }
		public string demografia { get; set; }

		public int cantidadTomo { get; set; }
		
	}
}
