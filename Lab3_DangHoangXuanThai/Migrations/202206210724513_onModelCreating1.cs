namespace Lab3_DangHoangXuanThai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class onModelCreating1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers");
            AddForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers");
            AddForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
