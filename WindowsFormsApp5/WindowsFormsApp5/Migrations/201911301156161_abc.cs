namespace WindowsFormsApp5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CNTTs",
                c => new
                    {
                        id_sv = c.String(nullable: false, maxLength: 128),
                        pascal = c.String(),
                        csharp = c.String(),
                        sql = c.String(),
                    })
                .PrimaryKey(t => t.id_sv);
            
            CreateTable(
                "dbo.DiemVans",
                c => new
                    {
                        id_sv = c.String(nullable: false, maxLength: 128),
                        vanhoccd = c.String(),
                        vanhochd = c.String(),
                    })
                .PrimaryKey(t => t.id_sv);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        hoten = c.String(),
                        gioitinh = c.Boolean(nullable: false),
                        ngaysinh = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.VatLies",
                c => new
                    {
                        id_sv = c.String(nullable: false, maxLength: 128),
                        cohoc = c.String(),
                        quanghoc = c.String(),
                        vlhatnhan = c.String(),
                    })
                .PrimaryKey(t => t.id_sv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VatLies");
            DropTable("dbo.SinhViens");
            DropTable("dbo.DiemVans");
            DropTable("dbo.CNTTs");
        }
    }
}
