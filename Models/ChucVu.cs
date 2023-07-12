using BanTin24h.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace BanTin24h.Models
{
	public class ChucVu
	{
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên chức vụ")]
        public string? TenChucVu { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Hệ số lương")]
        public decimal? HeSoLuong { get; set; }
        public decimal? HeSoThuong { get; set; }
        public LoaiChucVu? LoaiChucVu { get; set; }

        public string? UserId { get; set; }
        public ICollection<User>? NhanVien { get; set; }
    }
}
