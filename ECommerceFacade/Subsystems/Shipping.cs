namespace ECommerceFacade.Subsystems
{
    internal class Shipping
    {
        public void Ship(string address)
        {
            Console.WriteLine("Shipping order to " + address);
        }
    }
}
