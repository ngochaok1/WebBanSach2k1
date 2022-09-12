﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBanSach.Data;

#nullable disable

namespace WebBanSach.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebBanSach.Data.BP_SachTacGia", b =>
                {
                    b.Property<Guid>("IdSach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTacGia")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSach", "IdTacGia");

                    b.HasIndex("IdTacGia");

                    b.ToTable("BP_SachTacGia");
                });

            modelBuilder.Entity("WebBanSach.Data.ChiTietDonHang", b =>
                {
                    b.Property<Guid>("IdSach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdDonHang")
                        .HasColumnType("int");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongMua")
                        .HasColumnType("int");

                    b.Property<int?>("ThanhTien")
                        .HasColumnType("int");

                    b.HasKey("IdSach", "IdDonHang");

                    b.HasIndex("IdDonHang");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("WebBanSach.Data.DonHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid?>("IdKhach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBan")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("WebBanSach.Data.HoaDon", b =>
                {
                    b.Property<int>("IDHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDHoaDon"), 1L, 1);

                    b.Property<int>("IdDonHang")
                        .HasColumnType("int");

                    b.Property<float>("TongTien")
                        .HasColumnType("real");

                    b.Property<int>("TongTientrcVAT")
                        .HasColumnType("int");

                    b.Property<float>("VAT")
                        .HasColumnType("real");

                    b.HasKey("IDHoaDon");

                    b.HasIndex("IdDonHang")
                        .IsUnique();

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("WebBanSach.Data.NhaXuatBan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNXB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("NhaXuatBan", (string)null);
                });

            modelBuilder.Entity("WebBanSach.Data.Sach", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("donGia")
                        .HasColumnType("int");

                    b.Property<Guid?>("idNXB")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenSach")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("idNXB");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("WebBanSach.Data.SachTheLoai", b =>
                {
                    b.Property<Guid>("IdSach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTheLoai")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSach", "IdTheLoai");

                    b.HasIndex("IdTheLoai");

                    b.ToTable("BP_SachTheLoai");
                });

            modelBuilder.Entity("WebBanSach.Data.TacGia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaTacGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("STT")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TacGia");
                });

            modelBuilder.Entity("WebBanSach.Data.TheLoai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaTL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TheLoai");
                });

            modelBuilder.Entity("WebBanSach.Data.BP_SachTacGia", b =>
                {
                    b.HasOne("WebBanSach.Data.Sach", "Sach")
                        .WithMany("bP_SachTacGias")
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SACH_TG1");

                    b.HasOne("WebBanSach.Data.TacGia", "TacGia")
                        .WithMany("bP_SachTacGias")
                        .HasForeignKey("IdTacGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SACH_TG2");

                    b.Navigation("Sach");

                    b.Navigation("TacGia");
                });

            modelBuilder.Entity("WebBanSach.Data.ChiTietDonHang", b =>
                {
                    b.HasOne("WebBanSach.Data.DonHang", "DonHang")
                        .WithMany("chiTietDonHangs")
                        .HasForeignKey("IdDonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietDonHang2");

                    b.HasOne("WebBanSach.Data.Sach", "Sach")
                        .WithMany("chiTietDonHangs")
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietDonHang1");

                    b.Navigation("DonHang");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("WebBanSach.Data.HoaDon", b =>
                {
                    b.HasOne("WebBanSach.Data.DonHang", "DonHang")
                        .WithOne("HoaDon")
                        .HasForeignKey("WebBanSach.Data.HoaDon", "IdDonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");
                });

            modelBuilder.Entity("WebBanSach.Data.Sach", b =>
                {
                    b.HasOne("WebBanSach.Data.NhaXuatBan", "NhaXuatBan")
                        .WithMany("saches")
                        .HasForeignKey("idNXB")
                        .HasConstraintName("FK_SACH_NXB");

                    b.Navigation("NhaXuatBan");
                });

            modelBuilder.Entity("WebBanSach.Data.SachTheLoai", b =>
                {
                    b.HasOne("WebBanSach.Data.Sach", "sach")
                        .WithMany("sachTheLoais")
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Sach_TL");

                    b.HasOne("WebBanSach.Data.TheLoai", "theLoai")
                        .WithMany("sachTheLoais")
                        .HasForeignKey("IdTheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TheLoai_Sach");

                    b.Navigation("sach");

                    b.Navigation("theLoai");
                });

            modelBuilder.Entity("WebBanSach.Data.DonHang", b =>
                {
                    b.Navigation("HoaDon")
                        .IsRequired();

                    b.Navigation("chiTietDonHangs");
                });

            modelBuilder.Entity("WebBanSach.Data.NhaXuatBan", b =>
                {
                    b.Navigation("saches");
                });

            modelBuilder.Entity("WebBanSach.Data.Sach", b =>
                {
                    b.Navigation("bP_SachTacGias");

                    b.Navigation("chiTietDonHangs");

                    b.Navigation("sachTheLoais");
                });

            modelBuilder.Entity("WebBanSach.Data.TacGia", b =>
                {
                    b.Navigation("bP_SachTacGias");
                });

            modelBuilder.Entity("WebBanSach.Data.TheLoai", b =>
                {
                    b.Navigation("sachTheLoais");
                });
#pragma warning restore 612, 618
        }
    }
}
