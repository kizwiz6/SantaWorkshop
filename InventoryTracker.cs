using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    /// <summary>
    /// This class implements the IInventoryTracker interface, which defines two methods: UpdateInventory and CheckInventory. The InventoryTracker class maintains a dictionary of toy names and quantities, and provides methods to update the inventory and check the current quantity of a particular toy. The InventoryTracker class follows the Interface Segregation Principle because it only provides the methods that are necessary for tracking inventory, and does not force clients to depend on any additional methods that they may not need.
    /// </summary>
    internal class InventoryTracker : IInventoryTracker
    {
        private readonly Dictionary<string, int> _inventory;

        public InventoryTracker()
        {
            _inventory = new Dictionary<string, int>();
        }
        public int CheckInventory(string toyName)
        {
            if (_inventory.ContainsKey(toyName))
            {
                return _inventory[toyName];
            }

            return 0;
        }

        public void UpdateInventory(string toyName, int quantity)
        {
            if (_inventory.ContainsKey(toyName))
            {
                _inventory[toyName] += quantity;
            }
            else
            {
                _inventory.Add(toyName, quantity);
            }
        }
    }
}
