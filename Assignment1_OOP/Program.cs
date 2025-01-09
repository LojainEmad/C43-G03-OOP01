using System;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment1_OOP
{

    #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
    //enum WeekDays
    //{
    //    saturday, sunday, monday, tuesday, wednesday, thursday, friday
    //}
    #endregion
    #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    //struct Person
    //{
    //    private string name;
    //    private int age;

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }
    //}

    #endregion
    #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
    //enum Season
    //{
    //    Spring, Summer, Autumn, Winter
    //}
    #endregion
    #region 5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
    //enum Colors
    //{
    //    Red, Green, Blue
    //}
    #endregion
    #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    //struct Point
    //{
    //    private double x;
    //    private double y;
    //    public double X
    //    {
    //        get { return x; }
    //        set { x = value; }
    //    }
    //    public double Y
    //    {
    //        get { return y; }
    //        set { y = value; }
    //    }
    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //}

    #endregion
    #region 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# prog8.ram that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
    //struct Person
    //{
    //    private string name;
    //    private int age;

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }
    //}
    #endregion
    #region Additional question : Create a struct named Rectangle that represents a rectangle with the following fields:width(type: double)height(type: double)Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * height).Implement a method DisplayInfo that prints the rectangle's dimensions and area.Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.
    //struct Rectangle
    //{
    //    private double width;
    //    private double height;
    //    public double WidthGetter
    //    {
    //        get { return width; }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                Console.WriteLine("width cannot be negative");
    //            }
    //            else
    //            {
    //                width = value;
    //            }
    //        }
    //    }
    //    public double HeightGetter
    //    {
    //        get { return height; }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                Console.WriteLine("height cannot be negative");
    //            }
    //            else
    //            {
    //                height = value;
    //            }
    //        }
    //    }
    //    public double Area
    //    {
    //        get { return width * height; }
    //    }
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"rectangle dimensions: width = {width}, height = {height}");
    //        Console.WriteLine($"area = {Area}");
    //    }

    //}

    #endregion


    internal class Program
    {
        #region 6-function for calculate_distance for question 6
        //static double CalcDist(Point p1, Point p2)
        //{
        //    double distX = p2.X - p1.X;
        //    double distY = p2.Y - p1.Y;
        //    return Math.Sqrt(distX * distX + distY * distY);
        //}
        #endregion
        #region 7-function for question 7
        //static Person OldestPerson(Person[] arr)
        //{
        //    Person oldest = arr[0];
        //    foreach (var person in arr)
        //    {
        //        if (person.Age > oldest.Age)
        //        {
        //            oldest = person;
        //        }
        //    }
        //    return oldest;
        //}
        #endregion

        static void Main(string[] args)
        {
            #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //try
            //{
            //    Console.WriteLine("The days of the week:");
            //    for (int i = 0; i <= (int)WeekDays.friday; i++)
            //    {
            //        Console.WriteLine((WeekDays)i);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}
            #endregion
            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //try
            //{
            //    Person[] person = new Person[3];
            //    person[0] = new Person { Name = "Lojain", Age = 21 };
            //    person[1] = new Person { Name = "Hana", Age = 22 };
            //    person[2] = new Person { Name = "Noha", Age = 23 };
            //    Console.WriteLine("the details of all persons:");

            //    for (int i = 0; i < person.Length; i++)
            //    {
            //        Console.WriteLine($"Person {i + 1}: Name: {person[i].Name}, Age: {person[i].Age}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}
            #endregion
            #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //try
            //{
            //    string Input;
            //    do
            //    {
            //        Console.WriteLine("Enter season name (spring or summer or autumn or winter)");
            //        Input = Console.ReadLine();
            //        if (Enum.TryParse(Input, true, out Season s))
            //        {
            //            switch (s)
            //            {
            //                case Season.Spring:
            //                    Console.WriteLine("Spring range : march april may");
            //                    break;
            //                case Season.Summer:
            //                    Console.WriteLine("Summer range : june july august ");
            //                    break;
            //                case Season.Autumn:
            //                    Console.WriteLine("Autumn range : september october  november ");
            //                    break;
            //                case Season.Winter:
            //                    Console.WriteLine("Winter range : december january february");
            //                    break;
            //            }
            //            break;

            //        }
            //        else
            //        {
            //            Console.WriteLine("please enter correct season name");
            //        }
            //    } while (true);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}
            #endregion
            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //try
            //{
            //    string Input;
            //    Console.WriteLine("Enter Color name");
            //    Input = Console.ReadLine();
            //    if (Enum.TryParse(Input, true, out Colors c))
            //    {
            //        switch (c)
            //        {
            //            case Colors.Blue:
            //                Console.WriteLine("Blue is primary color");
            //                break;
            //            case Colors.Red:
            //                Console.WriteLine("Red is primary color");
            //                break;
            //            case Colors.Green:
            //                Console.WriteLine("Green is primary color");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Input} is not primary color");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");

            //}

            #endregion
            #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //try
            //{
            //    Console.WriteLine("enter X and Y for the first point ");
            //    bool f;
            //    double x1, x2, y1, y2;
            //    do
            //    {
            //        Console.Write("x1: ");
            //        f = double.TryParse(Console.ReadLine(), out x1);
            //    } while (!f);
            //    do
            //    {
            //        Console.Write("y1: ");
            //        f = double.TryParse(Console.ReadLine(), out y1);
            //    } while (!f);
            //    Console.WriteLine("enter X and Y for the second point ");
            //    do
            //    {
            //        Console.Write("x2: ");
            //        f = double.TryParse(Console.ReadLine(), out x2);
            //    } while (!f);
            //    do
            //    {
            //        Console.Write("y2: ");
            //        f = double.TryParse(Console.ReadLine(), out y2);
            //    } while (!f);
            //    Point point1 = new Point(x1, y1);
            //    Point point2 = new Point(x2, y2);
            //    double distance = CalcDist(point1, point2);
            //    Console.WriteLine($"The distance between the two points is: {distance:F3}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}

            #endregion
            #region 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# prog8.ram that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //try
            //{
            //    bool f = false;
            //    int n1;
            //    string n;
            //    Person[] arr = new Person[3];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        string nameInput;
            //        do
            //        {
            //            Console.WriteLine($"enter the name of person{i + 1} : ");
            //            nameInput = Console.ReadLine();
            //            if (nameInput != null && nameInput.Length > 0 && nameInput.All(char.IsLetter))
            //            {
            //                arr[i].Name = nameInput;
            //                f = true;
            //            }
            //            else
            //            {
            //                Console.WriteLine("invalid input for name");
            //            }
            //        } while (!f);
            //        do
            //        {
            //            Console.WriteLine($"enter the age of person{i + 1} : ");
            //            f = int.TryParse(Console.ReadLine(), out n1);
            //            arr[i].Age = n1;
            //        } while (!f);
            //    }
            //    Console.Clear();
            //    Person oldestPerson = OldestPerson(arr);

            //    Console.WriteLine($"The oldest person is{oldestPerson.Name},with Age: {oldestPerson.Age}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}
            #endregion
            #region Additional question : Create a struct named Rectangle that represents a rectangle with the following fields:width(type: double)height(type: double)Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * height).Implement a method DisplayInfo that prints the rectangle's dimensions and area.Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.
            //try
            //{
            //    Rectangle rect = new Rectangle();
            //    double InputWidth;
            //    double InputHeight;
            //    bool f;
            //    do
            //    {
            //        Console.WriteLine("enter the +ve value for width of the rectangle :");
            //        f = double.TryParse(Console.ReadLine(), out InputWidth);
            //        rect.WidthGetter = InputWidth;
            //    } while (!f || InputWidth <= 0);
            //    do
            //    {
            //        Console.WriteLine("enter the +ve value for height of the rectangle :");
            //        f = double.TryParse(Console.ReadLine(), out InputHeight);
            //        rect.HeightGetter = InputHeight;
            //    } while (!f || InputHeight <= 0);
            //    Console.Clear();
            //    rect.DisplayInfo();
            //}
            //catch (Exception ex)

            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}
            #endregion

        }
    }
}
