using System.ComponentModel.DataAnnotations;

namespace BanTin24h.Models
{
	public class PhongBan
	{
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên phòng ban")]
        public string? TenPhongBan { get; set; }
        public string? DiaChi { get; set; }

		public string? UserId { get; set; }
		public ICollection<User>? NhanVien { get; set; }
	}
}
