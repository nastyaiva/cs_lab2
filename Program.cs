using System;

//Задание 1
//public class Pupil
//{
//    public virtual void Study() { Console.WriteLine("Учится"); }
//    public virtual void Read() { Console.WriteLine("Читает"); }
//    public virtual void Write() { Console.WriteLine("Пишет."); }
//    public virtual void Relax() { Console.WriteLine("Отдыхает."); }
//}

//public class ExcelentPupil : Pupil
//{
//    public override void Study() { Console.WriteLine("Учится отлично"); }
//    public override void Read()
//    {
//        Console.WriteLine("Читает много");
//    }
//    public override void Write() { Console.WriteLine("Пишет отлично"); }
//    public override void Relax() { Console.WriteLine("Отдыхает мало"); }
//}

//public class GoodPupil : Pupil
//{
//    public override void Study() { Console.WriteLine("Учится нормально"); }
//    public override void Read()
//    {
//        Console.WriteLine("Читает немало");
//    }
//    public override void Write() { Console.WriteLine("Пишет нормально"); }
//    public override void Relax() { Console.WriteLine("Отдыхает немного"); }
//}

//public class BadPupil : Pupil
//{
//    public override void Study() { Console.WriteLine("Учится плохо"); }
//    public override void Read() { Console.WriteLine("Читает мало"); }
//    public override void Write() { Console.WriteLine("Пишет плохо"); }
//    public override void Relax() { Console.WriteLine("Отдыхает много"); }
//}
//public class ClassRoom
//{
//    private Pupil[] pupils;
//    public ClassRoom(params Pupil[] pupils)
//    {
//        if (pupils.Length < 2 || pupils.Length > 4)
//            throw new ArgumentException("Не то кол-во");
//        this.pupils = pupils;
//    }
//    public void ShowPupilsSkills()
//    {
//        foreach (var pupil in pupils)
//        {
//            pupil.Study();
//            pupil.Read();
//            pupil.Write();
//            pupil.Relax();
//            Console.WriteLine();
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Pupil pupil1 = new ExcelentPupil();
//        Pupil pupil2 = new GoodPupil();
//        Pupil pupil3 = new BadPupil();
//        Pupil pupil4 = new ExcelentPupil();
//        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
//        classRoom.ShowPupilsSkills();
//    }
//}


//Задание 2

//public class Vehicle
//{
//    protected double x;
//    protected double y;
//    protected decimal price;
//    protected double speed;
//    protected int year;
//    public Vehicle(double x, double y, decimal price, double speed, int year)
//    {
//        this.x = x;
//        this.y = y;
//        this.price = price;
//        this.speed = speed;
//        this.year = year;
//    }
//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"{x} , {y}");
//        Console.WriteLine(price);
//        Console.WriteLine(speed);
//        Console.WriteLine(year);
//    }
//}
//public class Plane : Vehicle
//{
//    private double altitude;
//    private int passengerCount;
//    public Plane(double x, double y, decimal price, double speed, int year, double altitude, int passengerCount)
//        : base(x, y, price, speed, year)
//    {
//        this.altitude = altitude;
//        this.passengerCount = passengerCount;
//    }
//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine(altitude);
//        Console.WriteLine(passengerCount);
//    }
//}
//public class Car : Vehicle
//{
//    private int passengerCount;
//    public Car(double x, double y, decimal price, double speed, int year, int passengerCount)
//        : base(x, y, price, speed, year)
//    {
//        this.passengerCount = passengerCount;
//    }
//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine(passengerCount);
//    }
//}
//public class Ship : Vehicle
//{
//    private int passengerCount;
//    private string port;

//    public Ship(double x, double y, decimal price, double speed, int year, int passengerCount, string port)
//        : base(x, y, price, speed, year)
//    {
//        this.passengerCount = passengerCount;
//        this.port = port;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine(passengerCount);
//        Console.WriteLine(port);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Vehicle[] vehicles = new Vehicle[]
//        {
//            new Plane(10.5, 20.3, 1500000m, 900.0, 2020, 10000.0, 180),
//            new Car(5.0, 15.0, 30000m, 150.0, 2018, 5),
//            new Ship(30.0, 40.0, 500000m, 50.0, 2015, 200, "Нью-Йорк")
//        };
//        foreach (var vehicle in vehicles)
//        {
//            vehicle.DisplayInfo();
//            Console.WriteLine();
//        }
//    }
//}


//Задание 3

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}
class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}
class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}
class Program
{
    static void Main(string[] args)
    {
        DocumentWorker documentWorker;
        Console.WriteLine("Введите номер ключа доступа (pro/expert): ");
        string key = Console.ReadLine();
        switch (key.ToLower())
        {
            case "pro":
                documentWorker = new ProDocumentWorker();
                break;
            case "expert":
                documentWorker = new ExpertDocumentWorker();
                break;
            default:
                documentWorker = new DocumentWorker();
                break;
        }
        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}