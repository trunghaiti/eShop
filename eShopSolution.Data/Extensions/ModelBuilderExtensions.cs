using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description page of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category() {Id = 1, IsShowOnHome = true, ParentId = null, ShortOrder = 1, Status = Enums.Status.Active},
                new Category() {Id = 2, IsShowOnHome = true,ParentId = null,ShortOrder = 2,Status = Enums.Status.Active}
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men shirt", LanguageId = "en-US", SeoAlias = "ao-nam", SeoDescription = "The shirt product for men", SeoTitle = "The shirt product for men" },
                new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women shirt", LanguageId = "en-US", SeoAlias = "ao-nu", SeoDescription = "The shirt product for women", SeoTitle = "The shirt product for women" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, CreatedDate = DateTime.Now, OriginalPrice = 100000, Price = 200000, Stock = 0, ViewCount = 0}
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation() {Id = 1, ProductId = 1, Name = "Áo sơ mi nam trắng", LanguageId = "vi-VN", SeoAlias = "ao-so-mi-nam-trang", SeoDescription = "Áo sơ mi nam trắng", SeoTitle = "Áo sơ mi nam trắng", Detail = "Mô tả sản phẩm", Description = "" },
                new ProductTranslation() {Id = 2, ProductId = 1, Name = "Men T-shirt", LanguageId = "en-US", SeoAlias = "men-t-shirt", SeoDescription = "The shirt product for men", SeoTitle = "The shirt product for men", Detail = "Description of product", Description = "" }
                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { CategoryId = 1, ProductId = 1 }
                );
        }
    }
}
