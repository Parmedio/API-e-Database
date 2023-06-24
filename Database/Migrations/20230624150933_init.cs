using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CivicNumber = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfBirth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exhibitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Museums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Museums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Museums_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paintings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfCreation = table.Column<int>(type: "int", nullable: false),
                    MuseumId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paintings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paintings_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paintings_Museums_MuseumId",
                        column: x => x.MuseumId,
                        principalTable: "Museums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExhibitionPainting",
                columns: table => new
                {
                    ExhibitionId = table.Column<int>(type: "int", nullable: false),
                    PaintingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhibitionPainting", x => new { x.ExhibitionId, x.PaintingId });
                    table.ForeignKey(
                        name: "FK_ExhibitionPainting_Exhibitions_ExhibitionId",
                        column: x => x.ExhibitionId,
                        principalTable: "Exhibitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExhibitionPainting_Paintings_PaintingId",
                        column: x => x.PaintingId,
                        principalTable: "Paintings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CivicNumber", "Country", "Street" },
                values: new object[,]
                {
                    { 1, "Pesaro", 2, "Italy", "via delle Fornaci" },
                    { 2, "Pistoia", 22, "Italy", "via San Sebastiano" },
                    { 3, "Oviedo", 13, "Spain", "via del Commercio" },
                    { 4, "Damasco", 17, "Syria", "via Mercatore" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name", "YearOfBirth" },
                values: new object[,]
                {
                    { 1, "Bryant", 1990 },
                    { 2, "Jordan", 1990 },
                    { 3, "Jokic", 1990 },
                    { 4, "Smart", 1990 }
                });

            migrationBuilder.InsertData(
                table: "Exhibitions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gli animali nella pittura del 1900" },
                    { 2, "Le città nel postimpressionismo" },
                    { 3, "Il sacro nel 900" },
                    { 4, "Ritratti di donna nel corso dei secoli" }
                });

            migrationBuilder.InsertData(
                table: "Museums",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Museo dei Fiori" },
                    { 2, 3, "Gran Museo della Ragione" },
                    { 3, 4, "Museo di Arte Maggiore" },
                    { 4, 2, "Il Laboratorio della Mente" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "Id", "ArtistId", "MuseumId", "Title", "YearOfCreation" },
                values: new object[,]
                {
                    { 1, 1, 1, "Vita dei campi", 1920 },
                    { 2, 1, 3, "Spiaggia Lunare", 1921 },
                    { 3, 2, 2, "Montagna di sale", 1922 },
                    { 4, 2, 4, "La stella più lontana", 1923 },
                    { 5, 3, 1, "L'artiglio di ghiaggio", 1924 },
                    { 6, 3, 3, "Lo sguardo della madre", 1925 },
                    { 7, 4, 2, "La mano del padre", 1926 },
                    { 8, 4, 4, "Velocità", 1927 }
                });

            migrationBuilder.InsertData(
                table: "ExhibitionPainting",
                columns: new[] { "ExhibitionId", "PaintingId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExhibitionPainting_PaintingId",
                table: "ExhibitionPainting",
                column: "PaintingId");

            migrationBuilder.CreateIndex(
                name: "IX_Museums_AddressId",
                table: "Museums",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_ArtistId",
                table: "Paintings",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_MuseumId",
                table: "Paintings",
                column: "MuseumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExhibitionPainting");

            migrationBuilder.DropTable(
                name: "Exhibitions");

            migrationBuilder.DropTable(
                name: "Paintings");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Museums");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
