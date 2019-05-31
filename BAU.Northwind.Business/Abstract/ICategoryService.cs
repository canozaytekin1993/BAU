namespace BAU.Northwind.Business.Abstract
{
    using System.Collections.Generic;
    using BAU.Northwind.Entities.Concrete;

    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}