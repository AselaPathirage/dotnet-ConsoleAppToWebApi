using ConsoleApptoAPI.Models;

namespace ConsoleApptoAPI.Repository
{
	public interface IProductRepository
	{
		int AddProduct(ProductModel product);
		List<ProductModel> GetAllProducts();
		string GetProductName();
	}
}