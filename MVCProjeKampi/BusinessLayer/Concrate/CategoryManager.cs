using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }        

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category); 
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);   
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);  //tek değer çekmek için idye eşitledik.
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }


    }
}
