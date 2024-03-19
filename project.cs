using System;
using System.IO;

public interface IResizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

public abstract class Shape
{
    public abstract double GetPerimeter();
    public abstract double GetArea();
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
    public virtual void Erase()
    {
        Console.WriteLine("Erasing Shape");
    }
}

public class Rectangle : Shape, IResizable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int width)
    {
        this.width = width;
    }

    public void ResizeHeight(int height)
    {
        this.height = height;
    }

    public void PrintSize()
    {
     Console.WriteLine("Width: " + width + ", Height: " + height);
    }

    public override double GetArea()
    {
        return width * height;
    }

    public override double GetPerimeter()
    {
        return 2 * (width + height);
    }
}

public class Triangle : Shape
{
    private double width, height;

    public Triangle()
    {
        this.width = 1;
        this.height = 1;
    }

    public Triangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height / 2;
    }

    public override double GetPerimeter()
    {
        return width + height + Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(side, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }
}

public class Complex
{
    public int real;
    public int imaginary;

    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static Complex operator +(Complex one, Complex two)
    {
        return new Complex(one.real + two.real, one.imaginary + two.imaginary);
    }

    public override string ToString()
    {
     return real + " + " + imaginary + "i";
    }
}

public class Substrings
{
    public static void FindSubstrings(string input_string)
    {
        for (int i = 1; i <= input_string.Length; i++)
        {
            for (int j = 0; j <= input_string.Length - i; j++)
            {
                Console.WriteLine(input_string.Substring(j, i));
            }
        }
    }
}

