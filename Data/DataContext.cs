using BanTin24h.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BanTin24h.Data
{
	public class DataContext : IdentityDbContext<User>
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<DiemDanh> DiemDanhs { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<CongViec> CongViecs { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<NhanVienDiemDanh> NhanVienDiemDanhs { get; set; }
        public DbSet<NhanVienLuong> NhanVienLuongs { get; set; }
        public DbSet<NhanVienCongViec> NhanVienCongViecs { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

            builder.Entity<NhanVienLuong>()
                .HasKey(_as => new { _as.MaNhanVien, _as.NgayNhanLuong });
            builder.Entity<NhanVienLuong>()
                .HasOne(e => e.NhanVien)
                .WithMany(_as => _as.NhanVienLuongs)
                .HasForeignKey(e => e.MaNhanVien);
            builder.Entity<NhanVienLuong>()
                .HasOne(s => s.Luong)
                .WithMany(_as => _as.NhanVienLuongs)
                .HasForeignKey(s => s.NgayNhanLuong);

            builder.Entity<NhanVienDiemDanh>()
                .HasKey(_as => new { _as.MaNhanVien, _as.ThoiGianDiemDanh });
            builder.Entity<NhanVienDiemDanh>()
                .HasOne(e => e.NhanVien)
                .WithMany(_as => _as.NhanVienDiemDanhs)
                .HasForeignKey(e => e.MaNhanVien);
            builder.Entity<NhanVienDiemDanh>()
                .HasOne(a => a.DiemDanh)
                .WithMany(_as => _as.NhanVienDiemDanhs)
                .HasForeignKey(a => a.ThoiGianDiemDanh);

            builder.Entity<NhanVienCongViec>()
                .HasKey(_as => new { _as.MaNhanVien, _as.MaCongViec });
            builder.Entity<NhanVienCongViec>()
                .HasOne(e => e.NhanVien)
                .WithMany(_as => _as.NhanVienCongViecs)
                .HasForeignKey(e => e.MaNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<NhanVienCongViec>()
                .HasOne(c => c.CongViec)
                .WithMany(_as => _as.NhanVienCongViecs)
                .HasForeignKey(c => c.MaCongViec)
				.OnDelete(DeleteBehavior.ClientSetNull);
		}
	}
}
