using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazoR.Migrations
{
    public partial class manyPostImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Posts");

            migrationBuilder.AddColumn<string[]>(
                name: "Images",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Posts",
                type: "text",
                nullable: true);
        }
    }
}
