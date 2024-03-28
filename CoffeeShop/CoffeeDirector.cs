using _14._Creational_Design_Patterns.Ingredients;
using _14._Creational_Design_Patterns.Ingredients.Milk;

namespace _14._Creational_Design_Patterns.CoffeeShop
{
    public class CoffeeDirector
    {
        private readonly CoffeeBuilder _builder = new();

        public CoffeeDrink CreateEspresso(EMilk? additionalMilk = null, bool sugar = false)
        {
            _builder.Reset();
            _builder
                .AddBlackCoffee(new BlackCoffee());

            if (sugar)
                _builder.AddSugar(new Sugar());

            if (additionalMilk is not null)
            {
                BaseMilk milkVariant = GetMilk(additionalMilk.Value);

                _builder.AddMilk(milkVariant);
            }

            return _builder.GetResult();
        }

        public CoffeeDrink CreateCappuccino(EMilk milk, bool additionalMilk = false, bool sugar = false)
        {
            _builder.Reset();
            _builder
                .AddBlackCoffee(new BlackCoffee())
                .AddMilk(GetMilk(milk));

            if (sugar)
                _builder.AddSugar(new Sugar());

            if (additionalMilk)
            {
                BaseMilk milkVariant = GetMilk(milk);

                _builder.AddMilk(milkVariant);
            }

            return _builder.GetResult();
        }

        public CoffeeDrink CreateFlatWhite(EMilk milk, bool additionalMilk = false, bool sugar = false)
        {
            _builder.Reset();
            _builder
                .AddBlackCoffee(new BlackCoffee())
                .AddBlackCoffee(new BlackCoffee())
                .AddMilk(GetMilk(milk));

            if (sugar)
                _builder.AddSugar(new Sugar());

            if (additionalMilk)
            {
                BaseMilk milkVariant = GetMilk(milk);

                _builder.AddMilk(milkVariant);
            }

            return _builder.GetResult();
        }

        private BaseMilk GetMilk(EMilk milk)
        {
            return milk switch
            {
                EMilk.RegularMilk => new RegularMilk(),
                EMilk.OatMilk => new OatMilk(),
                EMilk.SoyMilk => new SoyMilk(),
                _ => throw new ArgumentException("No such milk"),
            };
        }
    }
}
