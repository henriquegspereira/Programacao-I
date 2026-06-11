using Repository.VirtualDataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Seeds
{
    public static class CategorySeeds
    {
        public static void Seed()
        {
            MyData.Categories.AddRange(new List<Model.Category>
            {
                new Model.Category { Id = 1, Name = "Electronics" },
                new Model.Category { Id = 3, Name = "Clothing" },
                new Model.Category { Id = 2, Name = "Books" }
                
            });
        }
    }
}
