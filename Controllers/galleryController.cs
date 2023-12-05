using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

		public ActionResult<galeria> Get()
		{
			try
			{
				return Ok(_context.galeria.ToList());
			}catch(Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost]

		public ActionResult PostImages([FromForm]List<IFormFile>files)
		{
			List<galeria> images = new List<galeria>();

			if (files.Count>0)
			{
				foreach (var file in files)
				{
					var filePath = "D:\\emanu\\Manu\\Portfolio\\Api Tienda\\WebApiTienda\\Imagenes\\"+file.FileName;
					using (var stream = System.IO.File.Create(filePath))//creamos y guardamos en la carpeta
					{
						file.CopyToAsync(stream);
					}
					double tamanio = file.Length;
					tamanio = Math.Round((tamanio / 1000000), 2);
					galeria galeria = new galeria();
					galeria.extension = Path.GetExtension(file.FileName).Substring(1);
					galeria.name = Path.GetFileNameWithoutExtension(file.FileName);
					galeria.size = tamanio;
					galeria.url = filePath;

					images.Add(galeria);

				}

				_context.galeria.AddRange(images);
				_context.SaveChanges();

				return Ok(images);
			}

			return BadRequest();


		}


	}
}
