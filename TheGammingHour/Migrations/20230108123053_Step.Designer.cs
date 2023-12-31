﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UTAD.LAB._2022.TheGammingHour.Data;

#nullable disable

namespace UTAD.LAB._2022.TheGammingHour.Migrations
{
    [DbContext(typeof(TheGammingHourDatabase))]
    [Migration("20230108123053_Step")]
    partial class Step
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Categoria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.CategoriaFavoritum", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoriaId")
                        .HasColumnType("bigint")
                        .HasColumnName("CategoriaID");

                    b.Property<long>("UtilizadorId")
                        .HasColumnType("bigint")
                        .HasColumnName("UtilizadorID");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("UtilizadorId");

                    b.ToTable("CategoriaFavorita");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.CategoriaJogo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoriaId")
                        .HasColumnType("bigint")
                        .HasColumnName("CategoriaID");

                    b.Property<long>("JogoId")
                        .HasColumnType("bigint")
                        .HasColumnName("JogoID");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("JogoId");

                    b.ToTable("Categoria_Jogo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.CompraJogo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("date");

                    b.Property<long>("JogoId")
                        .HasColumnType("bigint")
                        .HasColumnName("JogoID");

                    b.Property<long>("PagamentoId")
                        .HasColumnType("bigint")
                        .HasColumnName("PagamentoID");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<long>("UtilizadorId")
                        .HasColumnType("bigint")
                        .HasColumnName("UtilizadorID");

                    b.HasKey("Id");

                    b.HasIndex("JogoId");

                    b.HasIndex("PagamentoId");

                    b.HasIndex("UtilizadorId");

                    b.ToTable("CompraJogo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Grupo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.GrupoMenu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("GrupoId")
                        .HasColumnType("bigint")
                        .HasColumnName("GrupoID");

                    b.Property<long>("MenuId")
                        .HasColumnType("bigint")
                        .HasColumnName("MenuID");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("MenuId");

                    b.ToTable("Grupo_Menu");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Jogo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<double>("Avaliacao")
                        .HasColumnType("float");

                    b.Property<DateTime>("Data")
                        .HasColumnType("date");

                    b.Property<bool>("Desconto")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<int>("Pegi")
                        .HasColumnType("int");

                    b.Property<double?>("PercentagemDesconto")
                        .HasColumnType("float")
                        .HasColumnName("Percentagem_Desconto");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<bool>("Create")
                        .HasColumnType("bit");

                    b.Property<bool>("Edit")
                        .HasColumnType("bit");

                    b.Property<long>("Key")
                        .HasColumnType("bigint");

                    b.Property<string>("Tooltip")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<bool>("Update")
                        .HasColumnType("bit");

                    b.Property<bool>("View")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Pagamento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)");

                    b.Property<int?>("Entidade")
                        .HasColumnType("int");

                    b.Property<bool?>("Guarda")
                        .HasColumnType("bit");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nif")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("NIF");

                    b.Property<bool?>("PayPal")
                        .HasColumnType("bit");

                    b.Property<int?>("Referencia")
                        .HasColumnType("int");

                    b.Property<int?>("Telemovel")
                        .HasColumnType("int");

                    b.Property<long>("UtilizadorId")
                        .HasColumnType("bigint")
                        .HasColumnName("UtilizadorID");

                    b.HasKey("Id");

                    b.HasIndex("UtilizadorId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Plataforma", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Plataforma");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.PlataformaJogo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("JogoId")
                        .HasColumnType("bigint")
                        .HasColumnName("JogoID");

                    b.Property<long>("PlataformaId")
                        .HasColumnType("bigint")
                        .HasColumnName("PlataformaID");

                    b.HasKey("Id");

                    b.HasIndex("JogoId");

                    b.HasIndex("PlataformaId");

                    b.ToTable("Plataforma_Jogo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Produtora", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Produtora");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.ProdutoraJogo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("JogoId")
                        .HasColumnType("bigint")
                        .HasColumnName("JogoID");

                    b.Property<long>("ProdutoraId")
                        .HasColumnType("bigint")
                        .HasColumnName("ProdutoraID");

                    b.HasKey("Id");

                    b.HasIndex("JogoId");

                    b.HasIndex("ProdutoraId");

                    b.ToTable("Produtora_Jogo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Utilizador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<long>("GrupoId")
                        .HasColumnType("bigint")
                        .HasColumnName("GrupoID");

                    b.Property<bool>("Newsletter")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<bool>("Verificado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("Utilizador");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.UtilizadorGrupo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("GrupoId")
                        .HasColumnType("bigint")
                        .HasColumnName("GrupoID");

                    b.Property<long>("UtilizadorId")
                        .HasColumnType("bigint")
                        .HasColumnName("UtilizadorID");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("UtilizadorId");

                    b.ToTable("Utilizador_Grupo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.CategoriaFavoritum", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Categoria", "Categoria")
                        .WithMany("CategoriaFavorita")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Utilizador", "Utilizador")
                        .WithMany("CategoriaFavorita")
                        .HasForeignKey("UtilizadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.CategoriaJogo", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Categoria", "Categoria")
                        .WithMany("CategoriaJogos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Jogo", "Jogo")
                        .WithMany("CategoriaJogos")
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Jogo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.CompraJogo", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Jogo", "Jogo")
                        .WithMany("CompraJogos")
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Pagamento", "Pagamento")
                        .WithMany("CompraJogos")
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Utilizador", "Utilizador")
                        .WithMany("CompraJogos")
                        .HasForeignKey("UtilizadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");

                    b.Navigation("Pagamento");

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.GrupoMenu", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Grupo", "Grupo")
                        .WithMany("GrupoMenus")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Menu", "Menu")
                        .WithMany("GrupoMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Pagamento", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Utilizador", "Utilizador")
                        .WithMany("Pagamentos")
                        .HasForeignKey("UtilizadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.PlataformaJogo", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Jogo", "Jogo")
                        .WithMany("PlataformaJogos")
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Plataforma", "Plataforma")
                        .WithMany("PlataformaJogos")
                        .HasForeignKey("PlataformaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");

                    b.Navigation("Plataforma");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.ProdutoraJogo", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Jogo", "Jogo")
                        .WithMany("ProdutoraJogos")
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Produtora", "Produtora")
                        .WithMany("ProdutoraJogos")
                        .HasForeignKey("ProdutoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");

                    b.Navigation("Produtora");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Utilizador", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Grupo", "Grupo")
                        .WithMany("Utilizadors")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.UtilizadorGrupo", b =>
                {
                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Grupo", "Grupo")
                        .WithMany("UtilizadorGrupos")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTAD.LAB._2022.TheGammingHour.Models.Utilizador", "Utilizador")
                        .WithMany("UtilizadorGrupos")
                        .HasForeignKey("UtilizadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Categoria", b =>
                {
                    b.Navigation("CategoriaFavorita");

                    b.Navigation("CategoriaJogos");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Grupo", b =>
                {
                    b.Navigation("GrupoMenus");

                    b.Navigation("UtilizadorGrupos");

                    b.Navigation("Utilizadors");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Jogo", b =>
                {
                    b.Navigation("CategoriaJogos");

                    b.Navigation("CompraJogos");

                    b.Navigation("PlataformaJogos");

                    b.Navigation("ProdutoraJogos");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Menu", b =>
                {
                    b.Navigation("GrupoMenus");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Pagamento", b =>
                {
                    b.Navigation("CompraJogos");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Plataforma", b =>
                {
                    b.Navigation("PlataformaJogos");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Produtora", b =>
                {
                    b.Navigation("ProdutoraJogos");
                });

            modelBuilder.Entity("UTAD.LAB._2022.TheGammingHour.Models.Utilizador", b =>
                {
                    b.Navigation("CategoriaFavorita");

                    b.Navigation("CompraJogos");

                    b.Navigation("Pagamentos");

                    b.Navigation("UtilizadorGrupos");
                });
#pragma warning restore 612, 618
        }
    }
}
