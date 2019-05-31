namespace BAU_Northwind.MvcWebUI.Controllers
{
    using BAU.Northwind.Business.Abstract;

    using BAU_Northwind_MvcWebUI.Models;

    using Microsoft.AspNetCore.Mvc;

    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public ActionResult Index()
        {
            var products = this._productService.GetAll();
            ProductListViewModel productModel = new ProductListViewModel { Products = products };
            return this.View();
        }
    }
}