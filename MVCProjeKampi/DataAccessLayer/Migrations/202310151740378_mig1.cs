namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    { //update database yaparsak; 1,2
        public override void Up() //1 değişiklikleri  kaydedersek buradaki işlemler gerçekleşecek
        {
            AddColumn("dbo.Contents", "WriterID", c => c.Int());
            CreateIndex("dbo.Contents", "WriterID");
            AddForeignKey("dbo.Contents", "WriterID", "dbo.Writers", "WriterID");
        }
        
        public override void Down()     //2 değişiklikleri  kaydetmezsek buradaki işlemler gerçekleşecek
        {
            DropForeignKey("dbo.Contents", "WriterID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterID" });
            DropColumn("dbo.Contents", "WriterID");
        }
    }
}
