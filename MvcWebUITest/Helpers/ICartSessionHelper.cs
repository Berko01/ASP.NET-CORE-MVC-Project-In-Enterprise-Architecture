using Entities.DomainModels;

namespace MvcWebUITest.Helpers
{
	public interface ICartSessionHelper
	{
		Cart GetCart(string key);
		void SetCart(string key, Cart cart);
		void Clear();
	}
}
