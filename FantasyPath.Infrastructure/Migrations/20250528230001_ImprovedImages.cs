using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyPath.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImprovedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CoverImageUrl",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Isbn", "Order", "Title" },
                values: new object[,]
                {
                    { new Guid("03f44579-899c-41c7-bfce-89964308bab0"), "Ian Livingstone", "9781840465280", 14, "Temple of Terror" },
                    { new Guid("2b3b4e94-73f6-49c0-a62e-4e900581ff39"), "Steve Jackson", "9781840465273", 17, "Appointment with F.E.A.R." },
                    { new Guid("41ff0756-f559-4cca-bf93-a1fa24a982f3"), "Andrew Chapman", "9780440977087", 16, "Seas of Blood" },
                    { new Guid("429a6fcc-39db-4f40-b60f-1ebb136a543b"), "Mark Smith & Jamie Thomson", "9781840467321", 20, "Sword of the Samurai" },
                    { new Guid("4fa26a30-91b5-4d84-9a43-59be57cbfbe0"), "Ian Livingstone", "9780140317084", 6, "Deathtrap Dungeon" },
                    { new Guid("58b8465d-3486-421b-b377-b5634319745b"), "Ian Livingstone", "9780140318302", 9, "Caverns of the Snow Witch" },
                    { new Guid("60474947-8c00-4389-92e6-b8ee861b338d"), "Mark Smith & Jamie Thomson", "9781840465662", 11, "Talisman of Death" },
                    { new Guid("960865ba-6f8d-419e-ab80-35fe35e8009f"), "Steve Jackson", "9780140318319", 10, "House of Hell" },
                    { new Guid("aa8a5c24-3f56-45a8-a52d-32dc091ec96a"), "Andrew Chapman", "9780440974079", 15, "The Rings of Kether" },
                    { new Guid("b541751e-5e36-4a5e-8b44-eacfe044b5b2"), "Ian Livingstone", "9780140317107", 13, "Freeway Fighter" },
                    { new Guid("bc2d957d-b222-4151-8cad-9e137d3ac879"), "Andrew Chapman", "9780440981497", 12, "Space Assassin" },
                    { new Guid("bcb875ee-1010-4734-9447-226eea947e7e"), "Ian Livingstone", "9781840464290", 3, "The Forest of Doom" },
                    { new Guid("c073fcde-dc4d-4c32-a969-17cf3f9f2e52"), "Ian Livingstone", "9780140317435", 7, "Island of the Lizard King" },
                    { new Guid("d1efb3fc-0107-4488-8c6a-bb9c6472f236"), "Ian Livingstone", "9780140316452", 5, "City of Thieves" },
                    { new Guid("d70d4649-e8fc-4e80-995f-2ac304a13267"), "Steve Jackson", "9780140316032 ", 2, "The Citadel of Chaos" },
                    { new Guid("e076483a-40c1-4f4c-9a16-942cf2a9a04d"), "Steve Jackson", "9781840465525", 4, "Starship Traveller" },
                    { new Guid("e15ca34a-13b1-4b2e-bb04-55b8a35f6186"), "Robin Waterfield", "99780140319521", 18, "Rebel Planet" },
                    { new Guid("e63d0b82-1507-4df6-99bd-97862f36bbba"), "Steve Jackson & Ian Livingstone", "9780440918431", 19, "Demons of the Deep" },
                    { new Guid("e89a3706-4fca-46c7-962f-3ac4f9f76765"), "Steve Jackson & Ian Livingstone", "9780743475112", 1, "The Warlock of Firetop Mountain" },
                    { new Guid("f29ad60c-e3a1-4f52-82d6-16b5c40fc646"), "Steve Jackson", "9780140318296", 8, "Scorpion Swamp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("03f44579-899c-41c7-bfce-89964308bab0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b3b4e94-73f6-49c0-a62e-4e900581ff39"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41ff0756-f559-4cca-bf93-a1fa24a982f3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("429a6fcc-39db-4f40-b60f-1ebb136a543b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4fa26a30-91b5-4d84-9a43-59be57cbfbe0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58b8465d-3486-421b-b377-b5634319745b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60474947-8c00-4389-92e6-b8ee861b338d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("960865ba-6f8d-419e-ab80-35fe35e8009f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa8a5c24-3f56-45a8-a52d-32dc091ec96a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b541751e-5e36-4a5e-8b44-eacfe044b5b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bc2d957d-b222-4151-8cad-9e137d3ac879"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bcb875ee-1010-4734-9447-226eea947e7e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c073fcde-dc4d-4c32-a969-17cf3f9f2e52"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1efb3fc-0107-4488-8c6a-bb9c6472f236"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d70d4649-e8fc-4e80-995f-2ac304a13267"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e076483a-40c1-4f4c-9a16-942cf2a9a04d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e15ca34a-13b1-4b2e-bb04-55b8a35f6186"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e63d0b82-1507-4df6-99bd-97862f36bbba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e89a3706-4fca-46c7-962f-3ac4f9f76765"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29ad60c-e3a1-4f52-82d6-16b5c40fc646"));

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Books");

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
                    { new Guid("0582362a-ad07-4165-992e-0b2fbad7a784"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439123656i/1029657.jpg", "9781840467321", "Sword of the Samurai" },
                    { new Guid("0779fb7c-13e2-4cc8-8601-db193ba2142b"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328038532i/1129804.jpg", "9780140318296", "Scorpion Swamp" },
                    { new Guid("08c1122f-efe0-4db0-a2a7-72ca220a557e"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121633i/1261180.jpg", "9780440977087", "Seas of Blood" },
                    { new Guid("1a5b1837-37d2-459c-9804-ff85667fa81e"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1181233137i/1129656.jpg", "9780140316032 ", "The Citadel of Chaos" },
                    { new Guid("38d774c5-2564-46f4-a512-794f713d5e06"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1344077625i/1261601.jpg", "9780140321524", "Robot Commando" },
                    { new Guid("48a1d170-479c-48d4-9380-3c6b03fadc19"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1457004279i/1261049.jpg", "9780140318319", "House of Hell" },
                    { new Guid("4a902e83-97bd-4bf4-9a8b-7f6253e52dc3"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1357726081i/17228871.jpg", "9781840465525", "Starship Traveller" },
                    { new Guid("4d9ad344-de66-4c0d-bc29-f5ad1607ba49"), "Ian Livingstone", "https://cybeswebsite.com/wp-content/uploads/2019/01/Figfan13n-186x300.jpg", "9780140317107", "Freeway Fighter" },
                    { new Guid("4f83118d-1504-4129-a3de-810ad4d22941"), "Mark Smith & Jamie Thomson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125202i/26067637.jpg", "9781840465662", "Talisman of Death" },
                    { new Guid("5491cf7a-2350-4139-9c26-3ae1d997bdd0"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439111136i/26066685.jpg", "9780140317435", "Island of the Lizard King" },
                    { new Guid("559b2f9e-3561-4b48-b862-b06847a09c4c"), "Steve Jackson", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1188764984i/1817973.jpg", "9781840465273", "Appointment with F.E.A.R." },
                    { new Guid("58a917a1-88c5-4c43-918f-9ceb1ff74948"), "Ian Livingstone", "https://static.wikia.nocookie.net/fightingfantasy/images/1/14/21_11.jpg/revision/latest/scale-to-width-down/1000?cb=20191223064046", "9780140320398", "Trial of Champions" },
                    { new Guid("598013ce-4e03-49b7-afe0-794c751c44fe"), "Andrew Chapman", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124891i/26067557.jpg", "9780440981497", "Space Assassin" },
                    { new Guid("7abdd394-64c1-46fe-867c-0b2e36472fd2"), "Andrew Chapman", "https://static.wikia.nocookie.net/fightingfantasy/images/e/ee/15_06.jpg/revision/latest/scale-to-width-down/1000?cb=20191223080002", "9780440974079", "The Rings of Kether" },
                    { new Guid("8fd2f9f3-4806-4c39-a480-c43c5c5f1908"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121250i/26067291.jpg", "9781840465280", "Temple of Terror" },
                    { new Guid("b2e34f84-33eb-4478-8bc7-3062de0071c2"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1177021348i/675314.jpg", "9780140317084", "Deathtrap Dungeon" },
                    { new Guid("b76ab77a-ee7a-46f5-b6da-ca1186c6b8dd"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110513i/26066654.jpg", "9781840464290", "The Forest of Doom" },
                    { new Guid("c175a214-0fbe-4ce0-a2ff-b1cf3f6aba32"), "Robin Waterfield", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1232604646i/6123272.jpg", "99780140319521", "Rebel Planet" },
                    { new Guid("c62ea848-a5fc-4229-995e-399742c58dc4"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124598i/26067514.jpg", "9780440918431", "Demons of the Deep" },
                    { new Guid("e001ff0b-0a21-4a93-97b9-bdd9d7175a40"), "Steve Jackson & Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110049i/26066622.jpg", "9780743475112", "The Warlock of Firetop Mountain" },
                    { new Guid("f2486bc9-9547-4080-88f6-81a4ab2cbeef"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125616i/26067773.jpg", "9780140318302", "Caverns of the Snow Witch" },
                    { new Guid("fe242287-3ddf-4fe3-850b-162219a22706"), "Ian Livingstone", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439126001i/26067801.jpg", "9780140316452", "City of Thieves" }
                });
        }
    }
}
