﻿// <auto-generated />
using System;
using BanTin24h.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BanTin24h.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230712222236_initialCreates")]
    partial class initialCreates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BanTin24h.Models.ChucVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("HeSoLuong")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("HeSoThuong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("LoaiChucVu")
                        .HasColumnType("int");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("BanTin24h.Models.CongViec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaChucVu")
                        .HasColumnType("int");

                    b.Property<int>("MaPhongBan")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("SoNguoiNhan")
                        .HasColumnType("int");

                    b.Property<string>("TenCongViec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaChucVu");

                    b.HasIndex("MaPhongBan");

                    b.ToTable("CongViecs");
                });

            modelBuilder.Entity("BanTin24h.Models.DiemDanh", b =>
                {
                    b.Property<DateTime>("ThoiGianDiemDanh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKetThuc")
                        .HasColumnType("datetime2");

                    b.HasKey("ThoiGianDiemDanh");

                    b.ToTable("DiemDanhs");
                });

            modelBuilder.Entity("BanTin24h.Models.Luong", b =>
                {
                    b.Property<DateTime>("NgayNhanLuong")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LuongCung")
                        .HasColumnType("int");

                    b.Property<int?>("LuongPhat")
                        .HasColumnType("int");

                    b.Property<int?>("LuongThuong")
                        .HasColumnType("int");

                    b.HasKey("NgayNhanLuong");

                    b.ToTable("Luongs");
                });

            modelBuilder.Entity("BanTin24h.Models.NhanVienCongViec", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MaCongViec")
                        .HasColumnType("int");

                    b.HasKey("MaNhanVien", "MaCongViec");

                    b.HasIndex("MaCongViec");

                    b.ToTable("NhanVienCongViecs");
                });

            modelBuilder.Entity("BanTin24h.Models.NhanVienDiemDanh", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ThoiGianDiemDanh")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SoGioLam")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaNhanVien", "ThoiGianDiemDanh");

                    b.HasIndex("ThoiGianDiemDanh");

                    b.ToTable("NhanVienDiemDanhs");
                });

            modelBuilder.Entity("BanTin24h.Models.NhanVienLuong", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("NgayNhanLuong")
                        .HasColumnType("datetime2");

                    b.HasKey("MaNhanVien", "NgayNhanLuong");

                    b.HasIndex("NgayNhanLuong");

                    b.ToTable("NhanVienLuongs");
                });

            modelBuilder.Entity("BanTin24h.Models.PhongBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhongBan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhongBans");
                });

            modelBuilder.Entity("BanTin24h.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("ChucVusId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("MaChucVu")
                        .HasColumnType("int");

                    b.Property<int>("MaPhongBan")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ChucVusId");

                    b.HasIndex("MaPhongBan");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BanTin24h.Models.CongViec", b =>
                {
                    b.HasOne("BanTin24h.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("MaChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BanTin24h.Models.PhongBan", "PhongBan")
                        .WithMany()
                        .HasForeignKey("MaPhongBan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");

                    b.Navigation("PhongBan");
                });

            modelBuilder.Entity("BanTin24h.Models.NhanVienCongViec", b =>
                {
                    b.HasOne("BanTin24h.Models.CongViec", "CongViec")
                        .WithMany("NhanVienCongViecs")
                        .HasForeignKey("MaCongViec")
                        .IsRequired();

                    b.HasOne("BanTin24h.Models.User", "NhanVien")
                        .WithMany("NhanVienCongViecs")
                        .HasForeignKey("MaNhanVien")
                        .IsRequired();

                    b.Navigation("CongViec");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("BanTin24h.Models.NhanVienDiemDanh", b =>
                {
                    b.HasOne("BanTin24h.Models.User", "NhanVien")
                        .WithMany("NhanVienDiemDanhs")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BanTin24h.Models.DiemDanh", "DiemDanh")
                        .WithMany("NhanVienDiemDanhs")
                        .HasForeignKey("ThoiGianDiemDanh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiemDanh");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("BanTin24h.Models.NhanVienLuong", b =>
                {
                    b.HasOne("BanTin24h.Models.User", "NhanVien")
                        .WithMany("NhanVienLuongs")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BanTin24h.Models.Luong", "Luong")
                        .WithMany("NhanVienLuongs")
                        .HasForeignKey("NgayNhanLuong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Luong");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("BanTin24h.Models.User", b =>
                {
                    b.HasOne("BanTin24h.Models.ChucVu", "ChucVus")
                        .WithMany("NhanVien")
                        .HasForeignKey("ChucVusId");

                    b.HasOne("BanTin24h.Models.PhongBan", "PhongBan")
                        .WithMany("NhanVien")
                        .HasForeignKey("MaPhongBan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVus");

                    b.Navigation("PhongBan");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BanTin24h.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BanTin24h.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BanTin24h.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BanTin24h.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BanTin24h.Models.ChucVu", b =>
                {
                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("BanTin24h.Models.CongViec", b =>
                {
                    b.Navigation("NhanVienCongViecs");
                });

            modelBuilder.Entity("BanTin24h.Models.DiemDanh", b =>
                {
                    b.Navigation("NhanVienDiemDanhs");
                });

            modelBuilder.Entity("BanTin24h.Models.Luong", b =>
                {
                    b.Navigation("NhanVienLuongs");
                });

            modelBuilder.Entity("BanTin24h.Models.PhongBan", b =>
                {
                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("BanTin24h.Models.User", b =>
                {
                    b.Navigation("NhanVienCongViecs");

                    b.Navigation("NhanVienDiemDanhs");

                    b.Navigation("NhanVienLuongs");
                });
#pragma warning restore 612, 618
        }
    }
}
