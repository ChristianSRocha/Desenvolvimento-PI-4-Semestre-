﻿// <auto-generated />
using System;
using BookAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookAPI.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20250407161924_CartaoCredito")]
    partial class CartaoCredito
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookAPI.Entities.CEPs.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CodigoCep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("BookAPI.Entities.Clientes.CartaoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bandeira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Cvv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeImpresso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCartao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("CartoesClientes");
                });

            modelBuilder.Entity("BookAPI.Entities.Clientes.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("DDD")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmado")
                        .HasColumnType("bit");

                    b.Property<int>("Genero")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenConfirmacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BookAPI.Entities.Clientes.EnderecoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("EnderecosClientes");
                });

            modelBuilder.Entity("BookAPI.Entities.ClientesLivros.ClienteLivro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LivroId");

                    b.ToTable("ClientesLivros");
                });

            modelBuilder.Entity("BookAPI.Entities.Historicos.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoOperacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Historicos");
                });

            modelBuilder.Entity("BookAPI.Entities.Historicos.ItemHistorico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Custo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("HistoricoId")
                        .HasColumnType("int");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HistoricoId");

                    b.HasIndex("LivroId");

                    b.ToTable("ItensHistoricos");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.FotoLivro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.ToTable("FotosLivros");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Custo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QtdPaginas")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("BookAPI.Entities.Clientes.CartaoCliente", b =>
                {
                    b.HasOne("BookAPI.Entities.Clientes.Cliente", "Cliente")
                        .WithMany("CartaoClientes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BookAPI.Entities.Clientes.EnderecoCliente", b =>
                {
                    b.HasOne("BookAPI.Entities.Clientes.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookAPI.Entities.CEPs.Endereco", "Endereco")
                        .WithMany("EnderecosCliente")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("BookAPI.Entities.ClientesLivros.ClienteLivro", b =>
                {
                    b.HasOne("BookAPI.Entities.Clientes.Cliente", "Cliente")
                        .WithMany("ClientesLivros")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookAPI.Entities.Livros.Livro", "Livro")
                        .WithMany("CLientesLivros")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("BookAPI.Entities.Historicos.Historico", b =>
                {
                    b.HasOne("BookAPI.Entities.Clientes.Cliente", "Cliente")
                        .WithMany("Historicos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BookAPI.Entities.Historicos.ItemHistorico", b =>
                {
                    b.HasOne("BookAPI.Entities.Historicos.Historico", "Historico")
                        .WithMany("ItensHistorico")
                        .HasForeignKey("HistoricoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookAPI.Entities.Livros.Livro", "Livro")
                        .WithMany("ItensHistorico")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Historico");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.FotoLivro", b =>
                {
                    b.HasOne("BookAPI.Entities.Livros.Livro", "Livro")
                        .WithMany("FotosLivros")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.Livro", b =>
                {
                    b.HasOne("BookAPI.Entities.Livros.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookAPI.Entities.Livros.Categoria", "Categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookAPI.Entities.Clientes.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Autor");

                    b.Navigation("Categoria");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BookAPI.Entities.CEPs.Endereco", b =>
                {
                    b.Navigation("EnderecosCliente");
                });

            modelBuilder.Entity("BookAPI.Entities.Clientes.Cliente", b =>
                {
                    b.Navigation("CartaoClientes");

                    b.Navigation("ClientesLivros");

                    b.Navigation("Enderecos");

                    b.Navigation("Historicos");
                });

            modelBuilder.Entity("BookAPI.Entities.Historicos.Historico", b =>
                {
                    b.Navigation("ItensHistorico");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.Categoria", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("BookAPI.Entities.Livros.Livro", b =>
                {
                    b.Navigation("CLientesLivros");

                    b.Navigation("FotosLivros");

                    b.Navigation("ItensHistorico");
                });
#pragma warning restore 612, 618
        }
    }
}
