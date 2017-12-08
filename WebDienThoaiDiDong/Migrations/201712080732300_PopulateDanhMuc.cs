namespace WebDienThoaiDiDong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDanhMuc : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DanhMucs(NAME) VALUES ('Samsung')");
            Sql("INSERT INTO DanhMucs(NAME) VALUES ('Apple')");
            Sql("INSERT INTO DanhMucs(NAME) VALUES ('Oppo')");
        }

        public override void Down()
        {
            Sql("DELETE DanhMucs");
        }
    }
}
