using Model;
using Repository.VirtualDataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CategoryRepository 
        : BaseRepository<Category>
    {
        public List<Category> GetAll()
        {
            return MyData.Categories;
        }
    }
}
