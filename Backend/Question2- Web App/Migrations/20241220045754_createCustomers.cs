using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Question2__Web_App.Migrations
{
    public partial class createCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "varchar(20)", nullable: true),
                    CustomerDetails = table.Column<string>(type: "varchar(50)", nullable: true),
                    CustomerAge = table.Column<int>(type: "int", nullable: false),
                    CustomerMail = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
