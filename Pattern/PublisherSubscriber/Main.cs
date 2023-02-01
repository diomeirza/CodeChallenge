class Main
{
    public void SubscribeAll()
    {
        Citizen ctz = new Citizen("Dio",17);

        Publisher pub = new Publisher();
        Subscriber sub = new Subscriber();
        pub.act += () => {sub.Subscribe1();};
        pub.act += () => {sub.Subscribe2();};
        pub.actHandler += (sender,e) => {sub.Subscribe3(e.citizen);};

        pub.publish();
        pub.publishWithParams(ctz);
        pub.publishWithParamsInitialized();

    }
    
}