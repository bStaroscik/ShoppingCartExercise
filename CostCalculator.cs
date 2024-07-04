using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExercise
{
    internal class CostCalculator : ShoppingCartVisitor
    {
        public void visit(ElectronicsItem item)
        {
        Console.WriteLine("Calculating cost for electronic item: " + item.Name);
        }

        public void visit(ClothingItem item)
        {
            Console.WriteLine("Calculating cost for clothing item: " + item.Name);
        }

        public void visit(FoodItem item)
        {
            Console.WriteLine("Calculating cost for food item: " + item.Name);
        }
    }
}
