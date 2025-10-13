using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                    table.UniqueConstraint("AK_languages_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GoogleId = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "character varying(2083)", maxLength: 2083, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.UniqueConstraint("AK_users_GoogleId", x => x.GoogleId);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    CoverPath = table.Column<string>(type: "character varying(2083)", maxLength: 2083, nullable: true),
                    LanguageId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_books_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<short>(type: "smallint", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chapters_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "likes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likes", x => new { x.UserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_likes_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_likes_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "audios",
                columns: table => new
                {
                    ChapterId = table.Column<int>(type: "integer", nullable: false),
                    AudioUrl = table.Column<string>(type: "character varying(2083)", maxLength: 2083, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audios", x => x.ChapterId);
                    table.ForeignKey(
                        name: "FK_audios_chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "paragraphs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderNumber = table.Column<short>(type: "smallint", nullable: false),
                    Text = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    ImageUrl = table.Column<string>(type: "character varying(2083)", maxLength: 2083, nullable: false),
                    StartTimeMs = table.Column<int>(type: "integer", nullable: false),
                    EndTimeMs = table.Column<int>(type: "integer", nullable: false),
                    ChapterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paragraphs", x => x.Id);
                    table.UniqueConstraint("AK_paragraphs_ChapterId_OrderNumber", x => new { x.ChapterId, x.OrderNumber });
                    table.ForeignKey(
                        name: "FK_paragraphs_chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "iv", "Invariant Language (Invariant Country)" },
                    { 2, "aa", "Afar" },
                    { 3, "af", "Afrikaans" },
                    { 4, "ak", "Akan" },
                    { 5, "am", "Amharic" },
                    { 6, "ar", "Arabic" },
                    { 7, "as", "Assamese" },
                    { 8, "az", "Azerbaijani" },
                    { 11, "ba", "Bashkir" },
                    { 12, "be", "Belarusian" },
                    { 13, "bg", "Bulgarian" },
                    { 14, "bm", "Bamanankan" },
                    { 15, "bn", "Bangla" },
                    { 16, "bo", "Tibetan" },
                    { 17, "br", "Breton" },
                    { 18, "bs", "Bosnian" },
                    { 21, "ca", "Catalan" },
                    { 22, "ce", "Chechen" },
                    { 23, "co", "Corsican" },
                    { 24, "cs", "Czech" },
                    { 25, "cu", "Church Slavic" },
                    { 26, "cy", "Welsh" },
                    { 27, "da", "Danish" },
                    { 28, "de", "German" },
                    { 29, "dv", "Divehi" },
                    { 30, "dz", "Dzongkha" },
                    { 31, "ee", "Ewe" },
                    { 32, "el", "Greek" },
                    { 33, "en", "English" },
                    { 34, "eo", "Esperanto" },
                    { 35, "es", "Spanish" },
                    { 36, "et", "Estonian" },
                    { 37, "eu", "Basque" },
                    { 38, "fa", "Persian" },
                    { 39, "ff", "Fulah" },
                    { 41, "fi", "Finnish" },
                    { 42, "fo", "Faroese" },
                    { 43, "fr", "French" },
                    { 44, "fy", "Western Frisian" },
                    { 45, "ga", "Irish" },
                    { 46, "gd", "Scottish Gaelic" },
                    { 47, "gl", "Galician" },
                    { 48, "gn", "Guarani" },
                    { 49, "gu", "Gujarati" },
                    { 50, "gv", "Manx" },
                    { 51, "ha", "Hausa" },
                    { 52, "he", "Hebrew" },
                    { 53, "hi", "Hindi" },
                    { 54, "hr", "Croatian" },
                    { 55, "hu", "Hungarian" },
                    { 56, "hy", "Armenian" },
                    { 57, "ia", "Interlingua" },
                    { 58, "id", "Indonesian" },
                    { 59, "ig", "Igbo" },
                    { 60, "ii", "Yi" },
                    { 61, "is", "Icelandic" },
                    { 62, "it", "Italian" },
                    { 63, "iu", "Inuktitut" },
                    { 65, "ja", "Japanese" },
                    { 66, "jv", "Javanese" },
                    { 67, "ka", "Georgian" },
                    { 68, "ki", "Kikuyu" },
                    { 69, "kk", "Kazakh" },
                    { 70, "kl", "Kalaallisut" },
                    { 71, "km", "Khmer" },
                    { 72, "kn", "Kannada" },
                    { 73, "ko", "Korean" },
                    { 74, "ks", "Kashmiri" },
                    { 75, "kw", "Cornish" },
                    { 76, "ky", "Kyrgyz" },
                    { 77, "lb", "Luxembourgish" },
                    { 78, "lg", "Ganda" },
                    { 79, "ln", "Lingala" },
                    { 80, "lo", "Lao" },
                    { 81, "lt", "Lithuanian" },
                    { 82, "lu", "Luba-Katanga" },
                    { 83, "lv", "Latvian" },
                    { 84, "mg", "Malagasy" },
                    { 85, "mi", "Maori" },
                    { 86, "mk", "Macedonian" },
                    { 87, "ml", "Malayalam" },
                    { 88, "mn", "Mongolian" },
                    { 90, "mr", "Marathi" },
                    { 91, "ms", "Malay" },
                    { 92, "mt", "Maltese" },
                    { 93, "my", "Burmese" },
                    { 94, "nb", "Norwegian Bokmål" },
                    { 95, "nd", "North Ndebele" },
                    { 96, "ne", "Nepali" },
                    { 97, "nl", "Dutch" },
                    { 98, "nn", "Norwegian Nynorsk" },
                    { 99, "nr", "South Ndebele" },
                    { 100, "oc", "Occitan" },
                    { 101, "om", "Oromo" },
                    { 102, "or", "Odia" },
                    { 103, "os", "Ossetic" },
                    { 104, "pa", "Punjabi" },
                    { 107, "pl", "Polish" },
                    { 108, "ps", "Pashto" },
                    { 109, "pt", "Portuguese" },
                    { 110, "qu", "Quechua" },
                    { 111, "rm", "Romansh" },
                    { 112, "rn", "Rundi" },
                    { 113, "ro", "Romanian" },
                    { 114, "ru", "Russian" },
                    { 115, "rw", "Kinyarwanda" },
                    { 116, "sa", "Sanskrit" },
                    { 117, "sd", "Sindhi" },
                    { 118, "se", "Northern Sami" },
                    { 119, "sg", "Sango" },
                    { 120, "si", "Sinhala" },
                    { 121, "sk", "Slovak" },
                    { 122, "sl", "Slovenian" },
                    { 123, "sn", "Shona" },
                    { 124, "so", "Somali" },
                    { 125, "sq", "Albanian" },
                    { 126, "sr", "Serbian" },
                    { 129, "ss", "siSwati" },
                    { 130, "st", "Sesotho" },
                    { 131, "sv", "Swedish" },
                    { 132, "sw", "Kiswahili" },
                    { 133, "ta", "Tamil" },
                    { 134, "te", "Telugu" },
                    { 135, "tg", "Tajik" },
                    { 136, "th", "Thai" },
                    { 137, "ti", "Tigrinya" },
                    { 138, "tk", "Turkmen" },
                    { 139, "tn", "Setswana" },
                    { 140, "to", "Tongan" },
                    { 141, "tr", "Turkish" },
                    { 142, "ts", "Xitsonga" },
                    { 143, "tt", "Tatar" },
                    { 144, "ug", "Uyghur" },
                    { 145, "uk", "Ukrainian" },
                    { 146, "ur", "Urdu" },
                    { 147, "uz", "Uzbek" },
                    { 151, "ve", "Venda" },
                    { 152, "vi", "Vietnamese" },
                    { 153, "vo", "Volapük" },
                    { 154, "wo", "Wolof" },
                    { 155, "xh", "isiXhosa" },
                    { 156, "yi", "Yiddish" },
                    { 157, "yo", "Yoruba" },
                    { 158, "zh", "Chinese" },
                    { 161, "zu", "isiZulu" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_LanguageId",
                table: "books",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_chapters_BookId",
                table: "chapters",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_likes_BookId",
                table: "likes",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_NormalizedEmail",
                table: "users",
                column: "NormalizedEmail",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "audios");

            migrationBuilder.DropTable(
                name: "likes");

            migrationBuilder.DropTable(
                name: "paragraphs");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "chapters");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
