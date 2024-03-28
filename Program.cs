using _14._Creational_Design_Patterns.CoffeeShop;
using _14._Creational_Design_Patterns.Ingredients.Milk;

var director = new CoffeeDirector();

var cappuccino1 = director.CreateCappuccino(EMilk.RegularMilk);

cappuccino1.ShowRecipe();

var espresso1 = director.CreateEspresso(sugar: true);

espresso1.ShowRecipe();

var flatWhite1 = director.CreateFlatWhite(EMilk.SoyMilk, true, true);

flatWhite1.ShowRecipe();