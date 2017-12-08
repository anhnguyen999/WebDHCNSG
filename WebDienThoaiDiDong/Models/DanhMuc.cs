using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDienThoaiDiDong.Models
{
    public class DanhMuc
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //quan he nhieu voi dien thoai
        public ICollection<DienThoai> DienThoais { get; set; }
    }
}