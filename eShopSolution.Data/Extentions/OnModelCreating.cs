using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
    public static class OnModelCreating
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { 
                   Key = "HomeTitle", 
                   Value = "this is home of eShop"
               },
               new AppConfig() { 
                   Key = "HomeKeyword", 
                   Value = "this is HomeKeyword of eShop"
               },
               new AppConfig() { 
                   Key = "HomeDescription", 
                   Value = "this is HomeDescription of eShop" 
               }
               );

            modelBuilder.Entity<Language>().HasData(
                    new Language() {
                        Id = "vi-VN",
                        Name = "Tiếng việt", 
                        IsDefault = true 
                    },
                    new Language() { 
                        Id = "en-US", 
                        Name = "English",
                        IsDefault = false 
                    }
                );


            modelBuilder.Entity<Category>().HasData(
              new Category() { 
                  Id=1,
                  IsShowOnHome=true,
                  ParentId=null,
                  SortOrder=1,
                  Status=Enums.Status.Active
              },
              new Category()
              {
                  Id=2,
                  IsShowOnHome = true,
                  ParentId = null,
                  SortOrder = 2,
                  Status = Enums.Status.Active

              }

              );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation()
                  {
                      Id=1,
                      CategoryId=1,
                      Name = "Áo Nam",
                      LanguageId = "vi-VN",
                      SeoAlias = "ao-nam",
                      SeoDescription = "Sản phẩm áo thời trang nam",
                      SeoTitle = "Sản phẩm áo thời trang nam"
                  },
                      new CategoryTranslation()
                      {
                          Id=2,
                          CategoryId = 1,
                          Name = "Men Shirt",
                          LanguageId = "en-US",
                          SeoAlias = "men-sirt",
                          SeoDescription = "The sirt product for men",
                          SeoTitle = "The sirt product for men"
                      },
                       new CategoryTranslation()
                       {
                           Id=3,
                           CategoryId=2,
                           Name = "Áo Nữ",
                           LanguageId = "vi-VN",
                           SeoAlias = "ao-nu",
                           SeoDescription = "Sản phẩm áo thời trang nữ",
                           SeoTitle = "Sản phẩm áo thời trang nữ"
                       },
                      new CategoryTranslation()
                      {
                          Id=4,
                          CategoryId=2,
                          Name = "Woment Shirt",
                          LanguageId = "en-US",
                          SeoAlias = "woment-sirt",
                          SeoDescription = "The sirt product for Woment",
                          SeoTitle = "The sirt product for Woment"
                      }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id=1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 20000,
                    Stock = 0,
                    ViewCount = 0,
                }
                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                    
                        new ProductTranslation(){
                            Id=1,
                            ProductId=1,
                            Name="Áo Nam",
                            LanguageId="vi-VN",
                            SeoAlias="ao-nam",
                            SeoDescription="Sản phẩm áo thời trang nam",
                            SeoTitle="Sản phẩm áo thời trang nam",
                            Details="test"
                        },
                        new ProductTranslation(){
                            Id=2,
                            ProductId=1,
                            Name="Men Shirt",
                            LanguageId="en-US",
                            SeoAlias="men-sirt",
                            SeoDescription="The sirt product for men",
                            SeoTitle="The sirt product for men",
                            Description=""
                        }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                     new ProductInCategory()
                     {
                         ProductId = 1,
                         CategoryId=1
                     }
                );
        }
    }
}
