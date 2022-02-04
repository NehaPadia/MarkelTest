using Markel_TestNP.Controllers;
using Markel_TestNP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace XUnitTestMarkel_NP
{
    public class ProductAPI
    {
        [Fact]
        public void ProductGetById()
        {
            var options = new DbContextOptionsBuilder<MarkelDBContext>().UseInMemoryDatabase(databaseName: "MarkelDB").Options;
            //mock data and see in memory db
            using (var context = new MarkelDBContext(options))
            {
                context.Product.AddRange(new Product()
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
             });

                context.SaveChanges();

            }

            //now test api
            using (var context = new MarkelDBContext(options))
            {
                ProductsApiController controller = new ProductsApiController(context);
                var result = (controller.GetProductById(1)).Result;
                var actualResult = result.Value;

                Assert.Equal("FACEFINITY POWDER HIGHLIGHTER", actualResult.Name);
                Assert.Equal(1, actualResult.GroupId);
                Assert.Equal(1, actualResult.ProductId);
                Assert.True(actualResult.IsActive);

            }

        }
    }

}
