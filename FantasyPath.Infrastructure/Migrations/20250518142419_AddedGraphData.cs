using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyPath.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedGraphData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassageEntries");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("020e0c54-527c-450f-b4ba-e2012d618f84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("106bdcd5-b398-4095-be6f-10414903485e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f40b0e0-c670-4f8f-ac89-46414437ef92"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48527f03-2e39-439d-8a83-a1fd5db87497"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5811aa54-72a4-47d5-b963-58081a2ff638"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5e3b7259-da00-4e3c-b3a6-e37275ceeae8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("73efaa6d-f41d-47a2-8e5f-2d60bc4fb2de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78316c28-0ab4-4482-9612-679998722bf5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7909ba29-97a5-46fb-a2d7-55f52e94194e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b4b1c0b-1bd3-49ae-b236-0a418652c6f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f39491f-4859-41f2-b0cd-537689817fd4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a2c09643-c660-41e9-8b6e-a1c3903fc17e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a83ff01c-b844-4c39-b589-924a7fb702c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b08f0233-909a-4590-9712-16bca8c5ac91"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bf7b2839-400b-492d-a491-3ffd1f058f20"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c3829673-840f-430b-84b7-3b6fdb1c8f12"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d36a7184-2042-4308-862c-c00b5641b148"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e4d88762-f7b7-4768-b469-c48dcae8ea4d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5861a3f-4fcf-4466-810b-9fbf37d12429"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e71d7e0b-3d62-4823-8f99-8d6eecb1ff94"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f17b4f89-ec6b-4162-9aff-4e20966194b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa506372-259f-4d9a-b622-46943e596ecb"));

            migrationBuilder.AddColumn<string>(
                name: "GraphData",
                table: "UserBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "Isbn", "Title" },
                values: new object[,]
                {
                    { new Guid("03ced8a7-d423-42af-9083-e3cd9c0029db"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328038532i/1129804.jpg", "9780140318296", "Scorpion Swamp" },
                    { new Guid("0457c45a-07b7-44ed-87e3-7ed783a76eba"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110513i/26066654.jpg", "9781840464290", "The Forest of Doom" },
                    { new Guid("136ee430-9e34-4576-b9f1-06155edf725a"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439126001i/26067801.jpg", "9780140316452", "City of Thieves" },
                    { new Guid("2eb036dc-0836-4f22-8cd9-a24542c093c8"), "Ian Livingstone", "https://static.wikia.nocookie.net/fightingfantasy/images/1/14/21_11.jpg/revision/latest/scale-to-width-down/1000?cb=20191223064046", "9780140320398", "Trial of Champions" },
                    { new Guid("2ff7fb7d-8640-45ec-b742-d1898f87e40a"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121250i/26067291.jpg", "9781840465280", "Temple of Terror" },
                    { new Guid("375f868c-15b0-452f-a6a8-cdc283750eaa"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1457004279i/1261049.jpg", "9780140318319", "House of Hell" },
                    { new Guid("3bc80bcd-293e-4241-98b9-08669efbe3f7"), "Ian Livingstone", "https://cybeswebsite.com/wp-content/uploads/2019/01/Figfan13n-186x300.jpg", "9780140317107", "Freeway Fighter" },
                    { new Guid("3edcc1ad-36c5-4dbc-b71e-07175792d4d5"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125616i/26067773.jpg", "9780140318302", "Caverns of the Snow Witch" },
                    { new Guid("42cfdbfa-dd47-45d5-9184-08d20cd6ce8f"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1188764984i/1817973.jpg", "9781840465273", "Appointment with F.E.A.R." },
                    { new Guid("4cba6ce7-7b15-4b53-81ba-d07f08f0235c"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1177021348i/675314.jpg", "9780140317084", "Deathtrap Dungeon" },
                    { new Guid("5dac7d67-6dd0-41bc-887b-08ddd44468a2"), "Robin Waterfield", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1232604646i/6123272.jpg", "99780140319521", "Rebel Planet" },
                    { new Guid("61a6a162-2ecc-44c3-9072-9ce496b4a9fc"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125202i/26067637.jpg", "9781840465662", "Talisman of Death" },
                    { new Guid("7e9bb05e-8393-43d0-8550-6806c410a82e"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439111136i/26066685.jpg", "9780140317435", "Island of the Lizard King" },
                    { new Guid("854b838e-3780-4f3b-a646-a922a8827101"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121633i/1261180.jpg", "9780440977087", "Seas of Blood" },
                    { new Guid("96a7f4e2-867b-4786-af23-e26517ce04ec"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1344077625i/1261601.jpg", "9780140321524", "Robot Commando" },
                    { new Guid("a29c7640-c463-4730-835d-eed8889d1d2c"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110049i/26066622.jpg", "9780743475112", "The Warlock of Firetop Mountain" },
                    { new Guid("a7204800-d2f4-4134-9d38-529ebb064399"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1357726081i/17228871.jpg", "9781840465525", "Starship Traveller" },
                    { new Guid("c21ff243-0385-47e2-9f03-11901ad88533"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439123656i/1029657.jpg", "9781840467321", "Sword of the Samurai" },
                    { new Guid("cc589dcb-4352-455d-931c-f41beb1162a3"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1181233137i/1129656.jpg", "9780140316032 ", "The Citadel of Chaos" },
                    { new Guid("dce14443-51ab-4934-aed6-3e6b0314009d"), "Andrew Chapman", "https://static.wikia.nocookie.net/fightingfantasy/images/e/ee/15_06.jpg/revision/latest/scale-to-width-down/1000?cb=20191223080002", "9780440974079", "The Rings of Kether" },
                    { new Guid("ec0b3ed6-83b4-4a9e-a3df-ba5276d39da5"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124891i/26067557.jpg", "9780440981497", "Space Assassin" },
                    { new Guid("fa420875-3b25-459a-9546-dc11c4534186"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124598i/26067514.jpg", "9780440918431", "Demons of the Deep" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("03ced8a7-d423-42af-9083-e3cd9c0029db"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0457c45a-07b7-44ed-87e3-7ed783a76eba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("136ee430-9e34-4576-b9f1-06155edf725a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2eb036dc-0836-4f22-8cd9-a24542c093c8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ff7fb7d-8640-45ec-b742-d1898f87e40a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("375f868c-15b0-452f-a6a8-cdc283750eaa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3bc80bcd-293e-4241-98b9-08669efbe3f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3edcc1ad-36c5-4dbc-b71e-07175792d4d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42cfdbfa-dd47-45d5-9184-08d20cd6ce8f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4cba6ce7-7b15-4b53-81ba-d07f08f0235c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5dac7d67-6dd0-41bc-887b-08ddd44468a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("61a6a162-2ecc-44c3-9072-9ce496b4a9fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e9bb05e-8393-43d0-8550-6806c410a82e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("854b838e-3780-4f3b-a646-a922a8827101"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("96a7f4e2-867b-4786-af23-e26517ce04ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a29c7640-c463-4730-835d-eed8889d1d2c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7204800-d2f4-4134-9d38-529ebb064399"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c21ff243-0385-47e2-9f03-11901ad88533"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cc589dcb-4352-455d-931c-f41beb1162a3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dce14443-51ab-4934-aed6-3e6b0314009d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec0b3ed6-83b4-4a9e-a3df-ba5276d39da5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa420875-3b25-459a-9546-dc11c4534186"));

            migrationBuilder.DropColumn(
                name: "GraphData",
                table: "UserBooks");

            migrationBuilder.CreateTable(
                name: "PassageEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextSectionNumbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousSectionNumber = table.Column<int>(type: "int", nullable: true),
                    SectionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassageEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassageEntries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassageEntries_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "Isbn", "Title" },
                values: new object[,]
                {
                    { new Guid("020e0c54-527c-450f-b4ba-e2012d618f84"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125202i/26067637.jpg", "9781840465662", "Talisman of Death" },
                    { new Guid("106bdcd5-b398-4095-be6f-10414903485e"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1357726081i/17228871.jpg", "9781840465525", "Starship Traveller" },
                    { new Guid("1f40b0e0-c670-4f8f-ac89-46414437ef92"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124598i/26067514.jpg", "9780440918431", "Demons of the Deep" },
                    { new Guid("48527f03-2e39-439d-8a83-a1fd5db87497"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1457004279i/1261049.jpg", "9780140318319", "House of Hell" },
                    { new Guid("5811aa54-72a4-47d5-b963-58081a2ff638"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1344077625i/1261601.jpg", "9780140321524", "Robot Commando" },
                    { new Guid("5e3b7259-da00-4e3c-b3a6-e37275ceeae8"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121250i/26067291.jpg", "9781840465280", "Temple of Terror" },
                    { new Guid("73efaa6d-f41d-47a2-8e5f-2d60bc4fb2de"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124891i/26067557.jpg", "9780440981497", "Space Assassin" },
                    { new Guid("78316c28-0ab4-4482-9612-679998722bf5"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439123656i/1029657.jpg", "9781840467321", "Sword of the Samurai" },
                    { new Guid("7909ba29-97a5-46fb-a2d7-55f52e94194e"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1188764984i/1817973.jpg", "9781840465273", "Appointment with F.E.A.R." },
                    { new Guid("7b4b1c0b-1bd3-49ae-b236-0a418652c6f2"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439111136i/26066685.jpg", "9780140317435", "Island of the Lizard King" },
                    { new Guid("8f39491f-4859-41f2-b0cd-537689817fd4"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125616i/26067773.jpg", "9780140318302", "Caverns of the Snow Witch" },
                    { new Guid("a2c09643-c660-41e9-8b6e-a1c3903fc17e"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439126001i/26067801.jpg", "9780140316452", "City of Thieves" },
                    { new Guid("a83ff01c-b844-4c39-b589-924a7fb702c9"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110049i/26066622.jpg", "9780743475112", "The Warlock of Firetop Mountain" },
                    { new Guid("b08f0233-909a-4590-9712-16bca8c5ac91"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121633i/1261180.jpg", "9780440977087", "Seas of Blood" },
                    { new Guid("bf7b2839-400b-492d-a491-3ffd1f058f20"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1177021348i/675314.jpg", "9780140317084", "Deathtrap Dungeon" },
                    { new Guid("c3829673-840f-430b-84b7-3b6fdb1c8f12"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110513i/26066654.jpg", "9781840464290", "The Forest of Doom" },
                    { new Guid("d36a7184-2042-4308-862c-c00b5641b148"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328038532i/1129804.jpg", "9780140318296", "Scorpion Swamp" },
                    { new Guid("e4d88762-f7b7-4768-b469-c48dcae8ea4d"), "Ian Livingstone", "https://static.wikia.nocookie.net/fightingfantasy/images/1/14/21_11.jpg/revision/latest/scale-to-width-down/1000?cb=20191223064046", "9780140320398", "Trial of Champions" },
                    { new Guid("e5861a3f-4fcf-4466-810b-9fbf37d12429"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1181233137i/1129656.jpg", "9780140316032 ", "The Citadel of Chaos" },
                    { new Guid("e71d7e0b-3d62-4823-8f99-8d6eecb1ff94"), "Andrew Chapman", "https://static.wikia.nocookie.net/fightingfantasy/images/e/ee/15_06.jpg/revision/latest/scale-to-width-down/1000?cb=20191223080002", "9780440974079", "The Rings of Kether" },
                    { new Guid("f17b4f89-ec6b-4162-9aff-4e20966194b9"), "Ian Livingstone", "https://cybeswebsite.com/wp-content/uploads/2019/01/Figfan13n-186x300.jpg", "9780140317107", "Freeway Fighter" },
                    { new Guid("fa506372-259f-4d9a-b622-46943e596ecb"), "Robin Waterfield", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1232604646i/6123272.jpg", "99780140319521", "Rebel Planet" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PassageEntries_BookId",
                table: "PassageEntries",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_PassageEntries_UserId_BookId",
                table: "PassageEntries",
                columns: new[] { "UserId", "BookId" });
        }
    }
}
