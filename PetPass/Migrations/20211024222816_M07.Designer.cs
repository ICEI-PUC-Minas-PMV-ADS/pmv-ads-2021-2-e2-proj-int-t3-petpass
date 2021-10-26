﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetPass.Models;

namespace PetPass.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211024222816_M07")]
    partial class M07
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetPass.Models.Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascPet")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRegPet")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoPet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("IdadePet")
                        .HasColumnType("decimal(18,1)");

                    b.Property<string>("NomePet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PesoPet")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RacaPet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SexoPet")
                        .HasColumnType("int");

                    b.Property<string>("TipoPet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPet");

                    b.ToTable("MeusPets");
                });

            modelBuilder.Entity("PetPass.Models.Vacina", b =>
                {
                    b.Property<int>("IdVac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Animal")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Aplicacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Descricao")
                        .HasColumnType("int");

                    b.Property<int>("Dose_Aplicada")
                        .HasColumnType("int");

                    b.Property<int>("Idade_Aplicacao")
                        .HasColumnType("int");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("IdVac");

                    b.HasIndex("PetId");

                    b.ToTable("MinhasVacinas");
                });

            modelBuilder.Entity("PetPass.Models.Vacina", b =>
                {
                    b.HasOne("PetPass.Models.Pet", "Pet")
                        .WithMany("Vacinas")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("PetPass.Models.Pet", b =>
                {
                    b.Navigation("Vacinas");
                });
#pragma warning restore 612, 618
        }
    }
}
