using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebDienThoaiDiDong.Models
{
    public class DienThoai
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập tên điện thoại")]
        [StringLength(10, ErrorMessage ="Tên điện thoại tối đa 100 ký tự")]
        public string PhoneName { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập giá sản phẩm")]
        public double Price { get; set; }

        [Required(ErrorMessage ="Vui long nhap hinh anh")]
        public string PhoneImage { get; set; }

        //Quan he voi tai khoan (ASP.NET Identity Package) quan he mot
        [Required]
        public string EmployeeId { get; set; }
        
        [Required]
        public ApplicationUser Employee { get; set; }

        //quan he mot voi danh muc
        [Required]
        public int DanhMucId { get; set; }

        [Required]
        public DanhMuc DanhMuc { get; set; }
    }
}