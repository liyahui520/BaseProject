using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCore.BaseProject.Migrations
{
    public partial class Add_Treachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DIM_Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    TeacherId = table.Column<long>(nullable: false),
                    TeacherName = table.Column<string>(maxLength: 50, nullable: false),
                    Sexy = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(maxLength: 1000, nullable: true),
                    CellPhone = table.Column<string>(maxLength: 11, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Personal = table.Column<string>(nullable: true),
                    Memark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIM_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DIM_Teachers");
        }
    }
}
