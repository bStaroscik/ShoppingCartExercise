using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExercise
{
    class ShoppingCart
    {
        private List<IShoppingCartItem> items = new List<IShoppingCartItem>();

        public void addItem(IShoppingCartItem item)
        {
            items.Add(item);
        }

        public void removeItem(IShoppingCartItem item)
        {
            items.Add(item);
        }

        public void Accept(IShoppingCartVisitor visitor)
        {
            foreach (var item in items)
            {
                item.accept(visitor);
            }
        }
    }
}
