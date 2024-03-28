using _14._Creational_Design_Patterns.Ingredients;
using _14._Creational_Design_Patterns.Ingredients.Milk;

namespace _14._Creational_Design_Patterns.CoffeeShop
{
    public class CoffeeDrink
    {
        private readonly List<BlackCoffee> _blackCoffee = [];

        private readonly List<BaseMilk> _milk = [];

        private readonly List<Sugar> _sugar = [];

        public void AddBlackCoffee(BlackCoffee blackCoffee)
        {
            _blackCoffee.Add(blackCoffee);
        }

        public void AddMilk(BaseMilk milk)
        {
            _milk.Add(milk);
        }

        public void AddSugar(Sugar sugar)
        {
            _sugar.Add(sugar);
        }

        public void ShowRecipe()
        {
            Console.WriteLine("\nCoffee Recipe: \n");

            for (int i = 0; i < _blackCoffee.Count; i++)
                Console.WriteLine("Black Coffee");

            foreach (BaseMilk milk in _milk)
                Console.WriteLine(milk.GetType().Name);

            for (int i = 0; i < _sugar.Count; i++)
                Console.WriteLine("Sugar");
        }
    }
}
