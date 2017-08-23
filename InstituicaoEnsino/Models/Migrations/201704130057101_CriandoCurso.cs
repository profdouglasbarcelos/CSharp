namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoCurso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        CursoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Codigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CursoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cursoes");
        }
    }
}
