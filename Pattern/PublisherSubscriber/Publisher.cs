class Publisher
{
    public event Action act = delegate {};
    public event EventHandler<MyEventArgs> actHandler = delegate {};

    public void publish() {
        act();
    }
    public void publishWithParams(Citizen cty) {
        actHandler(this, new MyEventArgs(cty));
    }

    public void publishWithParamsInitialized() {
        Citizen ctz = new Citizen("Dhea",18);
        actHandler(this, new MyEventArgs(ctz));
    }
    
}