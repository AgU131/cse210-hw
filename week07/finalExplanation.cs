/*
CSE210 Activity Week 7 - Agustin Heredia
W07 Assignment: Explain Programming with Classes

----> Abstraction
Abstraction means hiding the complex details of how something works and only showing the parts that are necessary for using it. It helps programmers focus on what an object does, instead of how it does it.
In one of my programs, I created an Activity class with methods like DisplayStartMessage() and Run(). The user didn’t need to know how the timer or animations worked—just that calling Run() would start an activity.
This made my program easier to manage and update. If I ever want to change how the timer works, I only need to update that part of the code and everything else stays the same.

----> Encapsulation
Encapsulation means keeping data safe and protected by bundling it with the methods that work with it. It also means controlling how the data is accessed or changed using things like private variables and public methods.
In my program, I used private fields in the Activity class and gave access through public methods. For example, the duration of an activity was stored in a private variable, and I used a method SetDuration() to update it.
This protected the data from accidental changes and made sure everything worked as expected, even if the code gets bigger in the future.

----> Inheritance
Inheritance allows one class to reuse the code from another class. It helps create a hierarchy and reduces code duplication.
In my project, I created a base Activity class and then made classes like BreathingActivity, ReflectionActivity, and ListingActivity that inherited from it. These child classes reused the structure from Activity but added their own behavior.
Thanks to inheritance, I didn’t have to rewrite the timer or display logic in each activity. If I want to create a new activity in the future, I just create a new class that inherits from Activity.

----> Polymorphism
Polymorphism lets us use the same method in different ways depending on the object. It makes our code more flexible by allowing us to treat different objects through a common interface.
In my program, I had a list of Activity objects, but each one could be a BreathingActivity, ReflectionActivity, or ListingActivity. I called Run() on each item in the list, and each activity responded in its own way.
This made it really easy to add or change activities. I didn’t have to write new code for each one—I just relied on their shared interface and trusted that they’d run correctly.


Using these four principles together helped me build programs that are organized, easy to understand, and ready to grow. Each principle plays a role in writing better, more professional code.

*/