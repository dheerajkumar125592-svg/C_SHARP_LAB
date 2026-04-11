using System;


class Vehicle
{
    public string vehicle_type;

    public Vehicle(string vtype)
    {
        vehicle_type = vtype;
    }

   
    public void show()
    {
        Console.WriteLine("Vehicle Type: " + vehicle_type);
    }
}


class Car : Vehicle
{
    public string model_type;
    public string company_name;

 
    public Car(string vtype, string mtype, string cname) : base(vtype)
    {
        model_type = mtype;
        company_name = cname;
    }

    
    public void show()
    {
        base.show();

        Console.WriteLine("Model Type: " + model_type);
        Console.WriteLine("Company Name: " + company_name);
    }
}

class Program
{
    static void Main()
    {
        
        Car c1 = new Car("Four Wheeler", "SUV", "Toyota");

        Console.WriteLine("Vehicle Details:");
        c1.show();
    }
}