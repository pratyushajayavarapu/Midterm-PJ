using System;
//Pratyusha jayavarapu 8973016- midterm
public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initialized the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        //  Updated the item's price with the new price.
        Price = newPrice;
        Console.WriteLine($"Price of the {ItemName} update to the  {Price:P}");

    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        //  Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"Restocked {additionalQuantity} {ItemName}(s). New Stock quantity: {QuantityInStock}");

    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity solmetd.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"Sold {quantitySold} {ItemName}(s). Quantity of remaining Stock:{QuantityInStock}");
        }
        else
        {
            Console.WriteLine($"Insufficient stock. cannot sell {quantitySold} {ItemName}(s).");
        }

    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price:{Price:P}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Item 1 details:");
        item1.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Item 2 details:");
        item2.PrintDetails();
        Console.WriteLine();

        // 2. Sell some items and then print the updated details.
        item1.SellItem(10);
        Console.WriteLine();


        // 3. Restock an item and print the updated details.
        item2.RestockItem(1);
        Console.WriteLine();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($" Is {item1.ItemName} in Stock? {item1.IsInStock()}");
        Console.WriteLine($" Is {item2.ItemName} in stock? {item2.IsInStock()}");

    }
}
