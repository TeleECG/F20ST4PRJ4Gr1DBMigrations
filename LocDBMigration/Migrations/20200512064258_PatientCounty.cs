using Microsoft.EntityFrameworkCore.Migrations;

namespace F20ST4PRJ4Gr1LoacalDB.Migrations
{
    public partial class PatientCounty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "PatientMeasurements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "County",
                table: "PatientMeasurements");
        }
    }
}
