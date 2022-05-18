using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Management_System.Migrations
{
    public partial class Library : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author_table",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author_Name = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author_table", x => x.Author_Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Publisher_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Publisher_Name = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Publisher_Id);
                });

            migrationBuilder.CreateTable(
                name: "BookTable",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    Book_Title = table.Column<string>(type: "varchar(100)", nullable: true),
                    Book_Price = table.Column<int>(type: "int", nullable: false),
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    Publisher_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTable", x => x.Book_Id);
                    table.ForeignKey(
                        name: "FK_BookTable_Author_table_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Author_table",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTable_Publisher_Publisher_Id",
                        column: x => x.Publisher_Id,
                        principalTable: "Publisher",
                        principalColumn: "Publisher_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookTable_Author_Id",
                table: "BookTable",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookTable_BookCode",
                table: "BookTable",
                column: "BookCode",
                unique: true,
                filter: "[BookCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookTable_Publisher_Id",
                table: "BookTable",
                column: "Publisher_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTable");

            migrationBuilder.DropTable(
                name: "Author_table");

            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
