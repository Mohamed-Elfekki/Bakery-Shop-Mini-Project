using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Data
{
    public static class ModelBuilderExtenstions
    {
        //Seed data
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "donuts",
                    Description = "great fluffy colorful donuts",
                    ImageName = "donuts.jpg",
                    Price = 1.99M
                },
                new Product
                {
                    Id = 2,
                    Name = "Cookies",
                    Description = "great fluffy colorful Cookies",
                    ImageName = "Cookies.jpg",
                    Price = 4.99M
                },
                new Product
                {
                    Id = 3,
                    Name = "FluffyCake",
                    Description = "great fluffy colorful FluffyCake",
                    ImageName = "FluffyCake.jpg",
                    Price = 2.49M
                },
                new Product
                {
                    Id = 4,
                    Name = "Lotus",
                    Description = "great Crispy colorful Lotus",
                    ImageName = "Lotus.jpg",
                    Price = 1.35M
                },
                new Product
                {
                    Id = 5,
                    Name = "Pain",
                    Description = "great fluffy colorful Pain",
                    ImageName = "Pain.jpg",
                    Price = 6.69M
                }
                );
            return modelBuilder;


        }

    }
}
