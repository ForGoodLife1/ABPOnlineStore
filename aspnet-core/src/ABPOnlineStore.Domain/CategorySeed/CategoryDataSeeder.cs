using ABPOnlineStore.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ABPOnlineStore.CategorySeed
{
    public class CategoryDataSeeder : IDataSeedContributor ,ITransientDependency
    {
        private readonly IRepository<Category, int> categoriesRepository;

        public CategoryDataSeeder(IRepository<Category,int> CategoriesRepository)
        {
            categoriesRepository=CategoriesRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(!await categoriesRepository.AnyAsync())
            {
                var categories = new List<Category>
           {
               new Category(id:1,

               nameAr:"أطعمه ومشروبات",
               nameEn:"Food & Drinks",
               descriptionAr :"جميع نواع الاطعمه والمشروبات",
               descriptionEn : "All of Food And Drinks"

               ),
               new Category(id:2,

               nameAr:"فواكه وخضروات",
               nameEn:"vigtables and Fruits",
               descriptionAr :"جميع نواع الاطعمه والمشروبات",
               descriptionEn : "All of Food And Drinks"),

               new Category(id:3,

               nameAr:"اجهزه كهربائيه",
               nameEn:"Food & Drinks",
               descriptionAr :"جميع نواع الاطعمه والمشروبات",
               descriptionEn : "All of Food And Drinks"),

               new Category(id:4,

               nameAr:"ملابس",
               nameEn:"Food & Drinks",
               descriptionAr :"جميع نواع الاطعمه والمشروبات",
               descriptionEn : "All of Food And Drinks"),


           };

                await this.categoriesRepository.InsertManyAsync(categories);

            }
          
        }
    }
}
