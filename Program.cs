using System;
using System.Drawing;
using System.Threading;

class Rectangle
{
    public double length;
    public double width;
    public static string Formyla;

    //Конструктор по умолчанию
    public Rectangle()
    {
        length = 3.5;
        width = 5.5;

    }
    // Конструктор с параметрами
    public Rectangle(double Length, double Width)
    {
        this.length = Length;
        this.width = Width;
    }
    // кнструктор копирования
    public Rectangle(Rectangle rectangle)
    {
        this.length = rectangle.length;
        this.width = rectangle.width;
    }
    // статический конструктор
    static Rectangle()
    {
        Formyla = "a * b";
    }
    // диструкторы
    ~Rectangle()
    {
        Console.WriteLine("Диструктор вызван");
    }

}
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Формула: {Rectangle.Formyla}");

        Rectangle S = new Rectangle();
        Console.WriteLine($"Конструктор по умолчанию: Площадь равна: {S.length * S.width}");

        Rectangle rect2 = new Rectangle(7.2, 4.8);
        Console.WriteLine($"Конструктор с параметрами: Площадь = {rect2.length * rect2.width}");

        Rectangle rect3 = new Rectangle(rect2);
        Console.WriteLine($"Конструктор копирования: Площадь = {rect3.length * rect3.width}");

        

    }

}