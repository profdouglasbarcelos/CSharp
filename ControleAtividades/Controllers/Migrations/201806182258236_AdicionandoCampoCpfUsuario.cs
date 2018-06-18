namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoCampoCpfUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Cpf", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Cpf");
        }
    }
}
