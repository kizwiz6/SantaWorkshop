using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    /// <summary>
    /// Open-Closed Principle (OCP) - entities should be open for extension but closed for modification
    /// </summary>
    public interface IOrderProcessor
    {
        void ProcessOrder(string customerName, string toyName, int quantity);
    }

    public class OrderProcessor : IOrderProcessor
    {
        private readonly List<Toy> _availableToys;
        public OrderProcessor(List<Toy> availableToys)
        {
            _availableToys = availableToys;
        }

        public void ProcessOrder(string customerName, string toyName, int quantity)
        {
            var toy = _availableToys.Find(x => x.Name == toyName);
            if (toy == null)
            {
                Console.WriteLine($"Sorry, {toyName} is not available.");
                return;
            }

            var totalPrice = toy.Price * quantity;
            Console.WriteLine($"Thank you for your order, {customerName}! The total cost of your {quantity} {toyName} toys is ${totalPrice}.");
        }

    }
}
