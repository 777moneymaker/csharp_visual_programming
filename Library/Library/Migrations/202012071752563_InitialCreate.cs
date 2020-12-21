namespace Library.Migrations {
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        IDK = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Borrower_IDC = c.Int(),
                    })
                .PrimaryKey(t => t.IDK)
                .ForeignKey("dbo.People", t => t.Borrower_IDC)
                .Index(t => t.Borrower_IDC);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        IDC = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IDC);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Borrower_IDC", "dbo.People");
            DropIndex("dbo.Books", new[] { "Borrower_IDC" });
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }
}
