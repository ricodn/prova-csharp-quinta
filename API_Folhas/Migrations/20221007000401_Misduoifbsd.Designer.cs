﻿// <auto-generated />
using System;
using API_Folhas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_FOlhas.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221007000401_Misduoifbsd")]
    partial class Misduoifbsd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API_Folhas.Models.FolhaPagamento", b =>
                {
                    b.Property<int>("FolhaPagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Fgts")
                        .HasColumnType("REAL");

                    b.Property<double>("ImpostoRenda")
                        .HasColumnType("REAL");

                    b.Property<double>("Inss")
                        .HasColumnType("REAL");

                    b.Property<int>("QuantidadeHoras")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SalarioBruto")
                        .HasColumnType("REAL");

                    b.Property<double>("SalarioLiquido")
                        .HasColumnType("REAL");

                    b.Property<int>("ValorHora")
                        .HasColumnType("INTEGER");

                    b.HasKey("FolhaPagamentoId");

                    b.ToTable("Folhas");
                });

            modelBuilder.Entity("API_Folhas.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Salario")
                        .HasColumnType("INTEGER");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
