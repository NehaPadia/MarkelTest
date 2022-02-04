using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Markel_TestNP.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUsResponse",
                columns: table => new
                {
                    ResponseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Subject = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Body = table.Column<string>(unicode: false, maxLength: 400, nullable: false),
                    AnsweredDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsResponse", x => x.ResponseId);
                });

            migrationBuilder.CreateTable(
                name: "PageContent",
                columns: table => new
                {
                    PageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateKey = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    PageUrl = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    MenuText = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Title = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Body = table.Column<string>(unicode: false, nullable: false),
                    ImageUrl = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageContent", x => x.PageId);
                });

            migrationBuilder.CreateTable(
                name: "PageLink",
                columns: table => new
                {
                    PageId = table.Column<int>(nullable: false),
                    LinkedPageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PageLink__93F732608857C75B", x => new { x.PageId, x.LinkedPageId });
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 1000, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AvailableFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    AvailableTo = table.Column<DateTime>(type: "datetime", nullable: true),
                    ImageUrl = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "PageContent",
                columns: new[] { "PageId", "Body", "ImageUrl", "MenuText", "PageUrl", "TemplateKey", "Title" },
                values: new object[,]
                {
                    { 1, "", "/images/fashion_banner.jpg", "Home", "/Home/Index", "_Fashion", "Home" },
                    { 2, "", "/images/article_bg.jpg", "Content", "/Home/Content", "_Layout", "Content" },
                    { 3, "", "/images/contactus_banner.jpg", "Contact Us", "/Home/ContactUs", "_Intro", "Contact Us" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "AvailableFrom", "AvailableTo", "Description", "GroupId", "ImageUrl", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 25, 0, 15, 23, 896, DateTimeKind.Local).AddTicks(6646), new DateTime(2022, 8, 3, 0, 15, 23, 939, DateTimeKind.Local).AddTicks(8139), "Get all-day glow without the weight with Max Factor's Facefinity Highlighter. Long-lasting with an ultra weightless, seamless powder finish for a flattering healthy glow. The silky-light texture provides a super blendable finish and a mistake proof application that suits all skin tones and an all day illumination.", 1, "/images/product1.jpeg", true, "FACEFINITY POWDER HIGHLIGHTER" },
                    { 2, new DateTime(2022, 1, 26, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(573), new DateTime(2022, 8, 13, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(632), "Introducing the new quick dry nail colour from Max Factor, Masterpiece Xpress Quick Dry. This high performing nail polish dries in as little as 60 seconds, perfect for the on the go, busy person who doesn’t have time to waste! 1 stroke, 1 coat and you’re out the door!Max Factor Masterpiece Xpress Quick Dry allows you to complete your mani in record time with its fast drying formula! With 12 vibrant, high - shine colours, from Nude’itude to Coral Me you’re bound to find the shade of your dreams.", 1, "/images/product2.jpeg", true, "MASTERPIECE XPRESS NAIL POLISH" },
                    { 3, new DateTime(2022, 1, 17, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(688), new DateTime(2022, 11, 11, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(703), "Max Factor Nude Palette is available in three colourful ultra-versatile and universally flattering eye contouring palettes. Each one features 8 perfectly paired shades so you can master the most glamorous nude eye look.  The perfectly combined eyeshadows range from pale to deep tones and allow you to contour your eyes in endless combinations - from a daily nude to a subtle smokey eye, the possibilities are truly infinite! The silky smooth formula is soft and velvety with more pigment for richer, more intense colour. It blends precisely due to the dual-tip applicator. It allows you to build and build to your heart's content, creating matte, shimmery or sparkly finishes.", 1, "/images/product3.jpeg", true, "MASTERPIECE NUDE EYESHADOW PALETTE" },
                    { 4, new DateTime(2022, 1, 25, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 1, 10, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(723), "Get the effect of false lashes without the falsies with the cult-classic, False Lash Effect Mascara. Renowned for doubling the thickness of eyelashes thanks to the Liquid Lash formula that volumises lashes and the bold brush that coats every single lash.", 1, "/images/product4.jpeg", true, "FALSE LASH EFFECT MASCARA" },
                    { 5, new DateTime(2022, 1, 25, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(735), new DateTime(2022, 8, 10, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(745), "The secret's out. If you want to know how to get long eyelashes and sumptuous volume, prep for a fuller flutter with False Lash Effect Max Out Eyelash Primer. Simply glide the iconic, super-volumising False Lash Effect brush through bare lashes, and they'll be coated in intensifying blue micropigments that make eyelashes look darker and eyes look brighter. ", 1, "/images/product5.jpeg", true, "FALSE LASH EFFECT MAX OUT PRIMER" },
                    { 6, new DateTime(2021, 10, 27, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(756), new DateTime(2022, 12, 21, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(767), "Get your eyebrows looking flawless with the Brow Contouring Kit. Whether you’re looking to create Instagram-ready angles or natural-looking definition, use the brow-perfecting kit to sculpt and define in an instant. Featuring three shades to suit every brow type and a highlighter to lift your arches, the baked powders are silky and easy-to-blend, delivering even colour and a softly matte finish every time.", 1, "/images/product6.jpeg", true, "BROW CONTOURING KIT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUsResponse");

            migrationBuilder.DropTable(
                name: "PageContent");

            migrationBuilder.DropTable(
                name: "PageLink");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
