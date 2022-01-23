﻿// <auto-generated />
using System;
using BookStore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20220121211847_InitialCreation")]
    partial class InitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("AutorLivro", b =>
                {
                    b.Property<int>("AutoresId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LivrosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AutoresId", "LivrosId");

                    b.HasIndex("LivrosId");

                    b.ToTable("AutorLivro");
                });

            modelBuilder.Entity("BookStoreDomain.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AutoresBookStore");
                });

            modelBuilder.Entity("BookStoreDomain.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CategoriasBookStore");
                });

            modelBuilder.Entity("BookStoreDomain.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("LivrosBookStore");
                });

            modelBuilder.Entity("AutorLivro", b =>
                {
                    b.HasOne("BookStoreDomain.Autor", null)
                        .WithMany()
                        .HasForeignKey("AutoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreDomain.Livro", null)
                        .WithMany()
                        .HasForeignKey("LivrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStoreDomain.Livro", b =>
                {
                    b.HasOne("BookStoreDomain.Categoria", "categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("BookStoreDomain.Categoria", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}