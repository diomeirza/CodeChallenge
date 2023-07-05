class SugarCoffeeDecorator : CoffeeDecorator
{

    public SugarCoffeeDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override decimal GetCost()
    {
        return _decoratedCoffee.GetCost() + 5;
    }
    public override string GetIngredient()
    {
        return _decoratedCoffee.GetIngredient() + " Sugar";
    }
}