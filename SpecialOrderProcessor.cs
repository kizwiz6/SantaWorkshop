using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    /// <summary>
    /// Liskov Substitution Principle (LSP) - derived classes should be able to be used in place of their base class without causing any issues. The SpecialOrderProcessor class follows the Liskov Substitution Principle because it can be used in place of the OrderProcessor class without causing any issues.
    /// </summary>
    public class SpecialOrderProcessor : IOrderProcessor
    {
        private readonly List<Toy> _availableToys;
        private readonly int _discountPercentage;

        public SpecialOrderProcessor(List<Toy> availableToys, int discountPercentage)
        {
            _availableToys = availableToys;
            _discountPercentage = discountPercentage;
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
            var discount = totalPrice * _discountPercentage / 100;
            totalPrice -= discount;
            Console.WriteLine($"Thank you for your special order, {customerName}! The total cost of your {quantity} {toyName} toys is ${totalPrice} (discount of ${discount} applied).");
        }
    }
}
