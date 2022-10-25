using CarStrategy1;

Console.WriteLine("Hello, Vanko!");

Car car = new Car("Audi","A8",12,50);

Bus bus = new Bus("Man","A500",25,200 );

car.Еxpense(20);
bus.Еxpense(20);
Console.WriteLine("--------------------------------------------");
car.Еxpense(50);
bus.Еxpense(50);
Console.WriteLine("--------------------------------------------");
car.Еxpense(100);
bus.Еxpense(100);
Console.WriteLine("--------------------------------------------");
car.Еxpense(400);
bus.Еxpense(400);

