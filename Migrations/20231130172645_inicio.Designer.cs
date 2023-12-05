﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiTienda.Models;

namespace WebApiTienda.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231130172645_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiTienda.Models.descriptionManga", b =>
                {
                    b.Property<int>("idDescripcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idEditorial")
                        .HasColumnType("int");

                    b.Property<int>("idMangaInfo")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberPages")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tomoNro")
                        .HasColumnType("int");

                    b.HasKey("idDescripcion");

                    b.HasIndex("idEditorial");

                    b.HasIndex("idMangaInfo");

                    b.ToTable("descriptionMangas");
                });

            modelBuilder.Entity("WebApiTienda.Models.editorial", b =>
                {
                    b.Property<int>("idEditorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEditorial");

                    b.ToTable("editoriales");
                });

            modelBuilder.Entity("WebApiTienda.Models.mangaInfo", b =>
                {
                    b.Property<int>("idMangaInfo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantidadTomo")
                        .HasColumnType("int");

                    b.Property<string>("demografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMangaInfo");

                    b.ToTable("mangaInfo");
                });

            modelBuilder.Entity("WebApiTienda.Models.descriptionManga", b =>
                {
                    b.HasOne("WebApiTienda.Models.editorial", "editorial")
                        .WithMany("mangas")
                        .HasForeignKey("idEditorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiTienda.Models.mangaInfo", "mangaInfo")
                        .WithMany()
                        .HasForeignKey("idMangaInfo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
