using ECommerceFacade.Subsystems;

namespace ECommerceFacade
{
    internal class OrderFacade
    {
        private Shipping _shippingSystem;
        private Payment _paymentSystem;
        private Inventory _inventorySystem;

        public OrderFacade()
        {
            _shippingSystem = new Shipping();
            _paymentSystem = new Payment();
            _inventorySystem = new Inventory();
        }

        public void PlaceOrder(List<string> products, double total, string address)
        {
            Console.WriteLine("Placing order...");
            _inventorySystem.Update(products);
            _paymentSystem.Process(total);
            _shippingSystem.Ship(address);
            Console.WriteLine("Order placed successfully");
        }
    }
}
