namespace CarStrategy1;

public class Vehicle : IStrategy
{
    public Vehicle(string make, string model,double expenseFor100Km,double fuel)
    {
        Make = make;
        Model = model;
        ЕxpenseFor100Km = expenseFor100Km;
        Fuel = fuel;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public double ЕxpenseFor100Km { get; set; }
    public double Fuel { get; set; }
    
    public void CurrentFuel()
    {
        Console.WriteLine($"Current fuel: {Fuel}");
    }

    public void Еxpense(double km)
    {
        var currentExpense = km * (ЕxpenseFor100Km / 100);
        if (Fuel>=currentExpense)
        { 
            Fuel -= currentExpense;
            Console.WriteLine($"You used {currentExpense} liters of fuel for {km} km"); 
        }
        else
        {
            Console.WriteLine("You don't have enough fuel.");
        }
    }
}