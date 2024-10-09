using System;


class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal is eating.");
    }

    public virtual void MakeSound() // Используем virtual для переопределения
    {
        Console.WriteLine("Some generic animal sound.");
    }
}
