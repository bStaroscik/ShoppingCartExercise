using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExercise
{
    class ClothingItem : IShoppingCartItem
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public ClothingItem(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        //public string getName()
        //{
        //    return Name;
        //}

        //public double getCost()
        //{
        //    return Cost;
        //}

        public void accept(IShoppingCartVisitor visitor)
        {
            visitor.VisitClothing(this);
        }
    }
}
