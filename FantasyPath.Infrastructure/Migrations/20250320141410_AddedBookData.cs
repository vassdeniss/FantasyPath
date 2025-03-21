using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyPath.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Books",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "Isbn", "Title" },
                values: new object[,]
                {
                    { new Guid("05bd0f3e-aa9d-48e3-b510-e96dceecccf1"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125202i/26067637.jpg", "9781840465662", "Talisman of Death" },
                    { new Guid("060382b0-087b-4f54-8866-60767da6c8d5"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1181233137i/1129656.jpg", "9780140316032 ", "The Citadel of Chaos" },
                    { new Guid("0c08dbb4-6afb-4382-a382-8837decc3f80"), "Andrew Chapman", "https://static.wikia.nocookie.net/fightingfantasy/images/e/ee/15_06.jpg/revision/latest/scale-to-width-down/1000?cb=20191223080002", "9780440974079", "The Rings of Kether" },
                    { new Guid("0ea7e741-26b5-4c51-80a1-0e9d574245ea"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110049i/26066622.jpg", "9780743475112", "The Warlock of Firetop Mountain" },
                    { new Guid("1e175ade-5bc4-438c-80cc-40f75d6b713e"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439123656i/1029657.jpg", "9781840467321", "Sword of the Samurai" },
                    { new Guid("2cb8b2b4-b743-484f-8f90-c8cb7030f0f1"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328038532i/1129804.jpg", "9780140318296", "Scorpion Swamp" },
                    { new Guid("4af04bfc-c411-4efd-96ff-8d89f3819b30"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1177021348i/675314.jpg", "9780140317084", "Deathtrap Dungeon" },
                    { new Guid("56e372d8-fd50-46d6-98d6-13ab3b403207"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124598i/26067514.jpg", "9780440918431", "Demons of the Deep" },
                    { new Guid("63df150c-24d0-4092-8f00-41d3953328c3"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110513i/26066654.jpg", "9781840464290", "The Forest of Doom" },
                    { new Guid("65985f54-c513-42e1-9c71-98e8cf0cc198"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439126001i/26067801.jpg", "9780140316452", "City of Thieves" },
                    { new Guid("6e97335e-c23b-44f7-a8a2-5157b18ab940"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1188764984i/1817973.jpg", "9781840465273", "Appointment with F.E.A.R." },
                    { new Guid("817a8760-92af-450e-af16-3a1c2d100d60"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1344077625i/1261601.jpg", "9780140321524", "Robot Commando" },
                    { new Guid("a05b3c28-2234-48f1-b381-fc843089d57c"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125616i/26067773.jpg", "9780140318302", "Caverns of the Snow Witch" },
                    { new Guid("a5694aa9-72ca-402c-aee2-e7c5f136f35b"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124891i/26067557.jpg", "9780440981497", "Space Assassin" },
                    { new Guid("a61276ea-506e-4be4-8d24-5f4f6cbbae14"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121250i/26067291.jpg", "9781840465280", "Temple of Terror" },
                    { new Guid("a63367d4-e9b0-4b0f-a9ba-ad7b2a68d147"), "Robin Waterfield", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1232604646i/6123272.jpg", "99780140319521", "Rebel Planet" },
                    { new Guid("b16d3b28-e6e1-48fe-98e2-8f007d7a681a"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1357726081i/17228871.jpg", "9781840465525", "Starship Traveller" },
                    { new Guid("b4acb79b-52e4-4f47-832b-36b434cee1b6"), "Ian Livingstone", "https://static.wikia.nocookie.net/fightingfantasy/images/1/14/21_11.jpg/revision/latest/scale-to-width-down/1000?cb=20191223064046", "9780140320398", "Trial of Champions" },
                    { new Guid("d72e579b-ba4f-4a43-95fa-9d4019a6e710"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439111136i/26066685.jpg", "9780140317435", "Island of the Lizard King" },
                    { new Guid("dfcfa211-6b1c-4d5b-9416-1100e5268039"), "Ian Livingstone", "https://cybeswebsite.com/wp-content/uploads/2019/01/Figfan13n-186x300.jpg", "9780140317107", "Freeway Fighter" },
                    { new Guid("e0a10317-e60e-461b-a1ab-146cfa3b7284"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1457004279i/1261049.jpg", "9780140318319", "House of Hell" },
                    { new Guid("e90c49eb-1f2b-4c4b-ab27-31990392a858"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121633i/1261180.jpg", "9780440977087", "Seas of Blood" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("05bd0f3e-aa9d-48e3-b510-e96dceecccf1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("060382b0-087b-4f54-8866-60767da6c8d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c08dbb4-6afb-4382-a382-8837decc3f80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ea7e741-26b5-4c51-80a1-0e9d574245ea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1e175ade-5bc4-438c-80cc-40f75d6b713e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2cb8b2b4-b743-484f-8f90-c8cb7030f0f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4af04bfc-c411-4efd-96ff-8d89f3819b30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("56e372d8-fd50-46d6-98d6-13ab3b403207"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("63df150c-24d0-4092-8f00-41d3953328c3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("65985f54-c513-42e1-9c71-98e8cf0cc198"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e97335e-c23b-44f7-a8a2-5157b18ab940"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("817a8760-92af-450e-af16-3a1c2d100d60"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a05b3c28-2234-48f1-b381-fc843089d57c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5694aa9-72ca-402c-aee2-e7c5f136f35b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a61276ea-506e-4be4-8d24-5f4f6cbbae14"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a63367d4-e9b0-4b0f-a9ba-ad7b2a68d147"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b16d3b28-e6e1-48fe-98e2-8f007d7a681a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4acb79b-52e4-4f47-832b-36b434cee1b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d72e579b-ba4f-4a43-95fa-9d4019a6e710"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dfcfa211-6b1c-4d5b-9416-1100e5268039"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e0a10317-e60e-461b-a1ab-146cfa3b7284"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e90c49eb-1f2b-4c4b-ab27-31990392a858"));

            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Books");
        }
    }
}
