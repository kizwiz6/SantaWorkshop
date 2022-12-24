using SantaWorkshop;

internal class Program
{
    static void Main(string[] args)
    {
        // create a list of available toys
        var availableToys = new List<Toy>
        {
            new Toy("Doll", 20),
            new Toy("Train", 30),
            new Toy("Car", 15)
        };

        // create an order processor and an inventory tracker
        var orderProcessor = new OrderProcessor(availableToys);
        var inventoryTracker = new InventoryTracker();

        // process a regular order
        orderProcessor.ProcessOrder("John Smith", "Doll", 2);
        inventoryTracker.UpdateInventory("Doll", -2);

        // process a special order with a 10% discount
        var specialOrderProcessor = new SpecialOrderProcessor(availableToys, 10);
        specialOrderProcessor.ProcessOrder("Jane Smith", "Train", 3);
        inventoryTracker.UpdateInventory("Train", -3);

        // check the current inventory levels
        Console.WriteLine($"Current Doll inventory: {inventoryTracker.CheckInventory("Doll")}");
        Console.WriteLine($"Current Train inventory: {inventoryTracker.CheckInventory("Train")}");
        Console.WriteLine($"Current Car inventory: {inventoryTracker.CheckInventory("Car")}");
    }
}