namespace BAU.Northwind.DataAccess.Abstract
{
    using BAU.Core.DataAccess;
    using BAU.Northwind.Entities.Concrete;

    public interface ICategoryDal : IEntityRepository<Category>
    {
        // Custom Operations
    }
}