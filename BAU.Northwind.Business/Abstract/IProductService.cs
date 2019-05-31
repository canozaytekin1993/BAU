namespace BAU.Northwind.Business.Abstract
{
    using System.Collections.Generic;
    using BAU.Northwind.Entities.Concrete;

    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategory(int categoryId);

        void Add(Product product);

        void Update(Product product);

        void Delete(int productId);
    }
}