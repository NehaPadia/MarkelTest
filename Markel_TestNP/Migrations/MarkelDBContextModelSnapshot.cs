﻿// <auto-generated />
using System;
using Markel_TestNP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Markel_TestNP.Migrations
{
    [DbContext(typeof(MarkelDBContext))]
    partial class MarkelDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Markel_TestNP.Models.ContactUsResponse", b =>
                {
                    b.Property<int>("ResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AnsweredDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("varchar(400)")
                        .HasMaxLength(400)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<DateTime>("ResponseDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ResponseId");

                    b.ToTable("ContactUsResponse");
                });

            modelBuilder.Entity("Markel_TestNP.Models.PageContent", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("MenuText")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PageUrl")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("TemplateKey")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("PageId");

                    b.ToTable("PageContent");

                    b.HasData(
                        new
                        {
                            PageId = 1,
                            Body = "",
                            ImageUrl = "/images/fashion_banner.jpg",
                            MenuText = "Home",
                            PageUrl = "/Home/Index",
                            TemplateKey = "_Fashion",
                            Title = "Home"
                        },
                        new
                        {
                            PageId = 2,
                            Body = "",
                            ImageUrl = "/images/article_bg.jpg",
                            MenuText = "Content",
                            PageUrl = "/Home/Content",
                            TemplateKey = "_Layout",
                            Title = "Content"
                        },
                        new
                        {
                            PageId = 3,
                            Body = "",
                            ImageUrl = "/images/contactus_banner.jpg",
                            MenuText = "Contact Us",
                            PageUrl = "/Home/ContactUs",
                            TemplateKey = "_Intro",
                            Title = "Contact Us"
                        });
                });

            modelBuilder.Entity("Markel_TestNP.Models.PageLink", b =>
                {
                    b.Property<int>("PageId")
                        .HasColumnType("int");

                    b.Property<int>("LinkedPageId")
                        .HasColumnType("int");

                    b.HasKey("PageId", "LinkedPageId")
                        .HasName("PK__PageLink__93F732608857C75B");

                    b.ToTable("PageLink");
                });

            modelBuilder.Entity("Markel_TestNP.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("AvailableTo")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AvailableFrom = new DateTime(2022, 1, 25, 0, 15, 23, 896, DateTimeKind.Local).AddTicks(6646),
                            AvailableTo = new DateTime(2022, 8, 3, 0, 15, 23, 939, DateTimeKind.Local).AddTicks(8139),
                            Description = "Get all-day glow without the weight with Max Factor's Facefinity Highlighter. Long-lasting with an ultra weightless, seamless powder finish for a flattering healthy glow. The silky-light texture provides a super blendable finish and a mistake proof application that suits all skin tones and an all day illumination.",
                            GroupId = 1,
                            ImageUrl = "/images/product1.jpeg",
                            IsActive = true,
                            Name = "FACEFINITY POWDER HIGHLIGHTER"
                        },
                        new
                        {
                            ProductId = 2,
                            AvailableFrom = new DateTime(2022, 1, 26, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(573),
                            AvailableTo = new DateTime(2022, 8, 13, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(632),
                            Description = "Introducing the new quick dry nail colour from Max Factor, Masterpiece Xpress Quick Dry. This high performing nail polish dries in as little as 60 seconds, perfect for the on the go, busy person who doesn’t have time to waste! 1 stroke, 1 coat and you’re out the door!Max Factor Masterpiece Xpress Quick Dry allows you to complete your mani in record time with its fast drying formula! With 12 vibrant, high - shine colours, from Nude’itude to Coral Me you’re bound to find the shade of your dreams.",
                            GroupId = 1,
                            ImageUrl = "/images/product2.jpeg",
                            IsActive = true,
                            Name = "MASTERPIECE XPRESS NAIL POLISH"
                        },
                        new
                        {
                            ProductId = 3,
                            AvailableFrom = new DateTime(2022, 1, 17, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(688),
                            AvailableTo = new DateTime(2022, 11, 11, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(703),
                            Description = "Max Factor Nude Palette is available in three colourful ultra-versatile and universally flattering eye contouring palettes. Each one features 8 perfectly paired shades so you can master the most glamorous nude eye look.  The perfectly combined eyeshadows range from pale to deep tones and allow you to contour your eyes in endless combinations - from a daily nude to a subtle smokey eye, the possibilities are truly infinite! The silky smooth formula is soft and velvety with more pigment for richer, more intense colour. It blends precisely due to the dual-tip applicator. It allows you to build and build to your heart's content, creating matte, shimmery or sparkly finishes.",
                            GroupId = 1,
                            ImageUrl = "/images/product3.jpeg",
                            IsActive = true,
                            Name = "MASTERPIECE NUDE EYESHADOW PALETTE"
                        },
                        new
                        {
                            ProductId = 4,
                            AvailableFrom = new DateTime(2022, 1, 25, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(714),
                            AvailableTo = new DateTime(2023, 1, 10, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(723),
                            Description = "Get the effect of false lashes without the falsies with the cult-classic, False Lash Effect Mascara. Renowned for doubling the thickness of eyelashes thanks to the Liquid Lash formula that volumises lashes and the bold brush that coats every single lash.",
                            GroupId = 1,
                            ImageUrl = "/images/product4.jpeg",
                            IsActive = true,
                            Name = "FALSE LASH EFFECT MASCARA"
                        },
                        new
                        {
                            ProductId = 5,
                            AvailableFrom = new DateTime(2022, 1, 25, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(735),
                            AvailableTo = new DateTime(2022, 8, 10, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(745),
                            Description = "The secret's out. If you want to know how to get long eyelashes and sumptuous volume, prep for a fuller flutter with False Lash Effect Max Out Eyelash Primer. Simply glide the iconic, super-volumising False Lash Effect brush through bare lashes, and they'll be coated in intensifying blue micropigments that make eyelashes look darker and eyes look brighter. ",
                            GroupId = 1,
                            ImageUrl = "/images/product5.jpeg",
                            IsActive = true,
                            Name = "FALSE LASH EFFECT MAX OUT PRIMER"
                        },
                        new
                        {
                            ProductId = 6,
                            AvailableFrom = new DateTime(2021, 10, 27, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(756),
                            AvailableTo = new DateTime(2022, 12, 21, 0, 15, 23, 940, DateTimeKind.Local).AddTicks(767),
                            Description = "Get your eyebrows looking flawless with the Brow Contouring Kit. Whether you’re looking to create Instagram-ready angles or natural-looking definition, use the brow-perfecting kit to sculpt and define in an instant. Featuring three shades to suit every brow type and a highlighter to lift your arches, the baked powders are silky and easy-to-blend, delivering even colour and a softly matte finish every time.",
                            GroupId = 1,
                            ImageUrl = "/images/product6.jpeg",
                            IsActive = true,
                            Name = "BROW CONTOURING KIT"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
