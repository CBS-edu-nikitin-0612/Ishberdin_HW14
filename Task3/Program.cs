using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать класс Vehicle. В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
/// Создайте 3 производных класса Plane, Саг и Ship. 
/// Для класса Plane должна быть определена высота и количество пассажиров. 
/// Для класса Ship — количество пассажиров и порт приписки. 
/// Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
/// </summary>
namespace Task3
{
    class Program
    {
        static void Main()
        {
            Vehicle vehicle1 = new Vehicle();
            vehicle1.coordinat.X = 0; vehicle1.coordinat.Y = 0;
            vehicle1.cost = 10;
            vehicle1.speed = 50;
            vehicle1.yearIssue = 1995;

            Plane vehicle2 = new Plane();
            vehicle2.coordinat.X = 10; vehicle2.coordinat.Y = 10;
            vehicle2.cost = 20;
            vehicle2.speed = 30;
            vehicle2.yearIssue = 200;
            vehicle2.hight = 2;
            vehicle2.countPassenger = 3;

            Ship vehicle3 = new Ship();
            vehicle3.coordinat.X = 20; vehicle3.coordinat.Y = 20;
            vehicle3.cost = 20;
            vehicle3.speed = 30;
            vehicle3.yearIssue = 2000;
            vehicle3.port = "St. Piter";
            vehicle3.countPassenger = 3;

            Car vehicle4 = new Car();
            vehicle4.coordinat.X = 30; vehicle4.coordinat.Y = 20;
            vehicle4.cost = 100;
            vehicle4.speed = 150;
            vehicle4.yearIssue = 2005;

            vehicle1.ShowInfo();
            Console.WriteLine();
            vehicle2.ShowInfo();
            Console.WriteLine();
            vehicle3.ShowInfo();
            Console.WriteLine();
            vehicle4.ShowInfo();

            Console.ReadLine();
        }
        class Vehicle
        {
            public Coordinat coordinat = new Coordinat();
            public double cost;
            public double speed;
            public int yearIssue;

            public void ShowInfo()
            {
                Console.WriteLine($"Координыты: {coordinat.X.ToString() + ":" + coordinat.Y.ToString()}");
                Console.WriteLine($"Цена: {cost}");
                Console.WriteLine($"Скорость: {speed}");
                Console.WriteLine($"Год выпуска: {yearIssue}");
            }
        }
        class Plane : Vehicle
        {
            public double hight;
            public int countPassenger;

            public new void ShowInfo()
            {
                (this as Vehicle).ShowInfo();
                Console.WriteLine($"Высота: {hight}");
                Console.WriteLine($"Кол-во пассажиров: {countPassenger}");
            }
        }
        class Ship : Vehicle
        {
            public int countPassenger;
            public string port;

            public new void ShowInfo()
            {
                (this as Vehicle).ShowInfo();
                Console.WriteLine($"Кол-во пассажиров: {countPassenger}");
                Console.WriteLine($"Порт: {port}");
            }

        }
        class Car : Vehicle
        {

        }
        class Coordinat
        {
            public double X;
            public double Y;
        }
    }
}
