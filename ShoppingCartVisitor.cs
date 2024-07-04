using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExercise
{
    class ShoppingCartVisitor : IShoppingCartVisitor
    {
        public double TotalPrice { get; set; } 

        public void VisitClothing(ClothingItem item)
        {
            TotalPrice += item.Cost;
            Console.WriteLine($"Added {item.Name} to cart. Price: {item.Cost:C}");
        }

        public void VisitElectronics(ElectronicsItem item)
        {
            TotalPrice += item.Cost;
            Console.WriteLine($"Added {item.Name} to cart. Price: {item.Cost:C}");
        }

        public void VisitFood(FoodItem item)
        {
            TotalPrice += item.Cost;
            Console.WriteLine($"Added {item.Name} to cart. Price: {item.Cost:C}");
        }
    }
}
