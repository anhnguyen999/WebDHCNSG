using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WebDienThoaiDiDong.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //Dinh nghia ket noi model DienThoai
        public DbSet<DienThoai> DienThoais { get; set; }

        public ApplicationDbContext()
            : base("WebDienThoaiConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WebDienThoaiDiDong.Models.DanhMuc> DanhMucs { get; set; }
    }
}