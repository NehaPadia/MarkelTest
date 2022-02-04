using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Markel_TestNP.Models
{
    public partial class MarkelDBContext : DbContext
    {
        public MarkelDBContext()
        {
        }

        public MarkelDBContext(DbContextOptions<MarkelDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactUsResponse> ContactUsResponse { get; set; }
        public virtual DbSet<PageContent> PageContent { get; set; }
        public virtual DbSet<PageLink> PageLink { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MarkelDB;Trusted_Connection=True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactUsResponse>(entity =>
            {
                entity.HasKey(e => e.ResponseId);

                entity.Property(e => e.AnsweredDate).HasColumnType("datetime");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
               
            });

            modelBuilder.Entity<PageContent>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.Property(e => e.Body)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MenuText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateKey)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);


                entity.HasData(new PageContent() { PageId = 1, MenuText = "Home", PageUrl = "/Home/Index", TemplateKey = "_Fashion", Body = "", Title = "Home", ImageUrl = "/images/fashion_banner.jpg" }
                , new PageContent() { PageId = 2, MenuText = "Content", PageUrl = "/Home/Content", TemplateKey = "_Layout", Body = "", Title = "Content", ImageUrl = "/images/article_bg.jpg" }
                , new PageContent() { PageId = 3, MenuText = "Contact Us", PageUrl = "/Home/ContactUs", TemplateKey = "_Intro", Body = "", Title = "Contact Us", ImageUrl = "/images/contactus_banner.jpg" });
            
            });

            modelBuilder.Entity<PageLink>(entity =>
            {
                entity.HasKey(e => new { e.PageId, e.LinkedPageId })
                    .HasName("PK__PageLink__93F732608857C75B");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.AvailableTo).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasData(new Product()
                {
                    ProductId = 1,
                    Name = "FACEFINITY POWDER HIGHLIGHTER",
                    Description = "Get all-day glow without the weight with Max Factor's Facefinity Highlighter. Long-lasting with an ultra weightless, seamless powder finish for a flattering healthy glow. The silky-light texture provides a super blendable finish and a mistake proof application that suits all skin tones and an all day illumination.",
                    IsActive = true,
                    GroupId = 1,
                    AvailableFrom = DateTime.Now.AddDays(-10),
                    AvailableTo = DateTime.Now.AddDays(180),
                    ImageUrl = "/images/product1.jpeg"
                }
             ,
             new Product()
             {
                 ProductId = 2,
                 Name = "MASTERPIECE XPRESS NAIL POLISH",
                 Description = "Introducing the new quick dry nail colour from Max Factor, Masterpiece Xpress Quick Dry. This high performing nail polish dries in as little as 60 seconds, perfect for the on the go, busy person who doesn’t have time to waste! 1 stroke, 1 coat and you’re out the door!" +
                    "Max Factor Masterpiece Xpress Quick Dry allows you to complete your mani in record time with its fast drying formula! With 12 vibrant, high - shine colours, from Nude’itude to Coral Me you’re bound to find the shade of your dreams.",
                 IsActive = true,
                 GroupId = 1,
                 AvailableFrom = DateTime.Now.AddDays(-9),
                 AvailableTo = DateTime.Now.AddDays(190),
                 ImageUrl = "/images/product2.jpeg"
             }
             , new Product()
             {
                 ProductId = 3,
                 Name = "MASTERPIECE NUDE EYESHADOW PALETTE",
                 Description = "Max Factor Nude Palette is available in three colourful ultra-versatile and universally flattering eye contouring palettes. Each one features 8 perfectly paired shades so you can master the most glamorous nude eye look.  The perfectly combined eyeshadows range from pale to deep tones and allow you to contour your eyes in endless combinations - from a daily nude to a subtle smokey eye, the possibilities are truly infinite! The silky smooth formula is soft and velvety with more pigment for richer, more intense colour. It blends precisely due to the dual-tip applicator. It allows you to build and build to your heart's content, creating matte, shimmery or sparkly finishes.",
                 IsActive = true,
                 GroupId = 1,
                 AvailableFrom = DateTime.Now.AddDays(-18),
                 AvailableTo = DateTime.Now.AddDays(280),
                 ImageUrl = "/images/product3.jpeg"
             }
             , new Product()
             {
                 ProductId = 4,
                 Name = "FALSE LASH EFFECT MASCARA",
                 Description = "Get the effect of false lashes without the falsies with the cult-classic, False Lash Effect Mascara. Renowned for doubling the thickness of eyelashes thanks to the Liquid Lash formula that volumises lashes and the bold brush that coats every single lash.",
                 IsActive = true,
                 GroupId = 1,
                 AvailableFrom = DateTime.Now.AddDays(-10),
                 AvailableTo = DateTime.Now.AddDays(340),
                 ImageUrl = "/images/product4.jpeg"
             }
             , new Product()
             {
                 ProductId = 5,
                 Name = "FALSE LASH EFFECT MAX OUT PRIMER",
                 Description = "The secret's out. If you want to know how to get long eyelashes and sumptuous volume, prep for a fuller flutter with False Lash Effect Max Out Eyelash Primer. Simply glide the iconic, super-volumising False Lash Effect brush through bare lashes, and they'll be coated in intensifying blue micropigments that make eyelashes look darker and eyes look brighter. ",
                 IsActive = true,
                 GroupId = 1,
                 AvailableFrom = DateTime.Now.AddDays(-10),
                 AvailableTo = DateTime.Now.AddDays(187),
                 ImageUrl = "/images/product5.jpeg"
             }
             , new Product()
             {
                 ProductId = 6,
                 Name = "BROW CONTOURING KIT",
                 Description = "Get your eyebrows looking flawless with the Brow Contouring Kit. Whether you’re looking to create Instagram-ready angles or natural-looking definition, use the brow-perfecting kit to sculpt and define in an instant. Featuring three shades to suit every brow type and a highlighter to lift your arches, the baked powders are silky and easy-to-blend, delivering even colour and a softly matte finish every time.",
                 IsActive = true,
                 GroupId = 1,
                 AvailableFrom = DateTime.Now.AddDays(-100),
                 AvailableTo = DateTime.Now.AddDays(320),
                 ImageUrl = "/images/product6.jpeg"
             }
             );

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
