using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeRegions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CodeRegions",
                columns: new[] { "Id", "Code", "Region" },
                values: new object[,]
                {
                    { 1, "АК", "АР Крим" },
                    { 2, "АВ", "Вінницька область" },
                    { 3, "АС", "Волинська область" },
                    { 4, "АЕ", "Дніпропетровська область" },
                    { 5, "АН", "Донецька область" },
                    { 6, "АМ", "Житомирська область" },
                    { 7, "АО", "Закарпатська область" },
                    { 8, "АР", "Запорізька область" },
                    { 9, "АТ", "Івано-Франківська область" },
                    { 10, "АА", "Київ" },
                    { 11, "АІ", "Київська область" },
                    { 12, "ВА", "Кіровоградська область" },
                    { 13, "ВВ", "Луганська область" },
                    { 14, "ВС", "Львіська область" },
                    { 15, "ВЕ", "Миколаївська область" },
                    { 16, "ВН", "Одеська область" },
                    { 17, "ВІ", "Полтавська область" },
                    { 18, "ВК", "Рівненська область" },
                    { 19, "СН", "Севастополь" },
                    { 20, "ВМ", "Сумська область" },
                    { 21, "ВО", "Тернопільська область" },
                    { 22, "АХ", "Харківська область" },
                    { 23, "ВТ", "Херсонська область" },
                    { 24, "ВХ", "Хмельницька область" },
                    { 25, "СА", "Черкаська область" },
                    { 26, "СВ", "Чернігівська область" },
                    { 27, "СЕ", "Чернівецька область" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeRegions");
        }
    }
}
