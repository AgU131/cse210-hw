/*
CSE210 Activity Week 5 - Agustin Heredia
What is inheritance and why is it important?

Inheritance is an object-oriented programming principle that allows one class (called a child or subclass) to acquire the properties and behaviors (fields and methods) of another class (called a parent or base class). 
This relationship enables code reuse and promotes a hierarchical classification.
A key benefit of inheritance is code reuse. Instead of writing the same code in multiple classes, we can write it once in a base class and allow other classes to inherit from it. 
This makes the code easier to maintain, extend, and understand.
In my program, I implemented inheritance by creating a base class called Actor that contained shared properties and methods such as Position, Text, and Color. Then I created child classes like Rock and Gem that inherited from Actor. 
This allowed each item in the game to behave like an Actor but also have its own unique characteristics.

*/ 

// Here is an example:
public class Actor
{
    public string Text { get; set; }
    public Point Position { get; set; }

    public void Move(Point velocity)
    {
        Position = new Point(Position.X + velocity.X, Position.Y + velocity.Y);
    }
}

public class Rock : Actor
{
    public Rock()
    {
        Text = "O";
    }
}

/*
In this example, the Rock class inherits from Actor. It doesn’t need to reimplement properties like Text or methods like Move because it gets them automatically from the Actor base class. This makes the game code more organized and easier to scale as more item types (like Gem) are added.
Inheritance is important because it helps build programs in a modular and extensible way, following the DRY principle (Don't Repeat Yourself). It allows us to focus on what makes each subclass unique, while keeping shared functionality centralized in a base class.
*/ 