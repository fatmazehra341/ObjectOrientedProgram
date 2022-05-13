using System;
using OOPS;
public class Program
{
    public static void Main(string[] args)
    {
        const string Path = @"C:\Users\Khadeeja Zehra\OneDrive\Desktop\Bridgelab\OOPS\OOPS\Inventory.json";
        InventoryManagement inventoryManagement = new InventoryManagement();
        bool end = true;
        Console.WriteLine("1.Display Inventory");
        while (end)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                inventoryManagement.DisplayInventory(Path);
                    break;
            }
        }
    }
}