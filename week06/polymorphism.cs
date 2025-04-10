/*
CSE210 Activity Week 6 - Agustin Heredia
What is polymorphism and why is it important?

Polymorphism is when different classes can use the same method name but have different behaviors.
In simple terms, it lets us treat different types of objects in a similar way, while still allowing each one to do its own thing. It comes from the Greek words meaning “many forms.”
One of the main benefits of polymorphism is that it makes our code more flexible and easier to expand. 
For example, if we have several types of activities in a program (like breathing, reflection, and listing), we can call the same method on each of them without worrying about how each one works internally.

In my program, I created a base class called Activity with a method named Run(). Then I made different types of activities like BreathingActivity, ReflectionActivity, and ListingActivity, and each one had its own version of Run(). 
When I stored them in a list and went through each one calling Run(), the right version ran depending on the type of activity.
*/

//Here’s an example of how I used polymorphism in my code:
public class Activity
{
    public virtual void Run()
    {
        Console.WriteLine("Starting a generic activity...");
    }
}

public class BreathingActivity : Activity
{
    public override void Run()
    {
        Console.WriteLine("Breathe in... Breathe out... fuuuuuuuuuuuuuu");
    }
}

// Using polymorphism:
Activity activity = new BreathingActivity();
activity.Run();  // This prints: "Breathe in... ... "

/*
Even though activity is declared as the base class Activity, it runs the BreathingActivity version of Run() because that’s what it really is. 
This helped me keep my code clean and allowed me to easily add new types of activities without rewriting a bunch of logic.
*/