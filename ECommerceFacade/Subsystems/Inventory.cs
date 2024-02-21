namespace ECommerceFacade.Subsystems
{
    internal class Inventory
    {
        public void Update(List<string> products)
        {
            string result = "Updating inventory ammount for products";
            foreach (string product in products)
                result += " " + product;

            Console.WriteLine(result);
        }
    }
}
