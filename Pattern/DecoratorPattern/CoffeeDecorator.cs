abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _decoratedCoffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _decoratedCoffee = coffee;
    }

    public virtual decimal GetCost()
    {
        return _decoratedCoffee.GetCost();
    }

    public virtual string GetIngredient()
    {
        return _decoratedCoffee.GetIngredient();
    }
}