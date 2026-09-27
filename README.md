# Person Encapsulation & Validation

A C# console application created to practice core Object-Oriented Programming (OOP) principles, with a strong focus on Encapsulation and data validation.

## Features
* **Encapsulated Class:** Uses private fields (`name`, `age`) to securely store the object's internal state.
* **Properties with Validation:** Implements public properties (`Name`, `Age`) to control access to the private fields. The `Age` property includes a `set` accessor with a validation rule (`if (value >= 0)`) ensuring that a person's age cannot be negative.
* **Safe Initialization:** Features a constructor `public Person(string name, int age)` that routes incoming parameters through the properties, ensuring data is validated right at the moment of object creation.
* **Data Output:** A custom `PrintInfo()` method that uses string interpolation to clearly display the user's name and age in the console.
* **Main Execution:** The `Program` class successfully instantiates a `Person` object ("Misha", 18) and executes its behavior.

## What I learned in this project
* The critical difference between a **field** (data storage) and a **property** (data access control).
* How to enforce data integrity and protect an object from invalid inputs using `set` accessors.
* How to apply the OOP principle of **Encapsulation** to write safer, more reliable code.
