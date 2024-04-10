using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using WebApiTienda.Models;

namespace WebApiTienda.Cosas_importantes
{
	/*public IActionResult filePost([FromForm] galeria files)
	{
		string ruta = "D:\\emanu\\Manu\\Portfolio\\Api Tienda\\WebApiTienda\\Imagenes\\";

		string ubicacion = Path.Combine(ruta, files.archivo.FileName);

		var archivo = new galeria();

		try
		{
			//con esto indicamos que se crea el archivo con la ruta especificada
			using (FileStream newFile = System.IO.File.Create(ubicacion))
			{
				files.archivo.CopyTo(newFile);
				newFile.Flush();
			}

			archivo.name = Path.GetFileNameWithoutExtension(files.archivo.FileName);
			archivo.url = ubicacion;

			_context.galeria.Add(archivo);
			_context.SaveChanges();


			return Ok(viewGallery(archivo));

		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	*/
	}
