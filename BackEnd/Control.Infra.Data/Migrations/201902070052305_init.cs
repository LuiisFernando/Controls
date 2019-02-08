namespace Control.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovimentoManual",
                c => new
                    {
                        DAT_MES = c.Int(nullable: false),
                        DAT_ANO = c.Int(nullable: false),
                        NUM_LANCAMENTO = c.Int(nullable: false),
                        COD_PRODUTO = c.Int(nullable: false),
                        COD_COSIF = c.Int(nullable: false),
                        VAL_VALOR = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DES_DESCRICAO = c.String(maxLength: 50),
                        DAT_MOVIMENTO = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        COD_USUARIO = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.DAT_MES, t.DAT_ANO, t.NUM_LANCAMENTO, t.COD_PRODUTO, t.COD_COSIF })
                .ForeignKey("dbo.PRODUTO_COSIF", t => new { t.COD_PRODUTO, t.COD_COSIF })
                .Index(t => new { t.COD_PRODUTO, t.COD_COSIF });
            
            CreateTable(
                "dbo.PRODUTO_COSIF",
                c => new
                    {
                        COD_PRODUTO = c.Int(nullable: false),
                        COD_COSIF = c.Int(nullable: false),
                        COD_CLASSIFICACAO = c.String(maxLength: 6, fixedLength: true, unicode: false),
                        STA_STATUS = c.String(),
                    })
                .PrimaryKey(t => new { t.COD_PRODUTO, t.COD_COSIF })
                .ForeignKey("dbo.PRODUTO", t => t.COD_PRODUTO)
                .Index(t => t.COD_PRODUTO);
            
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        COD_PRODUTO = c.Int(nullable: false, identity: true),
                        DESC_PRODUTO = c.String(maxLength: 30),
                        STA_STATUS = c.String(),
                    })
                .PrimaryKey(t => t.COD_PRODUTO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PRODUTO_COSIF", "COD_PRODUTO", "dbo.PRODUTO");
            DropForeignKey("dbo.MovimentoManual", new[] { "COD_PRODUTO", "COD_COSIF" }, "dbo.PRODUTO_COSIF");
            DropIndex("dbo.PRODUTO_COSIF", new[] { "COD_PRODUTO" });
            DropIndex("dbo.MovimentoManual", new[] { "COD_PRODUTO", "COD_COSIF" });
            DropTable("dbo.PRODUTO");
            DropTable("dbo.PRODUTO_COSIF");
            DropTable("dbo.MovimentoManual");
        }
    }
}
