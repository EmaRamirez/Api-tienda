using WebApiTienda.Models;

namespace WebApiTienda.Dtos_Models
{
	public class galeriaDto
	{
		public galeriaDto(string name, byte[] datos, string extension) 
		{
			this.name = name;
			this.archivo = datos;
			this.extension = extension;
		}
		
		public string name { get; set; }
		public byte[] archivo { get; set; }

		public string extension { get; set; }
	}


	


}
