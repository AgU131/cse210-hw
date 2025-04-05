/* 
---> What is encapsulation and why is it important?

Encapsulation is one of the core principles of object-oriented programming. It refers to the practice of bundling related variables (attributes) and methods (functions) into a single unit, usually a class, and restricting direct access to some of the object's components. This is typically done by using private access modifiers for internal data and providing public methods (getters and setters) to read or modify them safely.
One key benefit of encapsulation is that it promotes modularity and code maintainability. By hiding the internal implementation details of a class and exposing only what is necessary, encapsulation reduces complexity and protects the integrity of the object’s state. This makes it easier to update or change internal code without affecting other parts of the program that use the class.
In my own program for the "Jumper" game, I applied encapsulation by creating separate classes such as Jumper, Puzzle, and TerminalService. Each class had its own responsibilities, and the attributes were kept private, exposing only the necessary methods to interact with them.
*/

// For example, in the Puzzle class I wrote something like:
class Puzzle:
    def __init__(self):
        self._word = ""
        self._guessed_letters = []

    def set_word(self, word):
        self._word = word

    def update_guessed_letters(self, letter):
        if letter not in self._guessed_letters:
            self._guessed_letters.append(letter)

    def is_letter_in_word(self, letter):
        return letter in self._word

/*
In this example, _word and _guessed_letters are encapsulated within the class. Other parts of the program cannot directly access or modify them. Instead, they interact with these variables through controlled methods like set_word() and update_guessed_letters(), which helps ensure that the object behaves as intended and maintains a valid state.
In conclusion, encapsulation is essential because it allows for cleaner, safer, and more maintainable code. It supports abstraction, helps enforce rules and logic internally, and provides flexibility for future enhancements.
*/