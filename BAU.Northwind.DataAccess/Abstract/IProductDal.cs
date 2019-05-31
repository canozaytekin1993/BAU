namespace BAU.Northwind.DataAccess.Abstract
{
    using BAU.Core.DataAccess;
    using BAU.Northwind.Entities.Concrete;

    public interface IProductDal : IEntityRepository<Product>
    {
        // Custom Operations
    }
}