using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyPath.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedLastViewedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastViewed",
                table: "UserBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0582362a-ad07-4165-992e-0b2fbad7a784"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0779fb7c-13e2-4cc8-8601-db193ba2142b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("08c1122f-efe0-4db0-a2a7-72ca220a557e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1a5b1837-37d2-459c-9804-ff85667fa81e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38d774c5-2564-46f4-a512-794f713d5e06"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48a1d170-479c-48d4-9380-3c6b03fadc19"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4a902e83-97bd-4bf4-9a8b-7f6253e52dc3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d9ad344-de66-4c0d-bc29-f5ad1607ba49"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f83118d-1504-4129-a3de-810ad4d22941"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5491cf7a-2350-4139-9c26-3ae1d997bdd0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("559b2f9e-3561-4b48-b862-b06847a09c4c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58a917a1-88c5-4c43-918f-9ceb1ff74948"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("598013ce-4e03-49b7-afe0-794c751c44fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7abdd394-64c1-46fe-867c-0b2e36472fd2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8fd2f9f3-4806-4c39-a480-c43c5c5f1908"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2e34f84-33eb-4478-8bc7-3062de0071c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b76ab77a-ee7a-46f5-b6da-ca1186c6b8dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c175a214-0fbe-4ce0-a2ff-b1cf3f6aba32"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c62ea848-a5fc-4229-995e-399742c58dc4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e001ff0b-0a21-4a93-97b9-bdd9d7175a40"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f2486bc9-9547-4080-88f6-81a4ab2cbeef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fe242287-3ddf-4fe3-850b-162219a22706"));

            migrationBuilder.DropColumn(
                name: "LastViewed",
                table: "UserBooks");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "Isbn", "Title" },
                values: new object[,]
                {
                    { new Guid("057f1764-c08e-4369-a993-eb18f6580be9"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110049i/26066622.jpg", "9780743475112", "The Warlock of Firetop Mountain" },
                    { new Guid("0b5e19b8-9d10-4c44-9712-95a354d34e29"), "Robin Waterfield", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1232604646i/6123272.jpg", "99780140319521", "Rebel Planet" },
                    { new Guid("0d598d50-874b-465b-be50-bb3518cd5342"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439123656i/1029657.jpg", "9781840467321", "Sword of the Samurai" },
                    { new Guid("0e5eca15-2bd9-4613-b109-dc864d78c5d5"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1181233137i/1129656.jpg", "9780140316032 ", "The Citadel of Chaos" },
                    { new Guid("151fa4f0-3cdb-488a-8f14-903e3b9fc60e"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1357726081i/17228871.jpg", "9781840465525", "Starship Traveller" },
                    { new Guid("15e9db48-3842-4a3d-9a55-d6cbcf2c5cb1"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124891i/26067557.jpg", "9780440981497", "Space Assassin" },
                    { new Guid("1fceca92-b2f5-40ae-a012-5dae708a40ae"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1188764984i/1817973.jpg", "9781840465273", "Appointment with F.E.A.R." },
                    { new Guid("3b9bf35e-7987-48af-bd93-3a8b6d706eed"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124598i/26067514.jpg", "9780440918431", "Demons of the Deep" },
                    { new Guid("4d9820bb-55a6-4343-b5ac-43118ea3a100"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121250i/26067291.jpg", "9781840465280", "Temple of Terror" },
                    { new Guid("68e1f645-23fb-4e1a-9adc-63f4fc6bd0f5"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1457004279i/1261049.jpg", "9780140318319", "House of Hell" },
                    { new Guid("74cc5783-ff29-40e4-a505-e07bd308c990"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110513i/26066654.jpg", "9781840464290", "The Forest of Doom" },
                    { new Guid("9b23b246-1582-4357-bc60-116fc4a58b27"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121633i/1261180.jpg", "9780440977087", "Seas of Blood" },
                    { new Guid("a6a3be65-07fc-4ffb-bac5-e0b198988f9b"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1344077625i/1261601.jpg", "9780140321524", "Robot Commando" },
                    { new Guid("accddc2f-b248-4a77-b10e-ede1235f1e2d"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439111136i/26066685.jpg", "9780140317435", "Island of the Lizard King" },
                    { new Guid("b93d574a-365b-49bf-9192-006c93f172a8"), "Ian Livingstone", "https://cybeswebsite.com/wp-content/uploads/2019/01/Figfan13n-186x300.jpg", "9780140317107", "Freeway Fighter" },
                    { new Guid("ba57a17b-214c-46f7-845a-602dfb15cf1c"), "Andrew Chapman", "https://static.wikia.nocookie.net/fightingfantasy/images/e/ee/15_06.jpg/revision/latest/scale-to-width-down/1000?cb=20191223080002", "9780440974079", "The Rings of Kether" },
                    { new Guid("c4760132-f81d-47a7-82d9-7d57cdc72f9e"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125616i/26067773.jpg", "9780140318302", "Caverns of the Snow Witch" },
                    { new Guid("d8f84543-c62d-48ae-87c7-42b50b0dbc17"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1177021348i/675314.jpg", "9780140317084", "Deathtrap Dungeon" },
                    { new Guid("d9b11acc-2c18-4c56-a917-90d1e17a0788"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439126001i/26067801.jpg", "9780140316452", "City of Thieves" },
                    { new Guid("da2778fa-7e17-4cd4-8ab0-c476f2f078e4"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328038532i/1129804.jpg", "9780140318296", "Scorpion Swamp" },
                    { new Guid("dd501e0a-4320-4f60-8a23-32e8a84f4b2f"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125202i/26067637.jpg", "9781840465662", "Talisman of Death" },
                    { new Guid("ea3ddaf3-1781-4447-bc3b-848375b1f3c1"), "Ian Livingstone", "https://static.wikia.nocookie.net/fightingfantasy/images/1/14/21_11.jpg/revision/latest/scale-to-width-down/1000?cb=20191223064046", "9780140320398", "Trial of Champions" }
                });
        }
    }
}
