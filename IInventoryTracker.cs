using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    /// <summary>
    /// Interface Segregation Principle (ISP) - clients should not be forced to depend on interfaces they do not use. The IInventoryTracker interface defines two methods: UpdateInventory and CheckInventory
    /// </summary>
    public interface IInventoryTracker
    {
        void UpdateInventory(string toyName, int quantity);
        int CheckInventory(string toyName);
    }
}
