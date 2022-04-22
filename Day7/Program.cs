using Day7;
using System;
using Day7.Class.Class;
using System.Collections.Generic;
using Day7.q7;

//Working with methods
//1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
//reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
//become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
//To accomplish this, you’ll create three methods: one to create the array, one to reverse the
//array, and one to print the array at the end.
//Your Mainmethod will look something like this:
//static void Main(string[] args)
//{
//    int[] numbers = GenerateNumbers();
//    Reverse(numbers);
//    PrintNumbers(numbers);
//}
//The GenerateNumbersmethod should return an array of 10 numbers. (For bonus points,
//change the method to allow the desired length to be passed in, instead of just always
//being 10.)
//The PrintNumbersmethod should use a foror foreachloop to print out each item in the
//array. The Reversemethod will be the hardest. Give it a try and see what you can make
//happen. If you get
//stuck, here’s a couple of hints:
//Hint #1:To swap two values, you will need to place the value of one variable in a temporary
//location to make the swap:
//// Swapping a and b.
//int a = 3;
//int b = 5;
//int temp = a;
//a = b;
//b = temp;
//Hint #2:Getting the right indices to swap can be a challenge. Use a forloop, starting at 0
//and going up to the length of the array / 2. The number you use in the forloop will be the
//index of the first number to swap, and the other one will be the length of the array minus
//the index minus 1. This is to account for the fact that the array is 0-based. So basically,
//you’ll be swapping array[index] with array[arrayLength – index – 1].
Console.WriteLine("Before reverse the array is as follows:");
int[] res = ReverseArray.GenerateNumbers(10);
ReverseArray.PrintNumbers(res);
Console.WriteLine("After reverse the array is as follows:");
ReverseArray.Reverse(res);
ReverseArray.PrintNumbers(res);





//2. The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
//and every other number in the sequence after it is the sum of the two numbers before it. So
//the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
//which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
//number: 2 + 3 = 5.This keeps going forever.
//The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
//Because one number is defined by the numbers before it, this sets up a perfect
//opportunity for using recursion.
//Your mission, should you choose to accept it, is to create a method called Fibonacci, which
//takes in a number and returns that number of the Fibonacci sequence. So if someone calls
//Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
//someone calls Fibonacci(8), it would return 21.
//In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
//sequence and print them out.
//Hint #1:Start with your base case. We know that if it is the 1st or 2nd number, the value will
//be 1.
//Hint #2:For every other item, how is it defined in terms of the numbers before it? Can you
//come up with an equation or formula that calls the Fibonaccimethod again?

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"the {i}th fib number is {Fibonacci.GetNthNumber(i)}");
}



//Designing and Building Classes using object-oriented principles
//1.Write a program that that demonstrates use of four basic principles of
//object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
///Polymorphism/.
///

//2. Use /Abstraction/ to define different classes for each person type such as Student
//and Instructor. These classes should have behavior for that type of person.

//
//3. Use /Encapsulation/ to keep many details private in each class.

//4.Use / Inheritance / by leveraging the implementation already created in the Person
//class to save code in Student and Instructor classes.


//5. Use /Polymorphism/ to create virtual methods that derived classes could override to
//create specific behavior such as salary calculations.


//6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
//IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
//person specific methods). IStudentService, IInstructorService should inherit from
//IPersonService.
//Person
//Calculate Age of the Person
//Calculate the Salary of the person, Use decimal for salary
//Salary cannot be negative number
//Can have multiple Addresses, should have method to get addresses
//Instructor
//Belongs to one Department and he can be Head of the Department
//Instructor will have added bonus salary based on his experience, calculate his
//years of experience based on Join Date
//Student
//Can take multiple courses
//Calculate student GPA based on grades for courses
//Each course will have grade from A to F
//Course
//Will have list of enrolled students
//Department
//Will have one Instructor as head
//Will have Budget for school year (start and end Date Time)
//Will offer list of courses

List<String> rebby_address = new List<String> { "1 avenue", "2 blvd" };
Instructor Rebby = new Instructor(1,"1988-10-30","2014-01-01","Rebby","Female", 
    35, 40, rebby_address , 2, 1,"Instructor");

Console.WriteLine(Rebby.ReportsTo);

//7. Try creating the two classes below, and make a simple program to work with them, as
//described below
//Create a Color class:
//On a computer, colors are typically represented with a red, green, blue, and alpha
//(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
//A constructor that takes a red, green, blue, and alpha value.
//A constructor that takes just red, green, and blue, while alpha defaults to 255
//(opaque).
//Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
//A method to get the grayscale value for the color, which is the average of the red,
//green and blue values.
//Create a Ball class:
//The Ball class should have instance variables for size and color (the Color class you just
//created). Let’s also add an instance variable that keeps track of the number of times it
//has been thrown.
//Create any constructors you feel would be useful.
//Create a Pop method, which changes the ball’s size to 0.
//Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been
//popped (has a size of 0).
//A method that returns the number of times the ball has been thrown.
//Write some code in your Main method to create a few balls, throw them around a few
//times, pop a few, and try to throw them again, and print out the number of times that the
//balls have been thrown. (Popped balls shouldn’t have changed.)


Console.WriteLine(" ball red, size 5, blue size 5, black size 5, all no thrown before");
Ball blueball = new Ball(5, "Blue", 0);
Ball redball = new Ball(5, "Red", 0);
Ball blackball = new Ball(5, "Black", 0);

for (int i = 0; i < 2; i++)
{
    blueball.Throw();
}

blueball.Pop();

for (int i = 0; i < 3; i++)
{
    blackball.Throw();
}

for (int i = 0; i < 2; i++)
{
    blueball.Throw();
    redball.Throw();
}

Console.WriteLine($"Redball had been thrown {redball.TimesOfThrown()} times  " +
    $"size is {redball.Size}");
Console.WriteLine($"Blackball had been thrown {blackball.TimesOfThrown()} times  " +
    $"size is {blackball.Size}");
Console.WriteLine($"Blueball had been thrown {blueball.TimesOfThrown()}times  " +
    $"size is {blueball.Size}");


