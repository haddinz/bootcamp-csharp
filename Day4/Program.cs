// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Security.Cryptography.X509Certificates;

public interface IMachine {
    public void MoveForward();
    public void MoveBackwards();
    public void Stop();
}

public class Vehicle : IMachine {
    private string Name;
    private int Wheel;
    private int Chair;
    private bool Available;

    public Vehicle(){}

    public Vehicle(string name, int wheel, int chair, bool available){
        this.Name = name;
        this.Wheel = wheel;
        this.Chair = chair;
        this.Available = available;
    }

    public void SetName(string name) {
        this.Name = name;
    }

    public string GetName() {
        return this.Name;
    }

    public void IsAvailable(bool available) {
        this.Available = available;
    }

    public void MoveForward() {
        Console.WriteLine($"{this.Name} move forward");
    }

    public void MoveBackwards() {
        Console.WriteLine($"{this.Name} move backwards");
    }

    public void Stop() {
        Console.WriteLine($"{this.Name} stop moving");
    }
}

public class Car : Vehicle {}

public class WebResponse<T> {
   private readonly T Data;
   private readonly string Message;

   public WebResponse(T data, string message) {
    this.Data = data;
    this.Message = message;
   }
}

class Program {
    static void Main() {

        Console.WriteLine("Day 4 Project Bootcamp = Looking for using interface and class");

        Car car = new();
        car.SetName("Toyota");
        car.IsAvailable(true);

        Console.WriteLine(car.GetName());
        car.MoveForward();
    }

    public WebResponse<Car> GetWebResponse(Car cars) {
        return new WebResponse<Car>(cars, "success received data");
    }
}
