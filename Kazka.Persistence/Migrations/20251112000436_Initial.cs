using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kazka.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                    table.UniqueConstraint("AK_categories_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false)
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
                    Role = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Age = table.Column<byte>(type: "smallint", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "character varying(2083)", maxLength: 2083, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.UniqueConstraint("AK_users_GoogleId", x => x.GoogleId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "refresh_tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    HashedToken = table.Column<string>(type: "text", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsRevoked = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refresh_tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_refresh_tokens_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Order = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chapters_books_StoryId",
                        column: x => x.StoryId,
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
                name: "story_categories",
                columns: table => new
                {
                    StoryId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_story_categories", x => new { x.StoryId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_story_categories_books_StoryId",
                        column: x => x.StoryId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_story_categories_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "audios",
                columns: table => new
                {
                    ChapterId = table.Column<int>(type: "integer", nullable: false),
                    AudioPath = table.Column<string>(type: "character varying(2083)", maxLength: 2083, nullable: false)
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
                    ParagraphOrder = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    ImageUrl = table.Column<string>(type: "character varying(2083)", maxLength: 2083, nullable: true),
                    StartTimeMs = table.Column<int>(type: "integer", nullable: false),
                    EndTimeMs = table.Column<int>(type: "integer", nullable: false),
                    ChapterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paragraphs", x => x.Id);
                    table.UniqueConstraint("AK_paragraphs_ChapterId_ParagraphOrder", x => new { x.ChapterId, x.ParagraphOrder });
                    table.ForeignKey(
                        name: "FK_paragraphs_chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1, "aa" },
                    { 2, "af" },
                    { 3, "agq" },
                    { 4, "ak" },
                    { 5, "am" },
                    { 6, "ar" },
                    { 7, "arn" },
                    { 8, "as" },
                    { 9, "asa" },
                    { 10, "ast" },
                    { 11, "az" },
                    { 12, "ba" },
                    { 13, "bas" },
                    { 14, "be" },
                    { 15, "bem" },
                    { 16, "bez" },
                    { 17, "bg" },
                    { 18, "bm" },
                    { 19, "bn" },
                    { 20, "bo" },
                    { 21, "br" },
                    { 22, "brx" },
                    { 23, "bs" },
                    { 24, "byn" },
                    { 25, "ca" },
                    { 26, "ccp" },
                    { 27, "ce" },
                    { 28, "ceb" },
                    { 29, "cgg" },
                    { 30, "chr" },
                    { 31, "ckb" },
                    { 32, "co" },
                    { 33, "cs" },
                    { 34, "cu" },
                    { 35, "cy" },
                    { 36, "da" },
                    { 37, "dav" },
                    { 38, "de" },
                    { 39, "dje" },
                    { 40, "dsb" },
                    { 41, "dua" },
                    { 42, "dv" },
                    { 43, "dyo" },
                    { 44, "dz" },
                    { 45, "ebu" },
                    { 46, "ee" },
                    { 47, "el" },
                    { 48, "en" },
                    { 49, "eo" },
                    { 50, "es" },
                    { 51, "et" },
                    { 52, "eu" },
                    { 53, "ewo" },
                    { 54, "fa" },
                    { 55, "ff" },
                    { 56, "fi" },
                    { 57, "fil" },
                    { 58, "fo" },
                    { 59, "fr" },
                    { 60, "fur" },
                    { 61, "fy" },
                    { 62, "ga" },
                    { 63, "gd" },
                    { 64, "gl" },
                    { 65, "gn" },
                    { 66, "gsw" },
                    { 67, "gu" },
                    { 68, "guz" },
                    { 69, "gv" },
                    { 70, "ha" },
                    { 71, "haw" },
                    { 72, "he" },
                    { 73, "hi" },
                    { 74, "hr" },
                    { 75, "hsb" },
                    { 76, "hu" },
                    { 77, "hy" },
                    { 78, "ia" },
                    { 79, "id" },
                    { 80, "ig" },
                    { 81, "ii" },
                    { 82, "is" },
                    { 83, "it" },
                    { 84, "iu" },
                    { 85, "ja" },
                    { 86, "jgo" },
                    { 87, "jmc" },
                    { 88, "jv" },
                    { 89, "ka" },
                    { 90, "kab" },
                    { 91, "kam" },
                    { 92, "kde" },
                    { 93, "kea" },
                    { 94, "khq" },
                    { 95, "ki" },
                    { 96, "kk" },
                    { 97, "kkj" },
                    { 98, "kl" },
                    { 99, "kln" },
                    { 100, "km" },
                    { 101, "kn" },
                    { 102, "ko" },
                    { 103, "kok" },
                    { 104, "ks" },
                    { 105, "ksb" },
                    { 106, "ksf" },
                    { 107, "ksh" },
                    { 108, "kw" },
                    { 109, "ky" },
                    { 110, "lag" },
                    { 111, "lb" },
                    { 112, "lg" },
                    { 113, "lkt" },
                    { 114, "ln" },
                    { 115, "lo" },
                    { 116, "lrc" },
                    { 117, "lt" },
                    { 118, "lu" },
                    { 119, "luo" },
                    { 120, "luy" },
                    { 121, "lv" },
                    { 122, "mas" },
                    { 123, "mer" },
                    { 124, "mfe" },
                    { 125, "mg" },
                    { 126, "mgh" },
                    { 127, "mgo" },
                    { 128, "mi" },
                    { 129, "mk" },
                    { 130, "ml" },
                    { 131, "mn" },
                    { 132, "moh" },
                    { 133, "mr" },
                    { 134, "ms" },
                    { 135, "mt" },
                    { 136, "mua" },
                    { 137, "my" },
                    { 138, "mzn" },
                    { 139, "naq" },
                    { 140, "nb" },
                    { 141, "nd" },
                    { 142, "nds" },
                    { 143, "ne" },
                    { 144, "nl" },
                    { 145, "nmg" },
                    { 146, "nn" },
                    { 147, "nnh" },
                    { 148, "nqo" },
                    { 149, "nr" },
                    { 150, "nso" },
                    { 151, "nus" },
                    { 152, "nyn" },
                    { 153, "oc" },
                    { 154, "om" },
                    { 155, "or" },
                    { 156, "os" },
                    { 157, "pa" },
                    { 158, "pl" },
                    { 159, "prg" },
                    { 160, "ps" },
                    { 161, "pt" },
                    { 162, "qu" },
                    { 163, "quc" },
                    { 164, "rm" },
                    { 165, "rn" },
                    { 166, "ro" },
                    { 167, "rof" },
                    { 168, "ru" },
                    { 169, "rw" },
                    { 170, "rwk" },
                    { 171, "sa" },
                    { 172, "sah" },
                    { 173, "saq" },
                    { 174, "sbp" },
                    { 175, "sd" },
                    { 176, "se" },
                    { 177, "seh" },
                    { 178, "ses" },
                    { 179, "sg" },
                    { 180, "shi" },
                    { 181, "si" },
                    { 182, "sk" },
                    { 183, "sl" },
                    { 184, "sma" },
                    { 185, "smj" },
                    { 186, "smn" },
                    { 187, "sms" },
                    { 188, "sn" },
                    { 189, "so" },
                    { 190, "sq" },
                    { 191, "sr" },
                    { 192, "ss" },
                    { 193, "ssy" },
                    { 194, "st" },
                    { 195, "sv" },
                    { 196, "sw" },
                    { 197, "syr" },
                    { 198, "ta" },
                    { 199, "te" },
                    { 200, "teo" },
                    { 201, "tg" },
                    { 202, "th" },
                    { 203, "ti" },
                    { 204, "tig" },
                    { 205, "tk" },
                    { 206, "tn" },
                    { 207, "to" },
                    { 208, "tr" },
                    { 209, "ts" },
                    { 210, "tt" },
                    { 211, "twq" },
                    { 212, "tzm" },
                    { 213, "ug" },
                    { 214, "uk" },
                    { 215, "ur" },
                    { 216, "uz" },
                    { 217, "vai" },
                    { 218, "ve" },
                    { 219, "vi" },
                    { 220, "vo" },
                    { 221, "vun" },
                    { 222, "wae" },
                    { 223, "wal" },
                    { 224, "wo" },
                    { 225, "xh" },
                    { 226, "xog" },
                    { 227, "yav" },
                    { 228, "yi" },
                    { 229, "yo" },
                    { 230, "zgh" },
                    { 231, "zh" },
                    { 232, "zu" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_books_LanguageId",
                table: "books",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_chapters_StoryId",
                table: "chapters",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_likes_BookId",
                table: "likes",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_refresh_tokens_UserId",
                table: "refresh_tokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_story_categories_CategoryId",
                table: "story_categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "users",
                column: "NormalizedEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "users",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "audios");

            migrationBuilder.DropTable(
                name: "likes");

            migrationBuilder.DropTable(
                name: "paragraphs");

            migrationBuilder.DropTable(
                name: "refresh_tokens");

            migrationBuilder.DropTable(
                name: "story_categories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "chapters");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
