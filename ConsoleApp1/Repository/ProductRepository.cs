using ConsoleApptoAPI.Models;

namespace ConsoleApptoAPI.Repository
{
	public class ProductRepository
	{
		private List<ProductModel> products = new List<ProductModel>();

		public int AddProduct(ProductModel product)
		{
			product.Id = products.Count + 1;
			products.Add(product);
			return product.Id;
		}

		public List<ProductModel> GetAllProducts()
		{ return products; }
	}
}