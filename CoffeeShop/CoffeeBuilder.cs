using _14._Creational_Design_Patterns.Ingredients;
using _14._Creational_Design_Patterns.Ingredients.Milk;

namespace _14._Creational_Design_Patterns.CoffeeShop
{
    public class CoffeeBuilder
    {
        private CoffeeDrink result = new();

        public void Reset()
        {
            result = new CoffeeDrink();
        }

        public CoffeeDrink GetResult()
        {
            return result;
        }

        public CoffeeBuilder AddBlackCoffee(BlackCoffee blackCoffee)
        {
            result.AddBlackCoffee(blackCoffee);

            return this;
        }

        public CoffeeBuilder AddMilk(BaseMilk milk)
        {
            result.AddMilk(milk);

            return this;
        }

        public CoffeeBuilder AddSugar(Sugar sugar)
        {
            result.AddSugar(sugar);

            return this;
        }
    }
}
