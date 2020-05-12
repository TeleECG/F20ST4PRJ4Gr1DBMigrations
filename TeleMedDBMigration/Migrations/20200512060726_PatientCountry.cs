using Microsoft.EntityFrameworkCore.Migrations;

namespace F20ST4PRJ4Gr1TelemedDB.Migrations
{
    public partial class PatientCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "PatientMeasurements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "PatientMeasurements");
        }
    }
}
