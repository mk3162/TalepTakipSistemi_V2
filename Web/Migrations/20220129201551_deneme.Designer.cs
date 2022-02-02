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
    [Migration("20220129201551_deneme")]
    partial class deneme
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
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("SiraNo");

                    b.ToTable("Birimler");
                });

            modelBuilder.Entity("Web.Entities.Departman", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SirketSiraNo")
                        .HasColumnType("int");

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.HasKey("SiraNo");

                    b.HasIndex("SirketSiraNo");

                    b.ToTable("Departmanlar");
                });

            modelBuilder.Entity("Web.Entities.IslemTip", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("SiraNo");

                    b.ToTable("IslemTipleri");
                });

            modelBuilder.Entity("Web.Entities.Kullanici", b =>
                {
                    b.Property<string>("Kodu")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("AdiSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("Yetki")
                        .HasColumnType("int");

                    b.HasKey("Kodu");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("Web.Entities.Lokasyon", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SirketSiraNo")
                        .HasColumnType("int");

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.HasKey("SiraNo");

                    b.HasIndex("SirketSiraNo");

                    b.ToTable("Lokasyonlar");
                });

            modelBuilder.Entity("Web.Entities.Personel", b =>
                {
                    b.Property<string>("Kodu")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("AdiSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.Property<int>("Oncelik")
                        .HasColumnType("int");

                    b.Property<int>("Pasif")
                        .HasColumnType("int");

                    b.Property<int>("ServisSiraNo")
                        .HasColumnType("int");

                    b.Property<string>("Unvani")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.HasKey("Kodu");

                    b.HasIndex("ServisSiraNo");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Web.Entities.Proje", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SirketSiraNo")
                        .HasColumnType("int");

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiraNo");

                    b.HasIndex("SirketSiraNo");

                    b.ToTable("Proje");
                });

            modelBuilder.Entity("Web.Entities.Servis", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmanSiraNo")
                        .HasColumnType("int");

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.HasKey("SiraNo");

                    b.HasIndex("DepartmanSiraNo");

                    b.ToTable("Servisler");
                });

            modelBuilder.Entity("Web.Entities.Sirket", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasMaxLength(48);

                    b.HasKey("SiraNo");

                    b.ToTable("Sirketler");
                });

            modelBuilder.Entity("Web.Entities.SurecTip", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("SiraNo");

                    b.ToTable("SurecTipler");
                });

            modelBuilder.Entity("Web.Entities.Tedarikci", b =>
                {
                    b.Property<string>("TedarikciKodu")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("TedarikciUnvani")
                        .IsRequired()
                        .HasColumnType("nvarchar(127)")
                        .HasMaxLength(127);

                    b.HasKey("TedarikciKodu");

                    b.ToTable("Tedarikciler");
                });

            modelBuilder.Entity("Web.Entities.Tip", b =>
                {
                    b.Property<int>("SiraNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("SiraNo");

                    b.ToTable("Tipler");
                });

            modelBuilder.Entity("Web.Entities.Urun", b =>
                {
                    b.Property<string>("UrunKodu")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("UrunTanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(127)")
                        .HasMaxLength(127);

                    b.HasKey("UrunKodu");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Web.Entities.Departman", b =>
                {
                    b.HasOne("Web.Entities.Sirket", "Sirket")
                        .WithMany("Departmanlar")
                        .HasForeignKey("SirketSiraNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Web.Entities.Lokasyon", b =>
                {
                    b.HasOne("Web.Entities.Sirket", "Sirket")
                        .WithMany("Lokasyonlar")
                        .HasForeignKey("SirketSiraNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Web.Entities.Personel", b =>
                {
                    b.HasOne("Web.Entities.Servis", "Servis")
                        .WithMany("Personeller")
                        .HasForeignKey("ServisSiraNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Web.Entities.Proje", b =>
                {
                    b.HasOne("Web.Entities.Sirket", "Sirket")
                        .WithMany("Projeler")
                        .HasForeignKey("SirketSiraNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Web.Entities.Servis", b =>
                {
                    b.HasOne("Web.Entities.Departman", "Departman")
                        .WithMany("Servisler")
                        .HasForeignKey("DepartmanSiraNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}