using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanTin24h.Models
{
	public class User : IdentityUser
	{
        public string? ProfileImageUrl { get; set; }
        public string? DiaChi { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        [ForeignKey("ChuCVu")]
        public int MaChucVu { get; set; }
        public ChucVu? ChucVus { get; set; }
        [ForeignKey("PhongBan")]
        public int MaPhongBan { get; set; }
        public PhongBan? PhongBan { get; set; }

        public ICollection<NhanVienCongViec>? NhanVienCongViecs { get; set; }
        public ICollection<NhanVienLuong>? NhanVienLuongs { get; set; }
        public ICollection<NhanVienDiemDanh>? NhanVienDiemDanhs { get; set; }
    }
}
