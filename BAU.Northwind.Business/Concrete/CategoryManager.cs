namespace BAU.Northwind.Business.Concrete
{
    using System.Collections.Generic;
    using BAU.Northwind.Business.Abstract;
    using BAU.Northwind.DataAccess.Abstract;
    using BAU.Northwind.Entities.Concrete;

    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return this._categoryDal.GetList();
        }
    }
}