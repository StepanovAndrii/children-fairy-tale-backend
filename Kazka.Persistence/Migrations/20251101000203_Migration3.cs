using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kazka.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_paragraphs_ChapterId_OrderNumber",
                table: "paragraphs");

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "paragraphs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "languages");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "chapters",
                newName: "Order");

            migrationBuilder.AlterColumn<long>(
                name: "Age",
                table: "users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "users",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "StartTimeMs",
                table: "paragraphs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "paragraphs",
                type: "character varying(2083)",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(2083)",
                oldMaxLength: 2083);

            migrationBuilder.AlterColumn<long>(
                name: "EndTimeMs",
                table: "paragraphs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "ChapterId",
                table: "paragraphs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "paragraphs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ParagraphOrder",
                table: "paragraphs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "BookId",
                table: "likes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "likes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "languages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "BookId",
                table: "chapters",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "chapters",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "chapters",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Categories",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "LanguageId",
                table: "books",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "books",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "books",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt1",
                table: "books",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "ChapterId",
                table: "audios",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_paragraphs_ChapterId_ParagraphOrder",
                table: "paragraphs",
                columns: new[] { "ChapterId", "ParagraphOrder" });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1L, "aa" },
                    { 2L, "af" },
                    { 3L, "agq" },
                    { 4L, "ak" },
                    { 5L, "am" },
                    { 6L, "ar" },
                    { 7L, "arn" },
                    { 8L, "as" },
                    { 9L, "asa" },
                    { 10L, "ast" },
                    { 11L, "az" },
                    { 14L, "ba" },
                    { 15L, "bas" },
                    { 16L, "be" },
                    { 17L, "bem" },
                    { 18L, "bez" },
                    { 19L, "bg" },
                    { 20L, "bm" },
                    { 21L, "bn" },
                    { 22L, "bo" },
                    { 23L, "br" },
                    { 24L, "brx" },
                    { 25L, "bs" },
                    { 28L, "byn" },
                    { 29L, "ca" },
                    { 30L, "ccp" },
                    { 31L, "ce" },
                    { 32L, "ceb" },
                    { 33L, "cgg" },
                    { 34L, "chr" },
                    { 35L, "ckb" },
                    { 36L, "co" },
                    { 37L, "cs" },
                    { 38L, "cu" },
                    { 39L, "cy" },
                    { 40L, "da" },
                    { 41L, "dav" },
                    { 42L, "de" },
                    { 43L, "dje" },
                    { 44L, "dsb" },
                    { 45L, "dua" },
                    { 46L, "dv" },
                    { 47L, "dyo" },
                    { 48L, "dz" },
                    { 49L, "ebu" },
                    { 50L, "ee" },
                    { 51L, "el" },
                    { 52L, "en" },
                    { 53L, "eo" },
                    { 54L, "es" },
                    { 55L, "et" },
                    { 56L, "eu" },
                    { 57L, "ewo" },
                    { 58L, "fa" },
                    { 59L, "ff" },
                    { 61L, "fi" },
                    { 62L, "fil" },
                    { 63L, "fo" },
                    { 64L, "fr" },
                    { 65L, "fur" },
                    { 66L, "fy" },
                    { 67L, "ga" },
                    { 68L, "gd" },
                    { 69L, "gl" },
                    { 70L, "gn" },
                    { 71L, "gsw" },
                    { 72L, "gu" },
                    { 73L, "guz" },
                    { 74L, "gv" },
                    { 75L, "ha" },
                    { 76L, "haw" },
                    { 77L, "he" },
                    { 78L, "hi" },
                    { 79L, "hr" },
                    { 80L, "hsb" },
                    { 81L, "hu" },
                    { 82L, "hy" },
                    { 83L, "ia" },
                    { 84L, "id" },
                    { 85L, "ig" },
                    { 86L, "ii" },
                    { 87L, "is" },
                    { 88L, "it" },
                    { 89L, "iu" },
                    { 91L, "ja" },
                    { 92L, "jgo" },
                    { 93L, "jmc" },
                    { 94L, "jv" },
                    { 95L, "ka" },
                    { 96L, "kab" },
                    { 97L, "kam" },
                    { 98L, "kde" },
                    { 99L, "kea" },
                    { 100L, "khq" },
                    { 101L, "ki" },
                    { 102L, "kk" },
                    { 103L, "kkj" },
                    { 104L, "kl" },
                    { 105L, "kln" },
                    { 106L, "km" },
                    { 107L, "kn" },
                    { 108L, "ko" },
                    { 109L, "kok" },
                    { 110L, "ks" },
                    { 111L, "ksb" },
                    { 112L, "ksf" },
                    { 113L, "ksh" },
                    { 114L, "kw" },
                    { 115L, "ky" },
                    { 116L, "lag" },
                    { 117L, "lb" },
                    { 118L, "lg" },
                    { 119L, "lkt" },
                    { 120L, "ln" },
                    { 121L, "lo" },
                    { 122L, "lrc" },
                    { 123L, "lt" },
                    { 124L, "lu" },
                    { 125L, "luo" },
                    { 126L, "luy" },
                    { 127L, "lv" },
                    { 128L, "mas" },
                    { 129L, "mer" },
                    { 130L, "mfe" },
                    { 131L, "mg" },
                    { 132L, "mgh" },
                    { 133L, "mgo" },
                    { 134L, "mi" },
                    { 135L, "mk" },
                    { 136L, "ml" },
                    { 137L, "mn" },
                    { 139L, "moh" },
                    { 140L, "mr" },
                    { 141L, "ms" },
                    { 142L, "mt" },
                    { 143L, "mua" },
                    { 144L, "my" },
                    { 145L, "mzn" },
                    { 146L, "naq" },
                    { 147L, "nb" },
                    { 148L, "nd" },
                    { 149L, "nds" },
                    { 150L, "ne" },
                    { 151L, "nl" },
                    { 152L, "nmg" },
                    { 153L, "nn" },
                    { 154L, "nnh" },
                    { 155L, "nqo" },
                    { 156L, "nr" },
                    { 157L, "nso" },
                    { 158L, "nus" },
                    { 159L, "nyn" },
                    { 160L, "oc" },
                    { 161L, "om" },
                    { 162L, "or" },
                    { 163L, "os" },
                    { 164L, "pa" },
                    { 167L, "pl" },
                    { 168L, "prg" },
                    { 169L, "ps" },
                    { 170L, "pt" },
                    { 171L, "qu" },
                    { 172L, "quc" },
                    { 173L, "rm" },
                    { 174L, "rn" },
                    { 175L, "ro" },
                    { 176L, "rof" },
                    { 177L, "ru" },
                    { 178L, "rw" },
                    { 179L, "rwk" },
                    { 180L, "sa" },
                    { 181L, "sah" },
                    { 182L, "saq" },
                    { 183L, "sbp" },
                    { 184L, "sd" },
                    { 185L, "se" },
                    { 186L, "seh" },
                    { 187L, "ses" },
                    { 188L, "sg" },
                    { 189L, "shi" },
                    { 192L, "si" },
                    { 193L, "sk" },
                    { 194L, "sl" },
                    { 195L, "sma" },
                    { 196L, "smj" },
                    { 197L, "smn" },
                    { 198L, "sms" },
                    { 199L, "sn" },
                    { 200L, "so" },
                    { 201L, "sq" },
                    { 202L, "sr" },
                    { 205L, "ss" },
                    { 206L, "ssy" },
                    { 207L, "st" },
                    { 208L, "sv" },
                    { 209L, "sw" },
                    { 210L, "syr" },
                    { 211L, "ta" },
                    { 212L, "te" },
                    { 213L, "teo" },
                    { 214L, "tg" },
                    { 215L, "th" },
                    { 216L, "ti" },
                    { 217L, "tig" },
                    { 218L, "tk" },
                    { 219L, "tn" },
                    { 220L, "to" },
                    { 221L, "tr" },
                    { 222L, "ts" },
                    { 223L, "tt" },
                    { 224L, "twq" },
                    { 225L, "tzm" },
                    { 226L, "ug" },
                    { 227L, "uk" },
                    { 228L, "ur" },
                    { 229L, "uz" },
                    { 233L, "vai" },
                    { 236L, "ve" },
                    { 237L, "vi" },
                    { 238L, "vo" },
                    { 239L, "vun" },
                    { 240L, "wae" },
                    { 241L, "wal" },
                    { 242L, "wo" },
                    { 243L, "xh" },
                    { 244L, "xog" },
                    { 245L, "yav" },
                    { 246L, "yi" },
                    { 247L, "yo" },
                    { 248L, "zgh" },
                    { 249L, "zh" },
                    { 252L, "zu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_paragraphs_ChapterId_ParagraphOrder",
                table: "paragraphs");

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DropColumn(
                name: "ParagraphOrder",
                table: "paragraphs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "chapters");

            migrationBuilder.DropColumn(
                name: "CreatedAt1",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "chapters",
                newName: "Number");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StartTimeMs",
                table: "paragraphs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "paragraphs",
                type: "character varying(2083)",
                maxLength: 2083,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(2083)",
                oldMaxLength: 2083,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndTimeMs",
                table: "paragraphs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ChapterId",
                table: "paragraphs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "paragraphs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<short>(
                name: "OrderNumber",
                table: "paragraphs",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "likes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "likes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "languages",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "languages",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "chapters",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "chapters",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "books",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "books",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "books",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ChapterId",
                table: "audios",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_paragraphs_ChapterId_OrderNumber",
                table: "paragraphs",
                columns: new[] { "ChapterId", "OrderNumber" });

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
        }
    }
}
