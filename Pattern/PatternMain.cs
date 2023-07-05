class PatternMain
{
    public static void RunPattern()
    {
        Subject2 subjek = new Subject2();
        Observer observer1 = new Observer("dio", subjek);
        subjek.Change("apasih");
        subjek.Change("coba deh");

        Coffee kopi = new Coffee();
        SugarCoffeeDecorator kopiGula = new SugarCoffeeDecorator(kopi);
        Console.WriteLine($"Ingredients : {kopiGula.GetIngredient()}");
        Console.WriteLine($"Harga kopi dengan gula : {kopiGula.GetCost()}");

    }
}