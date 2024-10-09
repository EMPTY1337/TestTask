using System;

interface IShape
{
    void Draw(); // Метод для рисования фигуры
}

class Circle : IShape // Реализация интерфейса IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Square : IShape // Реализация интерфейса IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape shape1 = new Circle(); // Полиморфизм: объект Circle
        IShape shape2 = new Square(); // Полиморфизм: объект Square

        DrawShape(shape1); // Вывод: Drawing a Circle
        DrawShape(shape2); // Вывод: Drawing a Square
    }

    static void DrawShape(IShape shape) // Метод, использующий полиморфизм
    {
        shape.Draw(); // Вызов метода Draw у конкретного объекта
    }
}
//Полиморфизм