public class Program
{
    static void Main()
    {
		string name = "Janardhan K Y";
    string usn = "4MH21CS036";
    string faculty = "Victor Sir";
	
				Console.WriteLine("Name: " + name);
Console.WriteLine("USN: " + usn);
Console.WriteLine("Faculty: " + faculty);
        while (true)
        {


            Console.WriteLine("Menu:");
            Console.WriteLine("1. Arithmetic Operations");
            Console.WriteLine("2. Check Armstrong Number");
            Console.WriteLine("3. Find Substrings");
            Console.WriteLine("4. Divide by Zero Exception");
            Console.WriteLine("5. Pascal's Triangle");
            Console.WriteLine("6. Floyd's Triangle");
            Console.WriteLine("7. Read File");
            Console.WriteLine("8. Stack Operations");
            Console.WriteLine("9. Complex Number Operations");
            Console.WriteLine("10. Shapes Drawing and Erasing");
            Console.WriteLine("11. Shapes Area and Perimeter");
            Console.WriteLine("12. Resize Rectangle");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ArithmeticOperations();
                    break;
                case 2:
                    CheckArmstrongNumber();
                    break;
                case 3:
                    Console.Write("Enter a string: ");
                    string inputString = Console.ReadLine();
                    Substrings.FindSubstrings(inputString);
                    break;
                case 4:
                    DivideByZeroException();
                    break;
                case 5:
                    Console.Write("Enter the number of rows for Pascal's Triangle: ");
                    int numRows = int.Parse(Console.ReadLine());
                    PrintPascalsTriangle(numRows);
                    break;
                case 6:
                    Console.Write("Enter the number of rows for Floyd's Triangle: ");
                    int floydRows = int.Parse(Console.ReadLine());
                    PrintFloydsTriangle(floydRows);
                    break;
                case 7:
      ReadFile();
                    break;
                case 8:
                    StackOperations();
                    break;
                case 9:
                    ComplexNumberOperations();
                    break;
                case 10:
                    ShapesDrawingErasing();
                    break;
                case 11:
                    ShapesAreaPerimeter();
                    break;
                case 12:
                    ResizeRectangle();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
			}
			 Console.Write("Do you wish to continue? (y/n): ");
        char continueChoice = Console.ReadLine().ToLower()[0];
        if (continueChoice != 'y')
        {
            break;
        }
		}
    }

    private static void ArithmeticOperations()
    {
        Console.WriteLine("Enter a First Number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter a Second Number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter an Operator (+, -, *, /, %, ^ for power, e for exponential): ");
        char op = Console.ReadLine()[0];

        switch (op)
        {
            case '+':
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                else
                    Console.WriteLine("Error: Division by zero is not possible.");
                break;
            case '%':
                Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2));
                break;
            case '^':
                Console.WriteLine(num1 + " ^ " + num2 + " = " + Math.Pow(num1, num2));
                break;
            case 'e':
                Console.WriteLine(num1 + " ^ e = " + Math.Exp(num1));
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                break;
        }
    }

    private static void CheckArmstrongNumber()
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int originalNum = num;
        int result = 0;

        while (num > 0)
        {
            int digit = num % 10;
            result += digit * digit * digit;
            num /= 10;
        }

        if (originalNum == result)
        {
            Console.WriteLine(originalNum + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(originalNum + " is not an Armstrong number.");
        }
    }

    private static void DivideByZeroException()
    {
        try
        {
            int result = 15 / int.Parse("0");
            Console.WriteLine(result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }

    private static void PrintPascalsTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            int number = 1;

            for (int j = 0; j < numRows - i - 1; j++)
            {
                Console.Write("    ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write(number.ToString().PadLeft(4) + " ");

                number = number * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }

    private static void PrintFloydsTriangle(int numRows)
    {
        int num = 1;
        Console.WriteLine("Floyd's Triangle:");
        for (int i = 1; i <= numRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }

    private static void ReadFile()
    {
        string filePath = @"C:\Users\braun\OneDrive\Desktop\braham.txt";
        Console.WriteLine("Reading File using File.ReadAllText()");
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }

        Console.WriteLine("\nReading File using File.ReadAllLines()");
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
                Console.WriteLine(line);
        }

        Console.WriteLine("\nReading File using StreamReader");
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }

    private static void StackOperations()
    {
        Stack stack = new Stack();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nStack MENU(size -- 10)");
            Console.WriteLine("1. Add an element");
            Console.WriteLine("2. See the Top element.");
            Console.WriteLine("3. Remove top element.");
            Console.WriteLine("4. Display stack elements.");
            Console.WriteLine("5. Exit");
            Console.Write("Select your choice: ");
            int stackChoice = Convert.ToInt32(Console.ReadLine());
            switch (stackChoice)
            {
                case 1:
                    Console.WriteLine("Enter an Element : ");
                    stack.Push(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Top element is: " + stack.Peek());
                    break;
                case 3:
                    Console.WriteLine("Element removed: " + stack.Pop());
                    break;
                case 4:
                    stack.Display();
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
            }
            Console.ReadKey();
        }
    }

    public interface StackADT
    {
        bool IsEmpty();
        void Push(object element);
        object Pop();
        object Peek();
        void Display();
    }

    public class Stack : StackADT
    {
        private int StackSize;

        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }
        }

        public int top;
        public object[] items;

        public Stack()
        {
            StackSizeSet = 10;
            items = new object[StackSizeSet];
            top = -1;
        }

        public Stack(int capacity)
        {
            StackSizeSet = capacity;
            items = new object[StackSizeSet];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Push(object element)
        {
            if (top == StackSize - 1)
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                items[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return items[top--];
            }
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return items[top];
            }
        }

        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item " + (i + 1) + ": " + items[i]);
            }
        }
    }

    private static void ComplexNumberOperations()
    {
        Console.WriteLine("Enter Complex Number One:");
        Console.Write("Real Part: ");
        int real1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Imaginary Part: ");
        int imaginary1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Complex Number Two:");
        Console.Write("Real Part: ");
        int real2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Imaginary Part: ");
        int imaginary2 = Convert.ToInt32(Console.ReadLine());

        Complex complex1 = new Complex(real1, imaginary1);
        Complex complex2 = new Complex(real2, imaginary2);

        Complex result = complex1 + complex2;

        Console.WriteLine("Sum of complex numbers: " + result);
    }

    private static void ShapesDrawingErasing()
    {
        Console.WriteLine("Drawing and Erasing Shapes:");
        Shape[] shapes = { new Circle(5), new Triangle(), new Square(4), new Rectangle(2, 3) };

        foreach (var shape in shapes)
        {
            shape.Draw();
            shape.Erase();
            Console.WriteLine();
        }
    }

    private static void ShapesAreaPerimeter()
    {
        Console.WriteLine("Calculating Area and Perimeter of Shapes:");

        Circle circle = new Circle(5);
        Triangle triangle = new Triangle(4, 6);
        Square square = new Square(4);
        Rectangle rectangle = new Rectangle(3, 7);

        Console.WriteLine("Circle - Area: " + circle.GetArea() + ", Perimeter: " + circle.GetPerimeter());
        Console.WriteLine("Triangle - Area: " + triangle.GetArea() + ", Perimeter: " + triangle.GetPerimeter());
        Console.WriteLine("Square - Area: " + square.GetArea() + ", Perimeter: " + square.GetPerimeter());
        Console.WriteLine("Rectangle - Area: " + rectangle.GetArea() + ", Perimeter: " + rectangle.GetPerimeter());
    }

    private static void ResizeRectangle()
    {
        Console.WriteLine("Resizing Rectangle:");
        Rectangle rectangle = new Rectangle(4, 8);
        rectangle.PrintSize();

        Console.Write("Enter new width: ");
        int newWidth = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new height: ");
        int newHeight = Convert.ToInt32(Console.ReadLine());

        rectangle.ResizeWidth(newWidth);
        rectangle.ResizeHeight(newHeight);

        Console.WriteLine("Resized Rectangle:");
        rectangle.PrintSize();
    }
}
