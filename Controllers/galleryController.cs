using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTienda.Dtos_Models;
using WebApiTienda.Models;

namespace WebApiTienda.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class galleryController : ControllerBase
	{
		private readonly Context _context;

		public galleryController(Context _context)
		{
			this._context = _context;
		}


		[HttpGet]

		public ActionResult<galeriaDto> Get()
		{
			try
			{
				return Ok(viewAll());
			}catch(Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost]
		public ActionResult AddPost([FromForm] galeria imagen)
		{

			var extension = Path.GetExtension(imagen.imagen.FileName);
			MemoryStream ms = new MemoryStream();

			imagen.imagen.CopyToAsync(ms);

			byte[] data = ms.ToArray();

			string name = Path.GetFileNameWithoutExtension(imagen.imagen.FileName);

			var agregar = new galeria(name, data, extension);


			_context.galeria.Add(agregar);
			_context.SaveChanges();
			return Ok();
		}


		/*private  galeriaDto viewGallery(galeria value)
		{
			var galeria = new galeriaDto(value.url);
			return galeria;*/



		private List<galeriaDto> viewAll()
		{
			var images = new List<galeriaDto>() { };
			var datos = _context.galeria.ToList();

			foreach (var item in datos)
			{
				images.Add(new galeriaDto(item.name, item.archivo, item.extension));
			}
			return images.ToList();
		}

	}
}
		


	




 