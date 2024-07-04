using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExercise
{
    interface IShoppingCartVisitor
    {
        void VisitElectronics(ElectronicsItem item);
        void VisitClothing(ClothingItem item);
        void VisitFood(FoodItem item); 
    }
}
