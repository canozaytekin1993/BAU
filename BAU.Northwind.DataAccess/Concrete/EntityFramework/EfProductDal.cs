namespace BAU.Northwind.DataAccess.Concrete.EntityFramework
{
    using BAU.Core.DataAccess.EntityFramework;
    using BAU.Northwind.DataAccess.Abstract;
    using BAU.Northwind.Entities.Concrete;

    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}