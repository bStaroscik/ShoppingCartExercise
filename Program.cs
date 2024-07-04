using ShoppingCartExercise;

ShoppingCart cart = new ShoppingCart();

cart.addItem(new ElectronicsItem("Laptop", 1200.00));
cart.addItem(new ClothingItem("Shirt", 30.00));
cart.addItem(new FoodItem("Apples", 2.50));

ShoppingCartVisitor visitor = new ShoppingCartVisitor();

//Calc the total price by accepting the visitor
cart.Accept(visitor);

Console.WriteLine($"Total cost of shopping cart: { visitor.TotalPrice:C}");

Console.ReadKey();
