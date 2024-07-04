using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExercise
{
    interface IShoppingCartItem
    {
        void accept(IShoppingCartVisitor visitor);
    }
}
