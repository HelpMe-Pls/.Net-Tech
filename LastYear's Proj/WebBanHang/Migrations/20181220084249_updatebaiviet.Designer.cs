﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBanHang.Models;

namespace WebBanHang.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20181220084249_updatebaiviet")]
    partial class updatebaiviet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBanHang.Models.BaiViet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hinh");

                    b.Property<int>("MaLoai");

                    b.Property<string>("NoiDung");

                    b.Property<string>("TieuDe");

                    b.HasKey("ID");

                    b.ToTable("BaiViet");
                });

            modelBuilder.Entity("WebBanHang.Models.HangHoa", b =>
                {
                    b.Property<int>("MaHH")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DaMua");

                    b.Property<double>("DonGia");

                    b.Property<string>("Hinh");

                    b.Property<int>("MaLoai");

                    b.Property<string>("MoTa");

                    b.Property<DateTime>("NgayDang");

                    b.Property<bool>("NoiBat");

                    b.Property<int>("SoLuong");

                    b.Property<string>("TenHH")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaHH");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("WebBanHang.Models.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoai");

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("WebBanHang.Models.Oder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("CustomerID");

                    b.Property<string>("ShipAddress");

                    b.Property<string>("ShipEmail");

                    b.Property<int>("ShipMobile");

                    b.Property<string>("ShipName");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Oder");
                });

            modelBuilder.Entity("WebBanHang.Models.OderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Gia");

                    b.Property<int>("MaHH");

                    b.Property<int>("OderID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("OderID");

                    b.ToTable("OderDetail");
                });

            modelBuilder.Entity("WebBanHang.Models.QuangCao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hinh");

                    b.Property<int>("MaHH");

                    b.HasKey("ID");

                    b.ToTable("QuangCao");
                });

            modelBuilder.Entity("WebBanHang.Models.TaiKhoan", b =>
                {
                    b.Property<string>("MaTK")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MatKhau");

                    b.Property<string>("TenDangNhap");

                    b.HasKey("MaTK");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("WebBanHang.Models.HangHoa", b =>
                {
                    b.HasOne("WebBanHang.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebBanHang.Models.OderDetail", b =>
                {
                    b.HasOne("WebBanHang.Models.Oder", "oder")
                        .WithMany()
                        .HasForeignKey("OderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
