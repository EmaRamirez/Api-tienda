using Castle.Core.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;


namespace WebApiTienda.Models
{

	public class Context :DbContext
	{
		public Context( DbContextOptions<Context>options):base(options) 
		{

		}
		//public DbSet<login> logins { get; set; }
		public DbSet<mangaInfo> mangaInfo { get; set; }
		public DbSet<descriptionManga> descriptionMangas { get; set; }
		public DbSet<editorial>editoriales { get; set; }
		public DbSet<galeria>galeria { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}


	}

}

