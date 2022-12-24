using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    /// <summary>
    /// Interface Segregation Principle (ISP) - clients should not be forced to depend on interfaces they do not use. The IInventoryTracker interface defines two methods: UpdateInventory and CheckInventory. The IInventoryTracker interface and the InventoryTracker class follow the Interface Segregation Principle because they only provide the methods that are necessary for tracking inventory, and do not force clients to depend on any additional methods that they may not need.
    /// </summary>
    public interface IInventoryTracker
    {
        void UpdateInventory(string toyName, int quantity);
        int CheckInventory(string toyName);
    }
}
