using System;

class Dog : Animal // Класс Dog наследует от Animal
{
    public override void MakeSound() // Переопределение метода
    {
        Console.WriteLine("Bark");
    }
}