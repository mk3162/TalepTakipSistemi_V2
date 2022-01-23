﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Context;

namespace Web.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220123194540_v4")]
    partial class v4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Entities.Birim", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiraNo");

                    b.ToTable("Birimler");
                });

            modelBuilder.Entity("Web.Entities.IslemTip", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiraNo");

                    b.ToTable("IslemTipleri");
                });

            modelBuilder.Entity("Web.Entities.Sirket", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.HasKey("SiraNo");

                    b.ToTable("Sirketler");
                });

            modelBuilder.Entity("Web.Entities.Tedarikci", b =>
                {
                    b.Property<int>("TedarikciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TedarikciKodu")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("TedarikciUnvani")
                        .HasColumnType("nvarchar(127)")
                        .HasMaxLength(127);

                    b.HasKey("TedarikciId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Web.Entities.Tip", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.HasKey("SiraNo");

                    b.ToTable("Tipler");
                });

            modelBuilder.Entity("Web.Entities.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UrunKodu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunTanimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Web.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdiSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.Property<string>("Kodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("Yetki")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
