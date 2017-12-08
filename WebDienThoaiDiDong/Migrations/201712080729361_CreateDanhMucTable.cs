namespace WebDienThoaiDiDong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDanhMucTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhMucs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DienThoais", "DanhMucId", c => c.Int(nullable: false));
            CreateIndex("dbo.DienThoais", "DanhMucId");
            AddForeignKey("dbo.DienThoais", "DanhMucId", "dbo.DanhMucs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DienThoais", "DanhMucId", "dbo.DanhMucs");
            DropIndex("dbo.DienThoais", new[] { "DanhMucId" });
            DropColumn("dbo.DienThoais", "DanhMucId");
            DropTable("dbo.DanhMucs");
        }
    }
}
