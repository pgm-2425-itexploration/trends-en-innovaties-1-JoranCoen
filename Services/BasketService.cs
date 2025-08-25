using Models;

namespace Services
{
    public class BasketService
    {
        private readonly Basket _basket;

        public BasketService()
        {
            _basket = new Basket();
        }

        public void AddItem(string productId, int quantity = 1)
        {
            BasketItem? item = _basket.Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                item.Quantity += quantity;
            }
            else
            {
                _basket.Items.Add(new BasketItem { ProductId = productId, Quantity = quantity });
            }
        }

        public void RemoveItem(string productId)
        {
            BasketItem? item = _basket.Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                _basket.Items.Remove(item);
            }
        }

        public void Clear() => _basket.Items.Clear();

        public Basket GetBasket() => _basket;
    }
}
