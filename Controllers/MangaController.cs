using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTienda.Dtos_Models;
using WebApiTienda.Models;

namespace WebApiTienda.Controllers
{
	[Route("api/[Controller]")]
	[ApiController]
	public class MangaController : ControllerBase
	{
		private readonly Context _context;
		

		public MangaController(Context context)
		{ this._context = context; 
		
		}

		[HttpGet]
		public ActionResult<IEnumerable<descripcionMangaDto>> Get()
		{
			try
			{
				return ShowAll();
			
			}catch(Exception ex)
			{
				return BadRequest(ex.Message);
			}
		
		}

		[HttpGet("{id}", Name = "obtenerInfo")]
		public ActionResult<descripcionMangaDto> Get(int id)
		{
			try
			{
				var info = ShowById(id);
				return info;
			}
			catch (Exception ex)
			{
				return NotFound(ex.Message);
			}
			
		}
		
		[HttpPost]

		public async Task<ActionResult> Post([FromBody] descriptionMangaPost info)
		{

			var add = AddInfo(info);

			try 
			{ 
				_context.descriptionMangas.Add(add);

				await _context.SaveChangesAsync();

				
			}catch(Exception ex)
			{
				NotFound(ex.Message);
			}
			return new CreatedAtRouteResult("obtenerInfo", ShowById(add.idDescripcion));
		}



		private List<descripcionMangaDto> ShowAll()
		{
			
			
			var listado = new List<descripcionMangaDto>();
			foreach (var item in _context.descriptionMangas.Include(x=> x.editorial).Include(x=>x.mangaInfo))
			{
				
				var editorial = new editorialesDto(item.editorial.name);
				var infoManga = new mangaInfoDto(item.mangaInfo.autor, item.mangaInfo.demografia, item.mangaInfo.cantidadTomo);
				var dato = new descripcionMangaDto(item.name,item.tomoNro,item.price,item.summary,item.numberPages,editorial, infoManga);
				listado.Add(dato);
			}
			return listado;

			

        }

		private descripcionMangaDto ShowById(int id)
		{
			var manga = _context.descriptionMangas.Include(x => x.editorial).Include(x => x.mangaInfo).FirstOrDefault(x => x.idDescripcion == id);

			var editorial = new editorialesDto(manga.editorial.name);
			var infoManga = new mangaInfoDto(manga.mangaInfo.autor, manga.mangaInfo.demografia, manga.mangaInfo.cantidadTomo);
			descripcionMangaDto mangafiltrada = new descripcionMangaDto(manga.name, manga.tomoNro, manga.price, manga.summary, manga.numberPages, editorial, infoManga);

			return mangafiltrada;


		}

		private descriptionManga AddInfo(descriptionMangaPost info)
		{
			//aca tengo el editorial entero
			var datosEditorial = _context.editoriales.Include(x => x.mangas).Include(x => x.infoManga).FirstOrDefault(x => x.idEditorial == info.idEditorial);

			var editorial = new editorial(datosEditorial.name,datosEditorial.mangas,datosEditorial.infoManga);
			/*
			idEditorial
			name
			listado de mangas
			listado de mangaka
			 */
			//aca tengo el infomanga entero
			var datosInfoManga = _context.mangaInfo.Include(x => x.mangas).Include(x => x.editorial).FirstOrDefault(x=> x.idMangaInfo == info.idMangaInfo);

			var infomanga = new mangaInfo(datosInfoManga.name, datosInfoManga.autor, datosInfoManga.demografia, datosInfoManga.cantidadTomo, datosInfoManga.mangas, datosInfoManga.idEditorial, datosInfoManga.editorial);
			/*
			idMangaInfo
			name
			autor
			demografia
			cantTomos
			listado de mangas
			idEditorial
			editorial
			 */

			var manga = new descriptionManga(info.name,info.tomoNro, info.price,info.summary, info.numberPages,datosEditorial.idEditorial,editorial,datosInfoManga.idMangaInfo,datosInfoManga);
			/*
			name
			tomoNro
			price
			summary
			numberPages
			idEditorial
			editorial
			idMangaInfo
			MangaInfo
			 */



			return manga;




		}
	}
		
	}

