namespace ECommerceFacade.Subsystems
{
    internal class Payment
    {
        public void Process(double ammount)
        {
            Console.WriteLine($"Charging {ammount:F2} to selected credit card");
        }
    }
}
