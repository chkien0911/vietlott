﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Vietlott.Api.DataAccess.Context;

namespace Vietlott.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vietlott.Api.DataAccess.Entities.DrawGame", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("DrawGames");
                });

            modelBuilder.Entity("Vietlott.Api.DataAccess.Entities.DrawResult", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DrawDate");

                    b.Property<int>("DrawNo");

                    b.Property<string>("DrawTypeId");

                    b.Property<decimal>("PrizeAmount");

                    b.Property<int>("TotalWinningTickets");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("DrawTypeId");

                    b.ToTable("DrawResults");
                });

            modelBuilder.Entity("Vietlott.Api.DataAccess.Entities.DrawType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("DrawGameId");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("DrawGameId");

                    b.ToTable("DrawTypes");
                });

            modelBuilder.Entity("Vietlott.Api.DataAccess.Entities.WinningNumber", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DrawResultId");

                    b.Property<int>("Number");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("DrawResultId");

                    b.ToTable("WinningNumber");
                });

            modelBuilder.Entity("Vietlott.Api.DataAccess.Entities.DrawResult", b =>
                {
                    b.HasOne("Vietlott.Api.DataAccess.Entities.DrawType", "DrawType")
                        .WithMany("DrawResults")
                        .HasForeignKey("DrawTypeId");
                });

            modelBuilder.Entity("Vietlott.Api.DataAccess.Entities.DrawType", b =>
                {
                    b.HasOne("Vietlott.Api.DataAccess.Entities.DrawGame", "DrawGame")
                        .WithMany("DrawTypes")
                        .HasForeignKey("DrawGameId");
                });

            modelBuilder.Entity("Vietlott.Api.DataAccess.Entities.WinningNumber", b =>
                {
                    b.HasOne("Vietlott.Api.DataAccess.Entities.DrawResult")
                        .WithMany("WinningNumbers")
                        .HasForeignKey("DrawResultId");
                });
#pragma warning restore 612, 618
        }
    }
}
