﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Universidad.Models;

namespace Universidad.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180701222752_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Universidad.Models.Alumno", b =>
                {
                    b.Property<int>("AlumnoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<DateTime>("FecNacimiento");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("AlumnoID");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("Universidad.Models.Carrera", b =>
                {
                    b.Property<int>("CarreraID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("CarreraID");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("Universidad.Models.Catedra", b =>
                {
                    b.Property<int>("CatedraID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fin");

                    b.Property<short>("Horario");

                    b.Property<DateTime>("Inicio");

                    b.Property<int?>("MateriaID");

                    b.Property<int?>("ProfesorID");

                    b.HasKey("CatedraID");

                    b.HasIndex("MateriaID");

                    b.HasIndex("ProfesorID");

                    b.ToTable("Catedras");
                });

            modelBuilder.Entity("Universidad.Models.CursadaAlumno", b =>
                {
                    b.Property<int>("AlumnoID");

                    b.Property<int>("CatedraID");

                    b.Property<short>("Nota1erParcial");

                    b.Property<short>("Nota2doParcial");

                    b.Property<short>("NotaFinal");

                    b.HasKey("AlumnoID", "CatedraID");

                    b.HasIndex("CatedraID");

                    b.ToTable("CursadaAlumnos");
                });

            modelBuilder.Entity("Universidad.Models.Materia", b =>
                {
                    b.Property<int>("MateriaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Anio");

                    b.Property<int?>("CarreraID");

                    b.Property<string>("Cuatrimestre");

                    b.Property<string>("Nombre");

                    b.HasKey("MateriaID");

                    b.HasIndex("CarreraID");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Universidad.Models.Profesor", b =>
                {
                    b.Property<int>("ProfesorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<DateTime>("FecNacimiento");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("ProfesorID");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Universidad.Models.Catedra", b =>
                {
                    b.HasOne("Universidad.Models.Materia", "Materia")
                        .WithMany("Catedras")
                        .HasForeignKey("MateriaID");

                    b.HasOne("Universidad.Models.Profesor", "Profesor")
                        .WithMany("Catedras")
                        .HasForeignKey("ProfesorID");
                });

            modelBuilder.Entity("Universidad.Models.CursadaAlumno", b =>
                {
                    b.HasOne("Universidad.Models.Alumno")
                        .WithMany("Cursadas")
                        .HasForeignKey("AlumnoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Universidad.Models.Catedra")
                        .WithMany("Cursadas")
                        .HasForeignKey("CatedraID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Universidad.Models.Materia", b =>
                {
                    b.HasOne("Universidad.Models.Carrera", "Carrera")
                        .WithMany("Materias")
                        .HasForeignKey("CarreraID");
                });
#pragma warning restore 612, 618
        }
    }
}
