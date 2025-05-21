using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyPath.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MadeGraphNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GraphData",
                table: "UserBooks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("057f1764-c08e-4369-a993-eb18f6580be9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b5e19b8-9d10-4c44-9712-95a354d34e29"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0d598d50-874b-465b-be50-bb3518cd5342"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e5eca15-2bd9-4613-b109-dc864d78c5d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("151fa4f0-3cdb-488a-8f14-903e3b9fc60e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("15e9db48-3842-4a3d-9a55-d6cbcf2c5cb1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1fceca92-b2f5-40ae-a012-5dae708a40ae"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3b9bf35e-7987-48af-bd93-3a8b6d706eed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d9820bb-55a6-4343-b5ac-43118ea3a100"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68e1f645-23fb-4e1a-9adc-63f4fc6bd0f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74cc5783-ff29-40e4-a505-e07bd308c990"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b23b246-1582-4357-bc60-116fc4a58b27"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6a3be65-07fc-4ffb-bac5-e0b198988f9b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("accddc2f-b248-4a77-b10e-ede1235f1e2d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b93d574a-365b-49bf-9192-006c93f172a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba57a17b-214c-46f7-845a-602dfb15cf1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c4760132-f81d-47a7-82d9-7d57cdc72f9e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8f84543-c62d-48ae-87c7-42b50b0dbc17"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d9b11acc-2c18-4c56-a917-90d1e17a0788"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("da2778fa-7e17-4cd4-8ab0-c476f2f078e4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dd501e0a-4320-4f60-8a23-32e8a84f4b2f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea3ddaf3-1781-4447-bc3b-848375b1f3c1"));

            migrationBuilder.AlterColumn<string>(
                name: "GraphData",
                table: "UserBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
